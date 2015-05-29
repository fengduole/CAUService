using System;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace CAUService
{
    public partial class Form_Main : Form
    {
        public mfUser.User nowUser = new mfUser.User(true);//当前用户

        bool isRun_listView_Lazy_ItemChecked = true;
        bool isRun_listView_Edit_ItemChecked = true;
        bool isRun_listView_Semester_ItemChecked = true;
        int flag_cours = 0;//成绩计算Web标记
        int flag_userInfo = 0;//网关管理Web标记
        int flag_BasicInfo = 0;//基本学籍信息
        int counter_Timer_CheckNetState = 0;//计数器——timer——检测联网次数
        int lastCalc = 0;//上一计算任务 1-本学期 2-各学期 3-所有
        bool isSave = false;//是否需要保存照片


        public Form_Main()
        {
            InitializeComponent();
        }

        #region 全局函数

        //窗口加载
        private void Form_Main_Load(object sender, EventArgs e)
        {
            //listView_Lazy排序
            listView_Lazy.ListViewItemSorter = new ListViewColumnSorter();
            listView_Lazy.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
            listView_Edit.ListViewItemSorter = new ListViewColumnSorter();
            listView_Edit.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);

            //保存当前程序集信息
            mfRegEdit.mfRegEdit regEdit = new mfRegEdit.mfRegEdit();
            regEdit.Save("ProgramPath", Environment.CurrentDirectory, "");
            regEdit.Save("ProgramVersion", Application.ProductVersion, "");

            if (nowUser.name != null)
                TakeEffectLoad();
        }


        //窗口显示
        private void Form_Main_Shown(object sender, EventArgs e)
        {
            if (nowUser.number == "")//无启用帐户，需设置
            {
                mfUser.UserAdmin userAdmin = new mfUser.UserAdmin();
                Form_EditUser editUser = new Form_EditUser(ref userAdmin, 3, 0);
                System.Windows.Forms.DialogResult result = editUser.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.Cancel)
                    Application.Exit();
                else
                    nowUser = new mfUser.User(userAdmin.user[1].number);
            }

            if (nowUser.name != null)
                TakeEffectShown();
        }


        //启动自动更新
        void timer_AutpUpdate_Tick(object sender, EventArgs e)
        {
            Timer timer_AutpUpdate = sender as Timer;

            timer_AutpUpdate.Stop();

            System.Diagnostics.Process.Start("Update.exe", "-hide -user " + nowUser.number);
        }


        //标签——跳转到相应功能的页面
        private void linkLabel_UserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tabControl_Main.SelectedIndex == 0)
                System.Diagnostics.Process.Start("http://202.205.91.62/loginAction.do?zjh=" + nowUser.number + "&mm=" + nowUser.pass_URP);
            else if (tabControl_Main.SelectedIndex == 1)
                System.Diagnostics.Process.Start("http://202.205.80.174/Self/LoginFromGatewayAction?DDDDD=" + nowUser.number + "&upass=" + nowUser.pass_Netgate + "&R1=0&R2=0&para=00&0MKKey=123456");
            else if (tabControl_Main.SelectedIndex == 2)
                System.Diagnostics.Process.Start("http://202.205.91.71:8080/StuManSystem/student.xhtml?option=doLogin&studentattr.stunum=" + nowUser.number + "&studentattr.stuPass=" + nowUser.pass_StdMgr);
        }


        //设置生效——load
        private void TakeEffectLoad()
        {
            //主页
            tabControl_Main.SelectedIndex = nowUser.mainPage - 1;
        }


        //设置生效——shown
        private void TakeEffectShown()
        {
            //显示当前用户学号姓名
            linkLabel_UserInfo.Text = nowUser.number + "(" + nowUser.name + ")";

            //更新最后使用时间
            nowUser.lastTime = DateTime.Now.ToString();
            nowUser.SaveToReg();

            //自动更新
            if (nowUser.isUseUpdate && nowUser.address != "")
            {
                Timer timer_AutpUpdate = new Timer();

                timer_AutpUpdate.Interval = 10000;
                timer_AutpUpdate.Tick += new EventHandler(timer_AutpUpdate_Tick);
                timer_AutpUpdate.Start();
            }

            //自动计算
            if (nowUser.pass_URP != "")
            {
                if (tabControl_Main.SelectedIndex == 0)
                {
                    if (nowUser.autoCalc == 1)
                        button_This.PerformClick();
                    else if (nowUser.autoCalc == 2)
                        button_Each.PerformClick();
                    else if (nowUser.autoCalc == 3)
                        button_All.PerformClick();
                }
            }

            //获取时限
            timer_TimeLimit.Interval = nowUser.timeLimit * 1000;

            //网络状态
            if (IsNetSuccess())
            {
                label_NetState.Text = "已连接到 Internet";
            }
            else
            {
                label_NetState.Text = "未连接到 Internet";
            }


            //网关信息
            if (nowUser.pass_Netgate != "")
            {
                WebBrowser wb_userInfo = new WebBrowser();

                wb_userInfo.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_userInfo_DocumentCompleted);
                wb_userInfo.Navigate("http://202.205.80.174/Self/LoginFromGatewayAction?DDDDD=" + nowUser.number + "&upass=" + nowUser.pass_Netgate + "&R1=0&R2=0&para=00&0MKKey=123456");
            }

            //基本信息
            if (nowUser.userInfo.isLoad)
            {
                DisplayBasicInfo();
            }
            else if (nowUser.pass_StdMgr != "")
            {
                flag_BasicInfo = 0;

                WebBrowser wb_Infomation = new WebBrowser();
                wb_Infomation.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_Infomation_DocumentCompleted);
                wb_Infomation.Navigated += new WebBrowserNavigatedEventHandler(wb_Infomation_Navigated);
                wb_Infomation.Navigate("http://202.205.91.71:8080/StuManSystem/student.xhtml?option=doLogin&studentattr.stunum=" + nowUser.number + "&studentattr.stuPass=" + nowUser.pass_StdMgr);
            }


            //基本信息——照片
            string path = nowUser.programPath + "\\User\\" + nowUser.number + "\\" + nowUser.number + "_Photo.jpg";
            if (File.Exists(path))
            {
                pictureBox_Photo.Load(path);
                pictureBox_Photo.Cursor = DefaultCursor;
            }
        }




        #region 菜单栏


        //课程数据库
        private void toolStripMenuItem_CourseDatabase_Click(object sender, EventArgs e)
        {
            Form_CourseDatabase database = new Form_CourseDatabase();
            database.ShowDialog();
        }


        //用户管理
        private void toolStripMenuItem_UserManage_Click(object sender, EventArgs e)
        {
            Form_UserManage userManage = new Form_UserManage();
            userManage.ShowDialog();
        }


        //偏好设置
        private void toolStripMenuItem_FondOption_Click(object sender, EventArgs e)
        {
            Form_FondOption fond = new Form_FondOption(ref nowUser);
            fond.ShowDialog();
        }


        //算法选择
        private void toolStripMenuItem_Algorithm_Click(object sender, EventArgs e)
        {
            Form_AlgSelect algSelect = new Form_AlgSelect(ref nowUser);
            algSelect.ShowDialog();
        }


        //检测更新
        private void toolStripMenuItem_Update_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Update.exe", "-user " + nowUser.number);
        }


        #endregion

        #endregion


        #region 教务系统

        //计算初始化
        private void InitCalc(bool IsEach)
        {
            listBox_Result.Items.Clear();
            listView_Lazy.Items.Clear();
            listView_Semester.Items.Clear();

            progressBar_CompletePercent.Value = 0;

            flag_cours = 0;

            listView_Semester.Visible = IsEach;

            if (IsEach)
                listBox_Result.Height = 150;
            else
                listBox_Result.Height = 316;
        }


        #region 懒人模式

        #region 本学期成绩

        //按钮事件——本学期成绩
        private void button_This_Click(object sender, EventArgs e)
        {
            WebBrowser wb_this = new WebBrowser();

            InitCalc(false);

            wb_this.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_this_DocumentCompleted);
            wb_this.Navigate("http://202.205.91.62/loginAction.do?zjh=" + nowUser.number + "&mm=" + nowUser.pass_URP);

            lastCalc = 1;
            timer_progressBarDisplay.Start();
            timer_TimeLimit.Start();
        }


        //浏览器事件
        void wb_this_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;

            if (browser.ReadyState != WebBrowserReadyState.Complete)
                return;

            if (flag_cours == 0)
            {
                browser.Navigate("http://202.205.91.62/bxqcjcxAction.do");
                flag_cours++;

                progressBar_CompletePercent.Value += (progressBar_CompletePercent.Maximum - progressBar_CompletePercent.Value) / 2;
            }
            else if (flag_cours == 1)
            {
                isRun_listView_Lazy_ItemChecked = false;

                nowUser.Calculate(browser.Document.Body.InnerHtml, 1);
                nowUser.DisplayListBox(ref listBox_Result);
                nowUser.DisplayListView(ref listView_Lazy, listBox_Result.SelectedIndex, false);

                isRun_listView_Lazy_ItemChecked = true;


                progressBar_CompletePercent.Value = progressBar_CompletePercent.Maximum;

                timer_progressBarDisplay.Stop();
                timer_TimeLimit.Stop();

                browser.Dispose();
            }
        }

        #endregion


        #region 各学期成绩

        //按钮事件
        private void button_Each_Click(object sender, EventArgs e)
        {
            WebBrowser wb_each = new WebBrowser();

            InitCalc(true);

            wb_each.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_each_DocumentCompleted);
            wb_each.Navigate("http://202.205.91.62/loginAction.do?zjh=" + nowUser.number + "&mm=" + nowUser.pass_URP);

            lastCalc = 2;
            timer_progressBarDisplay.Start();
            timer_TimeLimit.Start();
        }


        //浏览器事件
        void wb_each_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;

            if (browser.ReadyState != WebBrowserReadyState.Complete)
                return;

            if (flag_cours == 0)
            {
                browser.Navigate("http://202.205.91.62/gradeLnAllAction.do?type=ln&oper=qbinfo");
                flag_cours++;

                progressBar_CompletePercent.Value += (progressBar_CompletePercent.Maximum - progressBar_CompletePercent.Value) / 2;
            }
            else if (flag_cours == 1)
            {
                isRun_listView_Lazy_ItemChecked = false;
                isRun_listView_Semester_ItemChecked = false;

                nowUser.Calculate(browser.Document.Body.InnerHtml, 2);
                nowUser.DisplayListBox(ref listBox_Result);
                nowUser.DisplayListView(ref listView_Lazy, listBox_Result.SelectedIndex, false);
                nowUser.DisplaySemesterListView(ref listView_Semester);

                isRun_listView_Lazy_ItemChecked = true;
                isRun_listView_Semester_ItemChecked = true;

                progressBar_CompletePercent.Value = progressBar_CompletePercent.Maximum;

                timer_progressBarDisplay.Stop();
                timer_TimeLimit.Stop();

                browser.Dispose();
            }
        }


        //懒人模式——各学期成绩——修改计算课程
        private void listView_Semester_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!isRun_listView_Semester_ItemChecked)
                return;

            isRun_listView_Lazy_ItemChecked = false;

            SemesterListViewSyncToClass();

            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                nowUser.courseAdmin[i].alg = nowUser.algAdmin.alg[i];
                nowUser.courseAdmin[i].Calculate();
            }

            nowUser.DisplayListView(ref listView_Lazy, listBox_Result.SelectedIndex, true);
            nowUser.DisplayListBox(ref listBox_Result);

            isRun_listView_Lazy_ItemChecked = true;
        }


        //将学期ListView的变更同步到类
        private void SemesterListViewSyncToClass()
        {
            for (int i = 0; i < listView_Semester.Items.Count; i++)
            {
                nowUser.SemesterListviewSyncToClass(listView_Semester.Items[i].Text, listView_Semester.Items[i].Checked);
            }
        }

        #endregion


        #region 所有成绩

        //按钮事件
        private void button_All_Click(object sender, EventArgs e)
        {
            WebBrowser wb_all = new WebBrowser();

            InitCalc(false);

            wb_all.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_all_DocumentCompleted);
            wb_all.Navigate("http://202.205.91.62/loginAction.do?zjh=" + nowUser.number + "&mm=" + nowUser.pass_URP);

            lastCalc = 3;
            timer_progressBarDisplay.Start();
            timer_TimeLimit.Start();
        }


        //浏览器事件
        void wb_all_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;

            if (browser.ReadyState != WebBrowserReadyState.Complete)
                return;

            if (flag_cours == 0)
            {
                browser.Navigate("http://202.205.91.62/gradeLnAllAction.do?type=ln&oper=fainfo");
                flag_cours++;

                progressBar_CompletePercent.Value += (progressBar_CompletePercent.Maximum - progressBar_CompletePercent.Value) / 2;
            }
            else if (flag_cours == 1)
            {
                isRun_listView_Lazy_ItemChecked = false;

                nowUser.Calculate(browser.Document.Body.InnerHtml, 3);
                nowUser.DisplayListBox(ref listBox_Result);
                nowUser.DisplayListView(ref listView_Lazy, listBox_Result.SelectedIndex, false);

                isRun_listView_Lazy_ItemChecked = true;


                progressBar_CompletePercent.Value = progressBar_CompletePercent.Maximum;

                timer_progressBarDisplay.Stop();
                timer_TimeLimit.Stop();

                browser.Dispose();
            }
        }

        #endregion


        //懒人模式——修改计算课程
        private void listView_Lazy_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!isRun_listView_Lazy_ItemChecked)
                return;

            ListViewSyncToClass(1);

            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                nowUser.courseAdmin[i].alg = nowUser.algAdmin.alg[i];
                nowUser.courseAdmin[i].Calculate();
            }

            nowUser.DisplayListBox(ref listBox_Result);
        }

        #region Timer

        //控制progressBar显示效果
        private void timer_progressBarDisplay_Tick(object sender, EventArgs e)
        {
            if (progressBar_CompletePercent.Value + (progressBar_CompletePercent.Maximum - progressBar_CompletePercent.Value) / nowUser.timeLimit / 2 + 1 <= progressBar_CompletePercent.Maximum - 500)
                progressBar_CompletePercent.Value += (progressBar_CompletePercent.Maximum - progressBar_CompletePercent.Value) / nowUser.timeLimit / 2 + 1;
        }


        //成绩获取时限
        private void timer_TimeLimit_Tick(object sender, EventArgs e)
        {
            timer_TimeLimit.Stop();
            timer_progressBarDisplay.Stop();

            progressBar_CompletePercent.Value = progressBar_CompletePercent.Maximum;

            if (MessageBox.Show("程序未能获取成绩表单。\n\n如果您在校内，建议您重新获取一次成绩。\n如果您在校外，请在偏好设置中适当调高成绩获取时限后再试一次。\n\n若您在多次尝试后仍不能正常获取成绩，请联系Macrofuns soft。\n\n\n单击“重试”：重新获取成绩\n单击“取消”：继续等待", "获取成绩失败", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Retry)
            {
                if (lastCalc == 1)
                    button_This.PerformClick();
                if (lastCalc == 2)
                    button_Each.PerformClick();
                if (lastCalc == 3)
                    button_All.PerformClick();
            }
        }


        #endregion

        #endregion


        #region 编辑模式

        //懒人模式 <--> 编辑模式 切换
        private void tabControl_URP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_URP.SelectedIndex == 0)
            {
                button_This.Enabled = button_Each.Enabled = button_All.Enabled = true;
                progressBar_CompletePercent.Visible = true;
            }
            else if (tabControl_URP.SelectedIndex == 1)
            {
                button_This.Enabled = button_Each.Enabled = button_All.Enabled = false;
                progressBar_CompletePercent.Visible = false;
                listView_Semester.Visible = false;
                listBox_Result.Height = 316;

                isRun_listView_Edit_ItemChecked = false;
                nowUser.DisplayListViewEdit(ref listView_Edit, listBox_Result.SelectedIndex);
                isRun_listView_Edit_ItemChecked = true;
            }
        }


        //编辑模式 选择
        private void listView_Edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SelectedIndex(listView_Edit);

            if (selectedIndex == 0)
                return;

            textBox_Number.Text = nowUser.courseAdmin[1].course[selectedIndex].number;
            textBox_Name.Text = nowUser.courseAdmin[1].course[selectedIndex].name;
            numericUpDown_Credit.Value = (decimal)nowUser.courseAdmin[1].course[selectedIndex].credit;
            numericUpDown_Score.Value = (decimal)nowUser.courseAdmin[1].course[selectedIndex].score;
            textBox_GradePoint.Text = nowUser.courseAdmin[1].course[selectedIndex].gp.ToString();
        }


        //返回所选项目在class中的序号
        private int SelectedIndex(ListView lv)
        {
            string number = "";

            for (int i = 0; i < lv.Items.Count; i++)
            {
                if (lv.Items[i].Selected)
                {
                    number = lv.Items[i].Text;
                    break;
                }
            }

            for (int i = 1; i <= nowUser.courseAdmin[1].n; i++)
            {
                if (number == nowUser.courseAdmin[1].course[i].number)
                    return i;
            }

            return 0;
        }


        //编辑模式——添加
        private void button_AddCourse_Click(object sender, EventArgs e)
        {
            mfCourse.Course newCourse = new mfCourse.Course();

            //随机课程号
            string randomNumber = "New";
            Random rand = new Random();

            for (int i = 1; i <= 5; i++)
            {
                randomNumber += rand.Next(10).ToString();
            }

            newCourse.number = randomNumber;
            newCourse.name = textBox_Name.Text;
            newCourse.credit = (double)numericUpDown_Credit.Value;
            newCourse.score = (double)numericUpDown_Score.Value;

            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                nowUser.courseAdmin[i].Add(newCourse);
                nowUser.courseAdmin[i].Calculate();
            }

            nowUser.DisplayListViewEdit(ref listView_Edit, 0);
            nowUser.DisplayListBox(ref listBox_Result);
        }


        //编辑模式——修改 
        private void button_EditCourse_Click(object sender, EventArgs e)
        {
            int selectedIndex = SelectedIndex(listView_Edit);

            if (selectedIndex == 0)
                return;

            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                nowUser.courseAdmin[i].course[selectedIndex].name = textBox_Name.Text;
                nowUser.courseAdmin[i].course[selectedIndex].credit = (double)numericUpDown_Credit.Value;
                nowUser.courseAdmin[i].course[selectedIndex].score = (double)numericUpDown_Score.Value;

                nowUser.courseAdmin[i].Calculate();
            }

            nowUser.DisplayListViewEdit(ref listView_Edit, 0);
            nowUser.DisplayListBox(ref listBox_Result);
        }


        //编辑模式——修改得分->GPA变化
        private void numericUpDown_Score_ValueChanged(object sender, EventArgs e)
        {
            textBox_GradePoint.Text = nowUser.algAdmin.alg[1].ScoreToPoint((double)numericUpDown_Score.Value).ToString();
        }


        //编辑模式——修改计算课程
        private void listView_Edit_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!isRun_listView_Edit_ItemChecked)
                return;

            ListViewSyncToClass(2);

            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                nowUser.courseAdmin[i].alg = nowUser.algAdmin.alg[i];
                nowUser.courseAdmin[i].Calculate();
            }

            nowUser.DisplayListBox(ref listBox_Result);
        }

        #endregion


        //将ListView的变更同步到类
        private void ListViewSyncToClass(int mode)
        {
            if (mode == 1)
                for (int i = 0; i < listView_Lazy.Items.Count; i++)
                {
                    nowUser.ListviewSyncToClass(listView_Lazy.Items[i].Text, listView_Lazy.Items[i].Checked);
                }
            else if (mode == 2)
                for (int i = 0; i < listView_Edit.Items.Count; i++)
                {
                    nowUser.ListviewSyncToClass(listView_Edit.Items[i].Text, listView_Edit.Items[i].Checked);
                }
        }


        //listBox选择->listView 绩点变化
        private void listBox_Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_URP.SelectedIndex == 0)
            {
                isRun_listView_Lazy_ItemChecked = false;

                nowUser.DisplayListView(ref listView_Lazy, listBox_Result.SelectedIndex, false);

                isRun_listView_Lazy_ItemChecked = true;
            }
            else if (tabControl_URP.SelectedIndex == 1)
            {
                isRun_listView_Edit_ItemChecked = false;

                nowUser.DisplayListViewEdit(ref listView_Edit, listBox_Result.SelectedIndex);

                isRun_listView_Edit_ItemChecked = true;
            }
        }

        #endregion


        #region 网关管理

        //获取网关帐户信息
        void wb_userInfo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb_userInfo = sender as WebBrowser;

            if (wb_userInfo.ReadyState != WebBrowserReadyState.Complete)
                return;

            if (flag_userInfo == 0)
            {
                wb_userInfo.Navigate("http://202.205.80.174/Self/nav_getUserInfo");

                flag_userInfo++;
            }
            else if (flag_userInfo == 1)
            {
                mfText.TextFunction textFunc = new mfText.TextFunction();

                textFunc.AnalyzeNetInfo(wb_userInfo.Document.Body.InnerHtml,
                                        ref nowUser.netInfo.number,
                                        ref nowUser.netInfo.moneyLeft,
                                        ref nowUser.netInfo.timeUsed,
                                        ref nowUser.netInfo.flowUsed,
                                        ref nowUser.netInfo.flowMoney,
                                        ref nowUser.netInfo.moneyLimit,
                                        ref nowUser.netInfo.moneyLimitLeft);

                nowUser.netInfo.Update(nowUser.flowLimit);

                label_UserNumber.Text += nowUser.netInfo.number;
                label_LeftMoney.Text += nowUser.netInfo.moneyLeft + " 元";
                label_TimeUsed.Text += nowUser.netInfo.timeUsed.ToString("0.00") + " 小时";
                label_FlowUsed.Text += nowUser.netInfo.flowUsed + " MB";
                label_Date.Text = DateTime.Now.Month + "月" + DateTime.Now.Day + "日";
                progressBar_Date.Maximum = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                progressBar_Date.Value = nowUser.netInfo.value_proc_date;
                progressBar_Flow.Value = nowUser.netInfo.value_proc_flow;
                label_FlowPercent_Used.Text = nowUser.netInfo.flowUsedPercent.ToString("0.0") + "%";
                label_FlowPercent_Left.Text = nowUser.netInfo.flowLeftPercent.ToString("0.0") + "%";
                label_FlowMoney.Text += nowUser.netInfo.flowMoney.ToString("0.00") + " 元";
                label_MoneyLimit.Text += nowUser.netInfo.moneyLimit.ToString("0.00") + " 元";
                label_MoneyLimitLeft.Text += nowUser.netInfo.moneyLimitLeft.ToString("0.00") + " 元";

                label_UserNumber.Visible =
                label_LeftMoney.Visible =
                label_TimeUsed.Visible =
                label_FlowUsed.Visible =
                label_Date.Visible =
                progressBar_Date.Visible =
                progressBar_Flow.Visible =
                label_FlowPercent_Used.Visible =
                label_FlowPercent_Left.Visible =
                label_FlowMoney.Visible =
                label_MoneyLimit.Visible =
                label_MoneyLimitLeft.Visible = true;
                label_Loading.Visible = false;


                flag_userInfo++;
            }
        }


        //联网
        private void button_Connect_Click(object sender, EventArgs e)
        {
            WebBrowser wb_Connect = new WebBrowser();

            wb_Connect.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_Connect_DocumentCompleted);
            wb_Connect.Navigate("http://202.205.80.10/a11.htm");

            label_NetState.Text = "正在连接到 Internet...";

            counter_Timer_CheckNetState = 0;
            Timer timer_CheckNetState = new Timer();
            timer_CheckNetState.Interval = 500;
            timer_CheckNetState.Tick += new EventHandler(timer_CheckNetState_Tick);
            timer_CheckNetState.Start();
        }


        //timer
        void timer_CheckNetState_Tick(object sender, EventArgs e)
        {
            Timer timer_CheckNetState = sender as Timer;

            if (counter_Timer_CheckNetState >= 15)
                timer_CheckNetState.Stop();

            if (IsNetSuccess())
                label_NetState.Text = "已连接到 Internet";
            else
                label_NetState.Text = "未连接到 Internet";

            counter_Timer_CheckNetState++;
        }


        //Web事件——联网
        void wb_Connect_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb_Connect = sender as WebBrowser;

            if (wb_Connect.ReadyState != WebBrowserReadyState.Complete)
                return;

            HtmlDocument htmlDoc = wb_Connect.Document;

            HtmlElement txtName = htmlDoc.All["DDDDD"];
            HtmlElement txtPass = htmlDoc.All["upass"];
            HtmlElement Connect = htmlDoc.All["AMKKey"];

            txtName.SetAttribute("value", nowUser.number);
            txtPass.SetAttribute("value", nowUser.pass_Netgate);
            Connect.InvokeMember("click");
        }


        //断网
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            WebBrowser wb_Disconnect = new WebBrowser();

            wb_Disconnect.Navigate("http://202.205.80.10/F.htm");

            label_NetState.Text = "正在断开与 Internet 的连接...";

            counter_Timer_CheckNetState = 0;
            Timer timer_CheckNetState = new Timer();
            timer_CheckNetState.Interval = 500;
            timer_CheckNetState.Tick += new EventHandler(timer_CheckNetState_Tick);
            timer_CheckNetState.Start();
        }


        //自主服务
        private void button_SelfService_Click(object sender, EventArgs e)
        {
            string url = "http://202.205.80.174/Self/LoginFromGatewayAction?DDDDD=" + nowUser.number + "&upass=" + nowUser.pass_Netgate + "&R1=0&R2=0&para=00&0MKKey=123456";

            System.Diagnostics.Process.Start(url);
        }


        //检测网络是否连通
        private bool IsNetSuccess()
        {
            Ping ping = new Ping();

            if (ping.Send(System.Net.IPAddress.Parse("61.135.169.125"), 1000).Status == IPStatus.Success)//google
                return true;

            if (ping.Send(System.Net.IPAddress.Parse("74.125.71.94"), 1000).Status == IPStatus.Success)//baidu
                return true;

            return false;
        }


        //刷新网络状态
        private void linkLabel_NetStateRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label_NetState.Text = "正在获取网络状态...";

            if (IsNetSuccess())
            {
                label_NetState.Text = "已连接到 Internet";
            }
            else
            {
                label_NetState.Text = "未连接到 Internet";
            }
        }


        //网络状态切换颜色
        private void label_NetState_TextChanged(object sender, EventArgs e)
        {
            if (label_NetState.Text == "已连接到 Internet")
            {
                label_NetState.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else if (label_NetState.Text == "未连接到 Internet")
            {
                label_NetState.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label_NetState.ForeColor = System.Drawing.Color.Gray;
            }
        }

        #endregion



        #region 学生管理


        //web事件——获取基本信息
        void wb_Infomation_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb_Infomation = sender as WebBrowser;

            if (wb_Infomation.ReadyState != WebBrowserReadyState.Complete)
                return;

            if (flag_BasicInfo == 0)
            {
                wb_Infomation.Navigate("http://202.205.91.71:8080/StuManSystem/Student/StudentInfo_Show.jsp");

                flag_BasicInfo++;
            }
            else if (flag_BasicInfo == 1)
            {
                mfText.TextFunction textFunc = new mfText.TextFunction();

                textFunc.AnalyzeUserInfo(wb_Infomation.Document.Body.InnerHtml,
                                         ref nowUser.userInfo.number,
                                         ref nowUser.userInfo.name,
                                         ref nowUser.userInfo.sex,
                                         ref nowUser.userInfo.hometown,
                                         ref nowUser.userInfo.source,
                                         ref nowUser.userInfo.nation,
                                         ref nowUser.userInfo.birthday,
                                         ref nowUser.userInfo.residence,
                                         ref nowUser.userInfo.classes,
                                         ref nowUser.userInfo.politics,
                                         ref nowUser.userInfo.catagory,
                                         ref nowUser.userInfo.timeLimit,
                                         ref nowUser.userInfo.state,
                                         ref nowUser.userInfo.inTime,
                                         ref nowUser.userInfo.outTime,
                                         ref nowUser.userInfo.idNum);

                DisplayBasicInfo();

                if (nowUser.name != nowUser.userInfo.name)
                {
                    nowUser.name = nowUser.userInfo.name;
                    linkLabel_UserInfo.Text = nowUser.number + "(" + nowUser.name + ")";
                    nowUser.SaveToReg();
                }

                nowUser.userInfo.Save();
            }
        }


        //web事件——屏蔽脚本错误
        void wb_Infomation_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser wb_Infomation = sender as WebBrowser;

            wb_Infomation.Document.Body.InnerHtml = wb_Infomation.Document.Body.InnerHtml.Substring(wb_Infomation.Document.Body.InnerHtml.IndexOf("<FRAME id=mainFrame"));
        }

        //获取照片
        private void pictureBox_Photo_Click(object sender, EventArgs e)
        {
            if (pictureBox_Photo.Image == null)
            {
                try
                {
                    pictureBox_Photo.Load("http://202.205.91.71:8080/StuManSystem/photo/" + nowUser.number + ".jpg");
                    pictureBox_Photo.Cursor = DefaultCursor;
                    isSave = true;
                }
                catch
                {
                    pictureBox_Photo.Cursor = DefaultCursor;
                    pictureBox_Photo.Image = pictureBox_Photo.ErrorImage;
                    isSave = true;
                }
            }
        }


        //照片获取完成后保存
        private void pictureBox_Photo_Paint(object sender, PaintEventArgs e)
        {
            if (isSave)
            {
                string path = nowUser.programPath + "\\User\\" + nowUser.number + "\\" + nowUser.number + "_Photo.jpg";

                try
                {
                    pictureBox_Photo.Image.Save(path);
                    isSave = false;
                }
                catch
                {
                    MessageBox.Show("baocunchucuo");
                }
            }
        }


        //基本信息刷新
        private void linkLabel_BasicInfoRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isSave = true;
            flag_BasicInfo = 0;
            WebBrowser wb_Infomation = new WebBrowser();
            wb_Infomation.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_Infomation_DocumentCompleted);
            wb_Infomation.Navigated += new WebBrowserNavigatedEventHandler(wb_Infomation_Navigated);
            wb_Infomation.Navigate("http://202.205.91.71:8080/StuManSystem/student.xhtml?option=doLogin&studentattr.stunum=" + nowUser.number + "&studentattr.stuPass=" + nowUser.pass_StdMgr);

            try
            {
                pictureBox_Photo.Load("http://202.205.91.71:8080/StuManSystem/photo/" + nowUser.number + ".jpg");
            }
            catch
            {
                pictureBox_Photo.Image = pictureBox_Photo.ErrorImage;
            }
        }


        //显示基本信息
        private void DisplayBasicInfo()
        {
            label_Number.Text = "学　　号：" + nowUser.userInfo.number;
            label_Name.Text = "姓　　名：" + nowUser.userInfo.name;
            label_Sex.Text = "性　　别：" + nowUser.userInfo.sex;
            label_Hometown.Text = "籍　　贯：" + nowUser.userInfo.hometown;
            label_Nation.Text = "民　　族：" + nowUser.userInfo.nation;
            label_Birthday.Text = "生　　日：" + nowUser.userInfo.birthday;
            label_Class.Text = "班　　级：" + nowUser.userInfo.classes;
            label_Residence.Text = "户口类型：" + nowUser.userInfo.residence;
            label_Politics.Text = "政治面貌：" + nowUser.userInfo.politics;
            label_Catagory.Text = "学生类型：" + nowUser.userInfo.catagory;
            label_State.Text = "学籍状态：" + nowUser.userInfo.state;
            label_TimeLimit.Text = "学籍年限：" + nowUser.userInfo.timeLimit;
            label_InTime.Text = "入学时间：" + nowUser.userInfo.inTime;
            label_OutTime.Text = "毕业时间：" + nowUser.userInfo.outTime;
        }

        #endregion
    }
}