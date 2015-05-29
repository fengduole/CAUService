using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace mfCourse
{
    public class Course
    {
        public string number;   //课程号
        public string serial;   //课序号
        public string name;     //课程名
        public double credit;   //学分
        public string property; //必修、选修
        public double score;    //考试分数
        public string cnScore;  //中文分数
        public double gp;       //绩点
        public string semester; //所属学期
        public string remark;   //备注
        public bool isCalc;     //是否参与计算
        public bool isShow;     //是否显示
        public bool isDone;     //是否已经出成绩


        //构造函数
        public Course()
        {
            Clear();
        }


        //构造函数
        public Course(double Credit, double Score)
        {
            Clear();

            credit = Credit;
            score = Score;
        }


        //构造函数——各学期成绩
        public Course(string Semester, string Number, string Serial, string Name, double Credit, string Property, double Score, string CnScore, string Remark)
        {
            Clear();

            semester = Semester;

            number = Number;
            serial = Serial;
            name = Name;
            credit = Credit;
            property = Property;
            score = Score;
            cnScore = CnScore;
            remark = Remark;
        }


        //构造函数——所有成绩
        public Course(string Number, string Serial, string Name, double Credit, string Property, double Score, string CnScore, string Remark)
        {
            Clear();

            number = Number;
            serial = Serial;
            name = Name;
            credit = Credit;
            property = Property;
            score = Score;
            cnScore = CnScore;
            remark = Remark;
        }


        //清空
        public void Clear()
        {
            number = serial = name = property = semester = remark = cnScore = "";
            credit = score = gp = 0;
            isCalc = isShow = isDone = true;
        }



        //翻译分数
        public void Update(mfAlgorithm.Class_Algorithm alg)
        {
            if (cnScore != "")
                score = alg.CNScoreToScore(cnScore);

            gp = alg.ScoreToPoint(score);
        }
    }


    public class CourseAdmin
    {
        public int n,           //课程数 
                   calcN,       //参与计算的课程数
                   showN,       //显示的课程数
                   semeN;       //学期数
        public Course[] course = new Course[501];
        public string[] semesters = new string[51]; //学期

        public double GPA;              //GPA
        public double sumCredit;        //总学分
        public double sumCreditReceive; //总得到的学分
        public double sumCreditCalc;    //参与计算的学分
        public double sumScore;         //总分
        public double aveScore;         //平均分
        public double aveScoreWei;      //加权平均分
        public double sumPoint;         //总学分绩

        public mfAlgorithm.Class_Algorithm alg;

        public bool isLazyDisplayed;        //是否懒人模式已处于显示状态
        public bool isEditDisplayed;        //是否编辑模式已处于显示状态


        //构造函数
        public CourseAdmin(mfAlgorithm.Class_Algorithm Alg = null)
        {
            n = calcN = showN = semeN = 0;

            for (int i = 0; i <= 500; i++)
                course[i] = new Course();

            if (Alg != null)
                alg = Alg;

            isLazyDisplayed = false;
            isEditDisplayed = false;
        }


        //清空
        public void Clear()
        {
            n = calcN = showN = 0;

            GPA = sumCredit = sumCreditReceive = sumScore = 0;

            for (int i = 0; i <= 500; i++)
                course[i].Clear();
        }


        //新增
        public void Add(Course c)
        {
            n++;

            course[n] = c;
        }


        //计算
        public void Calculate()
        {
            Sort();

            calcN = 0;
            showN = 0;
            sumCredit = 0;

            for (int i = 1; i <= n; i++)
            {
                sumCredit += course[i].credit;

                if (!course[i].isDone)
                {
                    course[i].isCalc = false;
                    course[i].remark = "尚无成绩";
                }

                Except(i);

                if (course[i].isShow)
                    showN++;
                else
                    continue;

                if (course[i].isCalc)
                    calcN++;
                else
                    continue;
            }

            GPA = sumCreditReceive = sumCreditCalc = sumScore = sumPoint = aveScore = aveScoreWei = 0;

            for (int i = 1; i <= n; i++)
            {
                course[i].Update(alg);

                if (!course[i].isShow || !course[i].isCalc)
                    continue;

                sumCreditCalc += course[i].credit;
                if (alg.IsPass(course[i].score))
                    sumCreditReceive += course[i].credit;
                sumScore += course[i].score >= 0 ? course[i].score : 0;
                aveScoreWei += course[i].credit * (course[i].score >= 0 ? course[i].score : 0);
                sumPoint += course[i].gp * course[i].credit;
            }

            GPA = sumPoint / sumCreditReceive;
            aveScore = sumScore / calcN;
            aveScoreWei /= sumCreditReceive;
        }


        //排序
        private void Sort()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (string.Compare(course[i].number, course[j].number) > 0)
                    {
                        Course t = course[i];

                        course[i] = course[j];
                        course[j] = t;
                    }
                }
            }
        }


        //去除例外成绩
        private void Except(int i)
        {
            if (course[i].number == "58000001")
                course[i].isCalc = false;

            if (course[i].number == "58000002")
                course[i].isCalc = false;


            if (course[i].remark == "申请缓考")
                course[i].isCalc = false;
        }


        //显示ListView
        public void DisplayListView(ref ListView lv)
        {
            for (int i = 1; i <= n; i++)
            {
                if (!course[i].isShow)
                    continue;

                ListViewItem Item = new ListViewItem(course[i].number);
                Item.SubItems.Add(course[i].name);
                Item.SubItems.Add(course[i].credit.ToString());
                Item.SubItems.Add(course[i].property);

                if (course[i].cnScore == "")
                    Item.SubItems.Add((course[i].score >= 0 ? course[i].score : 0).ToString());
                else
                    Item.SubItems.Add(course[i].cnScore);

                Item.SubItems.Add(course[i].gp.ToString());
                Item.SubItems.Add(course[i].remark);
                Item.Checked = course[i].isCalc;

                lv.Items.Add(Item);
            }
        }


        //编辑模式
        public void DisplayListViewEdit(ref ListView lv)
        {
            for (int i = 1; i <= n; i++)
            {
                if (!course[i].isShow)
                    continue;

                ListViewItem Item = new ListViewItem(course[i].number);
                Item.SubItems.Add(course[i].name);
                Item.SubItems.Add(course[i].credit.ToString());

                if (course[i].cnScore == "")
                    Item.SubItems.Add((course[i].score >= 0 ? course[i].score : 0).ToString());
                else
                    Item.SubItems.Add(course[i].cnScore);

                Item.SubItems.Add(course[i].gp.ToString());
                Item.Checked = course[i].isCalc;

                lv.Items.Add(Item);
            }
        }



        //显示学期listView
        public void DisplaySemesterListView(ref ListView lv)
        {
            lv.Items.Clear();

            semeN = 0;

            for (int i = 1; i <= n; i++)
            {
                if (!isSemesterExist(course[i].semester))
                {
                    semeN++;

                    semesters[semeN] = course[i].semester;
                }
            }

            for (int i = 1; i < semeN; i++)
            {
                for (int j = i + 1; j <= semeN; j++)
                {
                    if (string.Compare(semesters[i], semesters[j]) > 0)
                    {
                        string t = semesters[i];

                        semesters[i] = semesters[j];
                        semesters[j] = t;
                    }
                }
            }

            for (int i = 1; i <= semeN; i++)
            {
                ListViewItem Item = new ListViewItem(semesters[i]);
                Item.Checked = true;

                lv.Items.Add(Item);
            }
        }


        //判断学期是否已经存在
        public bool isSemesterExist(string semester)
        {
            for (int i = 1; i <= semeN; i++)
            {
                if (semesters[i] == semester)
                    return true;
            }

            return false;
        }
    }


    //---------------------


    public class DataCourse
    {
        public string name;
        public string number;
        public string property;

        public bool isShow;

        public DataCourse()
        {
            name = number = property = "";
            isShow = true;
        }
    }


    public class DataCourseAdmin
    {
        public string fileName;
        public DataCourse[] dataCourse = new DataCourse[3001];
        public int n;

        public string version;
        public bool isLoadSuccess;


        //构造函数
        public DataCourseAdmin(string fName)
        {
            fileName = fName;

            if (!File.Exists(fileName))
            {
                isLoadSuccess = false;
                return;
            }

            Load();

            isLoadSuccess = true;
        }


        //读取
        public void Load()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);

            n = int.Parse(sr.ReadLine());
            version = sr.ReadLine();

            for (int i = 1; i <= n; i++)
            {
                dataCourse[i] = new DataCourse();

                string s = sr.ReadLine();
                dataCourse[i].number = CutAndDel(ref s, "[", "]");
                dataCourse[i].name = CutAndDel(ref s, "[", "]");
                dataCourse[i].property = CutAndDel(ref s, "[", "]");
            }

            sr.Close();
        }


        //储存
        public void Save()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);

            version = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00");

            sw.WriteLine(n);
            sw.WriteLine(version);

            Sort();

            for (int i = 1; i <= n; i++)
            {
                sw.WriteLine("[" + dataCourse[i].number + "]" + "[" + dataCourse[i].name + "]" + "[" + dataCourse[i].property + "]");
            }

            sw.Close();
        }


        //显示
        public void Display(ref ListView lv)
        {
            lv.BeginUpdate();
            lv.Items.Clear();

            for (int i = 1; i <= n; i++)
            {
                if (!dataCourse[i].isShow)
                    continue;

                ListViewItem Item = new ListViewItem(dataCourse[i].number);
                Item.SubItems.Add(dataCourse[i].name);
                Item.SubItems.Add(dataCourse[i].property);

                lv.Items.Add(Item);
            }
            lv.EndUpdate();
        }


        //检索
        public int Search(string keyword, bool force)//force == true强匹配,false弱匹配
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                dataCourse[i].isShow = false;

                if (force)
                {
                    if (dataCourse[i].number.IndexOf(keyword) == 0 ||
                        dataCourse[i].name.IndexOf(keyword) == 0 ||
                        dataCourse[i].property.IndexOf(keyword) == 0)
                    {
                        sum++;
                        dataCourse[i].isShow = true;
                    }
                }
                else
                {
                    if (dataCourse[i].number.IndexOf(keyword) >= 0 ||
                        dataCourse[i].name.IndexOf(keyword) >= 0 ||
                        dataCourse[i].property.IndexOf(keyword) >= 0)
                    {
                        sum++;
                        dataCourse[i].isShow = true;
                    }
                }
            }

            return sum;
        }


        //重置
        public int Default(bool isShow)
        {
            for (int i = 1; i <= n; i++)
                dataCourse[i].isShow = isShow;

            return n;
        }


        //添加
        public void AddRecord(string number, string name, string property)
        {
            n++;

            dataCourse[n] = new DataCourse();

            dataCourse[n].number = number;
            dataCourse[n].name = name;
            dataCourse[n].property = property;

            dataCourse[n].isShow = true;

            Sort();
        }


        //按课程号查找
        public int Find(string number)
        {
            for (int i = 1; i <= n; i++)
            {
                if (dataCourse[i].number == number)
                    return i;
            }

            return 0;
        }


        //排序
        private void Sort()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (string.Compare(dataCourse[i].number, dataCourse[j].number) > 0)
                    {
                        DataCourse t = dataCourse[i];

                        dataCourse[i] = dataCourse[j];
                        dataCourse[j] = t;
                    }
                }
            }
        }


        //截取并删除
        private string CutAndDel(ref string str, string start, string end)
        {
            string ans;

            str = str.Substring(str.IndexOf(start) + start.Length);
            ans = str.Substring(0, str.IndexOf(end)).Trim();
            str = str.Substring(str.IndexOf(end) + end.Length);

            return ans;
        }
    }
}