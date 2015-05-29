using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace mfUser
{
    public class User
    {
        public string number;       //学号
        public string name;         //姓名

        public int mainPage;        //首页
        public bool isUseUpdate;    //自动更新
        public string address;      //email地址
        public bool isUseMinimize;  //最小化到系统托盘

        public string pass_URP;     //教务系统密码
        public int autoCalc;        //自动计算
        public int timeLimit;       //获取时限
        public string alg;          //算法选择

        public string pass_Netgate; //网关密码
        public int flowLimit;       //流量上限
        public bool isAutoConnect;  //自动联网


        public string pass_StdMgr;  //网络教学密码

        public string createTime;   //创建时间
        public string lastTime;     //最后使用时间

        public string programPath = Environment.CurrentDirectory;  //程序集路径

        public mfAlgorithm.Class_AlgorithmAdmin algAdmin = new mfAlgorithm.Class_AlgorithmAdmin();
        public mfCourse.CourseAdmin[] courseAdmin = new mfCourse.CourseAdmin[101];

        public NetInfo netInfo = new NetInfo();//网关信息
        public UserInfo userInfo;//基本信息// = new UserInfo();

        //构造函数
        public User()
        {
            Clear();
        }


        //构造函数——读取用户设置
        public User(string Number)
        {
            number = Number;

            LoadFromReg();
            SetOption();
        }


        //构造函数——读取当前用户数据
        public User(bool isNowUser)
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();

            number = regedit.LoadNowUser();

            if (number == "False")
            {
                number = "";
                return;
            }

            if (regedit.LoadUserOption(number, "name") == "False")
            {
                number = "";
                return;
            }

            InitialReg();
            LoadFromReg();
            SetOption();
            SetDirectory();
            userInfo = new UserInfo(programPath,number);
        }


        //新增用户
        public User(string Number, string Name, string Pass_URP, string Pass_Netgate, string Pass_StdMgr, string CreateTime)
        {
            number = Number;
            name = Name;

            pass_URP = Pass_URP;
            pass_Netgate = Pass_Netgate;
            pass_StdMgr = Pass_StdMgr;

            createTime = lastTime = CreateTime;

            SetToDefault();

            if (pass_StdMgr != "")
                mainPage = 3;
            else if (pass_Netgate != "")
                mainPage = 2;
            else if (pass_URP != "")
                mainPage =1;

            SaveToReg();
        }


        //清空
        public void Clear()
        {
            number = pass_URP = pass_Netgate = pass_StdMgr = "";
        }


        //生成目录
        public void SetDirectory()
        {
            string path = programPath + "\\User\\" + number;

            Directory.CreateDirectory(path);
        }


        //还原默认
        public void SetToDefault()
        {
            mainPage = 1;
            isUseUpdate = false;
            address = "";
            isUseMinimize = false;

            autoCalc = 2;
            timeLimit = 15;
            alg = "[CAU.ini]";

            isAutoConnect = false;

            flowLimit = 6;
        }


        //初始化注册表
        public void InitialReg()
        {
        }


        //让设置生效
        public void SetOption()
        {
            algAdmin.regString = alg;
            algAdmin.LoadFromFile(false);//读取选定的算法

            for (int i = 1; i <= algAdmin.n; i++)
            {
                courseAdmin[i] = new mfCourse.CourseAdmin(algAdmin.alg[i]);
            }
        }


        //从注册表读取用户设置
        public void LoadFromReg()
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();

            name = regedit.LoadUserOption(number, "name");

            mainPage = int.Parse(regedit.LoadUserOption(number, "MainPage"));
            isUseUpdate = bool.Parse(regedit.LoadUserOption(number, "Update"));
            address = regedit.LoadUserOption(number, "Address");
            isUseMinimize = bool.Parse(regedit.LoadUserOption(number, "Minimize"));

            pass_URP = regedit.LoadUserOption(number, "pass_URP");
            autoCalc = int.Parse(regedit.LoadUserOption(number, "AutoCalc"));
            timeLimit = int.Parse(regedit.LoadUserOption(number, "TimeLimit"));
            alg = regedit.LoadUserOption(number, "Algorithm");

            pass_Netgate = regedit.LoadUserOption(number, "Pass_Netgate");
            flowLimit = int.Parse(regedit.LoadUserOption(number, "FlowLimit"));
            isAutoConnect = bool.Parse(regedit.LoadUserOption(number, "AutoConnect"));

            pass_StdMgr = regedit.LoadUserOption(number, "Pass_StdMgr");

            createTime = regedit.LoadUserOption(number, "CreateTime");
            lastTime = regedit.LoadUserOption(number, "LastTime");
        }


        //保存到注册表
        public void SaveToReg()
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();

            regedit.SaveUserOption(number, "Name", name);

            regedit.SaveUserOption(number, "MainPage", mainPage);
            regedit.SaveUserOption(number, "Update", isUseUpdate);
            regedit.SaveUserOption(number, "Address", address);
            regedit.SaveUserOption(number, "Minimize", isUseMinimize);

            regedit.SaveUserOption(number, "Pass_URP", pass_URP);
            regedit.SaveUserOption(number, "AutoCalc", autoCalc);
            regedit.SaveUserOption(number, "TimeLimit", timeLimit);
            regedit.SaveUserOption(number, "Algorithm", alg);

            regedit.SaveUserOption(number, "Pass_Netgate", pass_Netgate);
            regedit.SaveUserOption(number, "FlowLimit", flowLimit);
            regedit.SaveUserOption(number, "AutoConnect", isAutoConnect);

            regedit.SaveUserOption(number, "Pass_StdMgr", pass_StdMgr);

            regedit.SaveUserOption(number, "CreateTime", createTime);
            regedit.SaveUserOption(number, "LastTime", lastTime);
        }


        //删除注册表信息
        public void DeleteInReg()
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();

            regedit.Delete(number);
        }


        //计算课程信息
        public void Calculate(string html, int From)
        {
            mfText.TextFunction textFunc = new mfText.TextFunction();

            for (int i = 1; i <= algAdmin.n; i++)
            {
                if (!algAdmin.alg[i].isUse)
                    continue;

                if (From == 1)
                    courseAdmin[i] = textFunc.ThisToClass(html);
                else if (From == 2)
                    courseAdmin[i] = textFunc.EachToClass(html);
                else if (From == 3)
                    courseAdmin[i] = textFunc.AllToClass(html);

                courseAdmin[i].alg = algAdmin.alg[i];
                courseAdmin[i].Calculate();
            }
        }


        //listView_Lazy同步到类
        public void ListviewSyncToClass(string courseNumber, bool check)
        {
            for (int i = 1; i <= algAdmin.n; i++)
            {
                for (int j = 1; j <= courseAdmin[i].n; j++)
                {
                    if (courseAdmin[i].course[j].number == courseNumber)
                        courseAdmin[i].course[j].isCalc = check;
                }
            }
        }


        //listView_Semester同步到类
        public void SemesterListviewSyncToClass(string semester, bool check)
        {
            for (int i = 1; i <= algAdmin.n; i++)
            {
                for (int j = 1; j <= courseAdmin[i].n; j++)
                {
                    if (courseAdmin[i].course[j].semester == semester)
                        courseAdmin[i].course[j].isCalc = check;
                }
            }
        }


        //选中的学期
        public int SelectedSemester(int line)
        {
            if (line < 3)
                return 1;

            return (line - 3) / 5 + 1;
        }


        //显示计算结果
        public void DisplayListBox(ref ListBox lb)
        {
            lb.Items.Clear();

            lb.Items.Add("平　均　分：" + courseAdmin[1].aveScore.ToString("0.0000"));
            lb.Items.Add("加权平均分：" + courseAdmin[1].aveScoreWei.ToString("0.0000"));
            lb.Items.Add("");

            for (int i = 1; i <= algAdmin.n; i++)
            {
                if (!algAdmin.alg[i].isUse)
                    continue;

                lb.Items.Add(algAdmin.alg[i].name + "算法：");
                lb.Items.Add("已算 " + courseAdmin[i].calcN + " 科（共 " + courseAdmin[i].showN + " 科 " + courseAdmin[i].sumCredit + " 分）");
                lb.Items.Add("　　GPA：" + courseAdmin[i].GPA.ToString("0.0000"));
                lb.Items.Add("　　学分：" + courseAdmin[i].sumCreditReceive + "（应得 " + courseAdmin[i].sumCreditCalc + "）");

                lb.Items.Add("");
            }
        }


        //显示listView
        public void DisplayListView(ref ListView lv, int line, bool ForceRefresh)
        {
            int p = SelectedSemester(line);
            int selectedAlgIndex = 0;

            for (int i = 1; i <= algAdmin.n; i++)
            {
                if (algAdmin.alg[i].isUse)
                    selectedAlgIndex++;
                if (selectedAlgIndex == p)
                {
                    p = i;
                    break;
                }
            }

            if (!courseAdmin[p].isLazyDisplayed)
            {
                lv.Items.Clear();
                courseAdmin[p].DisplayListView(ref lv);

                for (int i = 1; i <= algAdmin.n; i++)
                {
                    courseAdmin[i].isLazyDisplayed = false;
                    if (i == p)
                        courseAdmin[i].isLazyDisplayed = true;
                }
            }

            if (ForceRefresh)
            {
                lv.Items.Clear();
                courseAdmin[p].DisplayListView(ref lv);

                for (int i = 1; i <= algAdmin.n; i++)
                {
                    courseAdmin[i].isLazyDisplayed = false;
                    if (i == p)
                        courseAdmin[i].isLazyDisplayed = true;
                }
            }
        }


        //显示编辑模式listView
        public void DisplayListViewEdit(ref ListView lv, int line)
        {
            int p = SelectedSemester(line);
            int selectedAlgIndex = 0;

            for (int i = 1; i <= algAdmin.n; i++)
            {
                if (algAdmin.alg[i].isUse)
                    selectedAlgIndex++;
                if (selectedAlgIndex == p)
                {
                    p = i;
                    break;
                }
            }

            selectedAlgIndex = 0;
            if (!courseAdmin[p].isEditDisplayed)
            {
                lv.Items.Clear();
                courseAdmin[p].DisplayListViewEdit(ref lv);

                for (int i = 1; i <= algAdmin.n; i++)
                {
                    courseAdmin[i].isEditDisplayed = false;
                    if (i == p)
                        courseAdmin[i].isEditDisplayed = true;
                }
            }
        }


        //显示学期ListView
        public void DisplaySemesterListView(ref ListView lv)
        {
            lv.Items.Clear();

            courseAdmin[1].semeN = 0;

            for (int i = 1; i <= courseAdmin[1].n; i++)
            {
                if (!courseAdmin[1].isSemesterExist(courseAdmin[1].course[i].semester))
                {
                    courseAdmin[1].semeN++;

                    courseAdmin[1].semesters[courseAdmin[1].semeN] = courseAdmin[1].course[i].semester;
                }
            }

            for (int i = 1; i < courseAdmin[1].semeN; i++)
            {
                for (int j = i + 1; j <= courseAdmin[1].semeN; j++)
                {
                    if (string.Compare(courseAdmin[1].semesters[i], courseAdmin[1].semesters[j]) > 0)
                    {
                        string t = courseAdmin[1].semesters[i];

                        courseAdmin[1].semesters[i] = courseAdmin[1].semesters[j];
                        courseAdmin[1].semesters[j] = t;
                    }
                }
            }

            for (int i = 1; i <= courseAdmin[1].semeN; i++)
            {
                ListViewItem Item = new ListViewItem(courseAdmin[1].semesters[i]);
                Item.Checked = true;

                lv.Items.Add(Item);
            }
        }
    }


    public class UserAdmin
    {
        public int n;
        public User[] user = new User[101];
        public User nowUser = new User();


        //构造函数
        public UserAdmin()
        {
            Clear();
        }


        //构造函数——读取用户设置
        public UserAdmin(bool isLoad)
        {
            Load();
        }


        //从注册表读取用户列表
        public void Load()
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();
            mfText.TextFunction textFunc = new mfText.TextFunction();

            n = 0;
            string userList = regedit.LoadUserList();

            while (userList != "")
            {
                string temp = textFunc.CutAndDel(ref userList, "[", "]");

                n++;
                user[n] = new User(temp);
            }

            nowUser.number = regedit.LoadNowUser();
            nowUser.LoadFromReg();
        }


        //保存到注册表
        public void Save()
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();
            mfText.TextFunction textFunc = new mfText.TextFunction();

            string userList = "";

            for (int i = 1; i <= n; i++)
            {
                user[i].SaveToReg();

                userList += "[" + user[i].number + "]";
            }

            regedit.SaveUserList(userList);

            if (n == 0)
                regedit.SaveNowUser("");
        }


        //删除用户
        public void Delete(int index)
        {
            user[index].DeleteInReg();

            for (int i = index + 1; i <= n; i++)
            {
                user[i - 1] = user[i];
            }

            n--;

            Save();
        }


        //新增用户
        public bool Add(User newUser)
        {
            if (!IsUserExist(newUser.number))
            {
                n++;

                user[n] = new User();
                user[n] = newUser;

                if (n == 1)
                {
                    mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();

                    regedit.SaveNowUser(newUser.number);
                }

                return true;
            }

            return false;
        }


        //是否帐号已存在
        public bool IsUserExist(string number)
        {
            for (int i = 1; i <= n; i++)
            {
                if (user[i].number == number)
                    return true;
            }

            return false;
        }


        //设置默认用户
        public void SetNowUser(string number)
        {
            mfRegEdit.mfRegEdit regedit = new mfRegEdit.mfRegEdit();

            nowUser.number = number;
            nowUser.LoadFromReg();

            regedit.SaveNowUser(number);
        }


        //清空用户列表
        public void Clear()
        {
            n = 0;
        }
    }


    public class NetInfo
    {
        public string number;          //学号
        public double moneyLeft;       //余额
        public double timeUsed;        //已用时长
        public double flowUsed;        //已用流量
        public double flowUsedPercent, //已用流量百分比
                      flowLeftPercent; //剩余流量百分比
        public double flowMoney;       //流量计费
        public double moneyLimit,      //本月限额
                      moneyLimitLeft;  //剩余限额       

        public int value_proc_date;
        public int value_proc_flow;

        public NetInfo()
        {
            number = "";
            moneyLeft = timeUsed = flowUsed = flowUsedPercent = flowLeftPercent = flowMoney = moneyLimit = moneyLimitLeft = 0;
        }


        //计算数据
        public void Update(int totalFlow)
        {
            timeUsed /= 60.0;

            flowUsedPercent = flowUsed * 100.0 / totalFlow / 1024;
            flowLeftPercent = 100.0 - flowUsedPercent;
            value_proc_date = DateTime.Now.Day;
            value_proc_flow = (int)(flowUsedPercent + 0.5);
        }
    }


    public class UserInfo
    {
        public string number;       //学号
        public string name;         //姓名
        public string sex;          //性别
        public string hometown;     //籍贯
        public string source;       //生源地
        public string nation;       //民族
        public string birthday;     //生日
        public string residence;    //户口
        public string classes;      //班级
        public string politics;     //政治面貌
        public string catagory;     //学生类别
        public string timeLimit;    //入学年限
        public string state;        //状态
        public string inTime;       //入学时间
        public string outTime;      //毕业时间
        public string idNum;        //身份证号

        public bool isLoad;         //是否
        public string fileName;     //文件名

        public UserInfo(string programPath, string number)
        {
            fileName = programPath + "\\User\\" + number + "\\" + number + "_BasicInfo.db";

            if (File.Exists(fileName))
            {
                Load();
                isLoad = true;
            }
        }

        public void Save()
        {          
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);

            sw.WriteLine(number);
            sw.WriteLine(name);
            sw.WriteLine(sex);
            sw.WriteLine(hometown);
            sw.WriteLine(source);
            sw.WriteLine(nation);
            sw.WriteLine(birthday);
            sw.WriteLine(residence);
            sw.WriteLine(classes);
            sw.WriteLine(politics);
            sw.WriteLine(catagory);
            sw.WriteLine(timeLimit);
            sw.WriteLine(state);
            sw.WriteLine(inTime);
            sw.WriteLine(outTime);
            sw.WriteLine(idNum);

            sw.Close();
        }


        public void Load()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);

            number = sr.ReadLine();
            name = sr.ReadLine();
            sex = sr.ReadLine();
            hometown = sr.ReadLine();
            source = sr.ReadLine();
            nation = sr.ReadLine();
            birthday = sr.ReadLine();
            residence = sr.ReadLine();
            classes = sr.ReadLine();
            politics = sr.ReadLine();
            catagory = sr.ReadLine();
            timeLimit = sr.ReadLine();
            state = sr.ReadLine();
            inTime = sr.ReadLine();
            outTime = sr.ReadLine();
            idNum = sr.ReadLine();

            sr.Close();
        }
    }
}