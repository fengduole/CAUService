using System;
using System.Text;
using System.IO;
using System.Drawing;

namespace mfAlgorithm
{
    public class StoP
    {
        public int left;
        public int right;
        public double point;
    }

    public class CNtoS
    {
        public string CN;
        public double score;
    }

    public class StoCN
    {
        public double score;
        public string CN;
    }


    public class Class_Algorithm
    {
        public bool isUse;
        public string fileName;
        public string name;

        public int nStoP;
        public StoP[] stop = new StoP[501];
        public double passL, passR;
        public double StoPDefault;

        public int nCNtoS;
        public CNtoS[] cntos = new CNtoS[101];
        public double CNtoSDefault;

        public int nStoCN;
        public StoCN[] stocn = new StoCN[101];
        public string StoCNDefault;

        private string filePath;


        //构造函数
        public Class_Algorithm(string FileName, bool IsUse = false)
        {
            isUse = IsUse;

            fileName = FileName;
            filePath = System.Environment.CurrentDirectory + "\\Algorithm\\" + fileName;

            Load();
        }


        //从文件读取
        private void Load()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);

            string s;

            name = sr.ReadLine();

            //分数 -> 绩点
            nStoP = int.Parse(sr.ReadLine());
            for (int i = 1; i < nStoP - 1; i++)
            {
                string temp = sr.ReadLine();

                stop[i] = new StoP();
                stop[i].left = int.Parse(CutAndDel(ref temp, "[", ","));
                stop[i].right = int.Parse(CutAndDel(ref temp, " ", "]"));
                stop[i].point = double.Parse(CutAndDel(ref temp, "[", "]"));
            }
            s = sr.ReadLine();
            passL = double.Parse(CutAndDel(ref s, "[", ","));
            passR = double.Parse(CutAndDel(ref s, " ", "]"));
            s = sr.ReadLine();
            StoPDefault = double.Parse(CutAndDel(ref s, "[", "]"));


            //中文分数 -> 数字分数
            nCNtoS = int.Parse(sr.ReadLine());
            for (int i = 1; i < nCNtoS; i++)
            {
                string temp = sr.ReadLine();

                cntos[i] = new CNtoS();
                cntos[i].CN = CutAndDel(ref temp, "[", "]");
                cntos[i].score = int.Parse(CutAndDel(ref temp, "[", "]"));
            }
            s = sr.ReadLine();
            CNtoSDefault = int.Parse(CutAndDel(ref s, "[", "]"));


            //数字分数 -> 中文分数
            nStoCN = int.Parse(sr.ReadLine());
            for (int i = 1; i < nStoCN; i++)
            {
                string temp = sr.ReadLine();

                stocn[i] = new StoCN();
                stocn[i].score = int.Parse(CutAndDel(ref temp, "[", "]"));
                stocn[i].CN = CutAndDel(ref temp, "[", "]");
            }
            s = sr.ReadLine();
            StoCNDefault = CutAndDel(ref s, "[", "]");

            sr.Close();
        }


        //分数 -> 单科绩点
        public double ScoreToPoint(double score)
        {
            for (int i = 1; i < nStoP - 1; i++)
            {
                if ((stop[i].left <= score) && (score <= stop[i].right))
                    return stop[i].point;
            }

            return StoPDefault;
        }


        //中文分数 -> 数字
        public double CNScoreToScore(string cnScore)
        {
            for (int i = 1; i < nCNtoS; i++)
            {
                if (cnScore == cntos[i].CN)
                    return cntos[i].score;
            }

            return CNtoSDefault;
        }


        //数字分数 -> 中文
        public string ScoreToCNScore(double score)
        {
            for (int i = 1; i < nStoCN; i++)
            {
                if (stocn[i].score == score)
                    return stocn[i].CN;
            }

            return StoCNDefault;
        }


        //是否及格
        public bool IsPass(double score)
        {
            if (passL <= score && score <= passR)
                return true;
            else
                return false;
        }


        //显示算法图像
        public void DisplayImage(Graphics g)
        {
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Red,2);

            g.DrawLine(pen, new Point(9, 9), new Point(9, 214));//Y轴
            g.DrawLine(pen, new Point(5, 209), new Point(214, 209));
           
            g.Dispose();
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


    public class Class_AlgorithmAdmin
    {
        public int n;
        public Class_Algorithm[] alg = new Class_Algorithm[101];
        public string regString;


        //构造函数
        public Class_AlgorithmAdmin()
        {
            n = 0;
        }


        //构造函数
        public Class_AlgorithmAdmin(bool IsReadAll)
        {
            n = 0;

            LoadFromFile(IsReadAll);
        }


        //添加算法
        public void Add(Class_Algorithm Alg)
        {
            n++;

            alg[n] = Alg;
        }



        //读取算法
        public void LoadFromFile(bool IsReadAll)
        {
            string filePath = System.Environment.CurrentDirectory + "\\Algorithm\\";
            DirectoryInfo dirInfo = new DirectoryInfo(filePath);

            if (IsReadAll)
            {
                foreach (FileSystemInfo fsi in dirInfo.GetFileSystemInfos())
                {
                    if (fsi is FileInfo)
                    {
                        n++;
                        alg[n] = new Class_Algorithm(fsi.ToString(), true);
                    }
                }

            }
            else
            {
                foreach (FileSystemInfo fsi in dirInfo.GetFileSystemInfos())
                {
                    if (fsi is FileInfo)
                    {
                        n++;
                        alg[n] = new Class_Algorithm(fsi.ToString(), regString.IndexOf(fsi.ToString()) > 0 ? true : false);
                    }
                }
            }
        }
    }
}