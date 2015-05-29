namespace CAUService
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_URP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CourseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Select = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_UserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_FondOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Algorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Helps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_URP = new System.Windows.Forms.TabPage();
            this.listView_Semester = new System.Windows.Forms.ListView();
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar_CompletePercent = new System.Windows.Forms.ProgressBar();
            this.button_All = new System.Windows.Forms.Button();
            this.button_Each = new System.Windows.Forms.Button();
            this.button_This = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.tabControl_URP = new System.Windows.Forms.TabControl();
            this.tabPage_Lazy = new System.Windows.Forms.TabPage();
            this.listView_Lazy = new System.Windows.Forms.ListView();
            this.Number_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credit_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Property_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GradePoint_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark_LazyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.textBox_GradePoint = new System.Windows.Forms.TextBox();
            this.button_EditCourse = new System.Windows.Forms.Button();
            this.button_AddCourse = new System.Windows.Forms.Button();
            this.numericUpDown_Score = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Credit = new System.Windows.Forms.NumericUpDown();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label_GradePoint = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_Credit = new System.Windows.Forms.Label();
            this.label_CourseName = new System.Windows.Forms.Label();
            this.label_CourseNumber = new System.Windows.Forms.Label();
            this.listView_Edit = new System.Windows.Forms.ListView();
            this.Number_EditMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_EditMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credit_EditMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_EditMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gradepoint_EditMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Netgate = new System.Windows.Forms.TabPage();
            this.groupBox_State = new System.Windows.Forms.GroupBox();
            this.label_NetState = new System.Windows.Forms.Label();
            this.linkLabel_NetStateRefresh = new System.Windows.Forms.LinkLabel();
            this.groupBox_NetConfig = new System.Windows.Forms.GroupBox();
            this.button_SelfService = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.groupBox_Property = new System.Windows.Forms.GroupBox();
            this.label_Loading = new System.Windows.Forms.Label();
            this.label_FlowPercent_Used = new System.Windows.Forms.Label();
            this.label_UserNumber = new System.Windows.Forms.Label();
            this.label_MoneyLimitLeft = new System.Windows.Forms.Label();
            this.progressBar_Date = new System.Windows.Forms.ProgressBar();
            this.label_MoneyLimit = new System.Windows.Forms.Label();
            this.label_FlowUsed = new System.Windows.Forms.Label();
            this.label_LeftMoney = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_FlowMoney = new System.Windows.Forms.Label();
            this.label_FlowPercent_Left = new System.Windows.Forms.Label();
            this.label_TimeUsed = new System.Windows.Forms.Label();
            this.progressBar_Flow = new System.Windows.Forms.ProgressBar();
            this.tabPage_StdMgr = new System.Windows.Forms.TabPage();
            this.groupBox_Infomation = new System.Windows.Forms.GroupBox();
            this.linkLabel_BasicInfoRefresh = new System.Windows.Forms.LinkLabel();
            this.label_OutTime = new System.Windows.Forms.Label();
            this.label_InTime = new System.Windows.Forms.Label();
            this.label_TimeLimit = new System.Windows.Forms.Label();
            this.label_Residence = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label_Catagory = new System.Windows.Forms.Label();
            this.label_Politics = new System.Windows.Forms.Label();
            this.label_Class = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Nation = new System.Windows.Forms.Label();
            this.label_Hometown = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.groupBox_Politics = new System.Windows.Forms.GroupBox();
            this.linkLabel_UserInfo = new System.Windows.Forms.LinkLabel();
            this.timer_progressBarDisplay = new System.Windows.Forms.Timer(this.components);
            this.timer_TimeLimit = new System.Windows.Forms.Timer(this.components);
            this.tabPage_Other = new System.Windows.Forms.TabPage();
            this.groupBox_CET = new System.Windows.Forms.GroupBox();
            this.menuStrip_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_URP.SuspendLayout();
            this.tabControl_URP.SuspendLayout();
            this.tabPage_Lazy.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Credit)).BeginInit();
            this.tabPage_Netgate.SuspendLayout();
            this.groupBox_State.SuspendLayout();
            this.groupBox_NetConfig.SuspendLayout();
            this.groupBox_Property.SuspendLayout();
            this.tabPage_StdMgr.SuspendLayout();
            this.groupBox_Infomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            this.tabPage_Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_URP,
            this.toolStripMenuItem_Select,
            this.toolStripMenuItem_Help});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(884, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Restart,
            this.toolStripMenuItem_Exit});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem_File.Text = "文件(&F)";
            // 
            // toolStripMenuItem_Restart
            // 
            this.toolStripMenuItem_Restart.Name = "toolStripMenuItem_Restart";
            this.toolStripMenuItem_Restart.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_Restart.Text = "重新启动(&R)";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_Exit.Text = "退出(&X)";
            // 
            // toolStripMenuItem_URP
            // 
            this.toolStripMenuItem_URP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_CourseDatabase});
            this.toolStripMenuItem_URP.Name = "toolStripMenuItem_URP";
            this.toolStripMenuItem_URP.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem_URP.Text = "教务系统(&U)";
            // 
            // toolStripMenuItem_CourseDatabase
            // 
            this.toolStripMenuItem_CourseDatabase.Image = global::CAUService.Properties.Resources.database;
            this.toolStripMenuItem_CourseDatabase.Name = "toolStripMenuItem_CourseDatabase";
            this.toolStripMenuItem_CourseDatabase.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_CourseDatabase.Text = "课程数据库(&D)";
            this.toolStripMenuItem_CourseDatabase.Click += new System.EventHandler(this.toolStripMenuItem_CourseDatabase_Click);
            // 
            // toolStripMenuItem_Select
            // 
            this.toolStripMenuItem_Select.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_UserManage,
            this.toolStripMenuItem1,
            this.toolStripMenuItem_FondOption,
            this.toolStripMenuItem_Algorithm});
            this.toolStripMenuItem_Select.Name = "toolStripMenuItem_Select";
            this.toolStripMenuItem_Select.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem_Select.Text = "选项(&S)";
            // 
            // toolStripMenuItem_UserManage
            // 
            this.toolStripMenuItem_UserManage.Image = global::CAUService.Properties.Resources.users;
            this.toolStripMenuItem_UserManage.Name = "toolStripMenuItem_UserManage";
            this.toolStripMenuItem_UserManage.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_UserManage.Text = "用户管理(&U)";
            this.toolStripMenuItem_UserManage.Click += new System.EventHandler(this.toolStripMenuItem_UserManage_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripMenuItem_FondOption
            // 
            this.toolStripMenuItem_FondOption.Image = global::CAUService.Properties.Resources.option;
            this.toolStripMenuItem_FondOption.Name = "toolStripMenuItem_FondOption";
            this.toolStripMenuItem_FondOption.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_FondOption.Text = "偏好设置(&F)";
            this.toolStripMenuItem_FondOption.Click += new System.EventHandler(this.toolStripMenuItem_FondOption_Click);
            // 
            // toolStripMenuItem_Algorithm
            // 
            this.toolStripMenuItem_Algorithm.Name = "toolStripMenuItem_Algorithm";
            this.toolStripMenuItem_Algorithm.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_Algorithm.Text = "算法选择(&A)";
            this.toolStripMenuItem_Algorithm.Click += new System.EventHandler(this.toolStripMenuItem_Algorithm_Click);
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Update,
            this.toolStripMenuItem2,
            this.toolStripMenuItem_Helps,
            this.toolStripMenuItem_About});
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem_Help.Text = "帮助(&H)";
            // 
            // toolStripMenuItem_Update
            // 
            this.toolStripMenuItem_Update.Image = global::CAUService.Properties.Resources.update;
            this.toolStripMenuItem_Update.Name = "toolStripMenuItem_Update";
            this.toolStripMenuItem_Update.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_Update.Text = "检查更新(&U)";
            this.toolStripMenuItem_Update.Click += new System.EventHandler(this.toolStripMenuItem_Update_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripMenuItem_Helps
            // 
            this.toolStripMenuItem_Helps.Name = "toolStripMenuItem_Helps";
            this.toolStripMenuItem_Helps.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_Helps.Text = "查看帮助(&H)";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_About.Text = "关于(&A)";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_URP);
            this.tabControl_Main.Controls.Add(this.tabPage_Netgate);
            this.tabControl_Main.Controls.Add(this.tabPage_StdMgr);
            this.tabControl_Main.Controls.Add(this.tabPage_Other);
            this.tabControl_Main.Location = new System.Drawing.Point(12, 28);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(860, 422);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_URP
            // 
            this.tabPage_URP.Controls.Add(this.listView_Semester);
            this.tabPage_URP.Controls.Add(this.progressBar_CompletePercent);
            this.tabPage_URP.Controls.Add(this.button_All);
            this.tabPage_URP.Controls.Add(this.button_Each);
            this.tabPage_URP.Controls.Add(this.button_This);
            this.tabPage_URP.Controls.Add(this.listBox_Result);
            this.tabPage_URP.Controls.Add(this.tabControl_URP);
            this.tabPage_URP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_URP.Name = "tabPage_URP";
            this.tabPage_URP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_URP.Size = new System.Drawing.Size(852, 396);
            this.tabPage_URP.TabIndex = 0;
            this.tabPage_URP.Text = "教务系统";
            this.tabPage_URP.UseVisualStyleBackColor = true;
            // 
            // listView_Semester
            // 
            this.listView_Semester.CheckBoxes = true;
            this.listView_Semester.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Semester});
            this.listView_Semester.FullRowSelect = true;
            this.listView_Semester.Location = new System.Drawing.Point(638, 160);
            this.listView_Semester.Name = "listView_Semester";
            this.listView_Semester.Size = new System.Drawing.Size(208, 162);
            this.listView_Semester.TabIndex = 5;
            this.listView_Semester.UseCompatibleStateImageBehavior = false;
            this.listView_Semester.View = System.Windows.Forms.View.Details;
            this.listView_Semester.Visible = false;
            this.listView_Semester.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Semester_ItemChecked);
            // 
            // Semester
            // 
            this.Semester.Text = "学期";
            this.Semester.Width = 183;
            // 
            // progressBar_CompletePercent
            // 
            this.progressBar_CompletePercent.Location = new System.Drawing.Point(134, 369);
            this.progressBar_CompletePercent.Maximum = 10000;
            this.progressBar_CompletePercent.Name = "progressBar_CompletePercent";
            this.progressBar_CompletePercent.Size = new System.Drawing.Size(500, 4);
            this.progressBar_CompletePercent.TabIndex = 1;
            // 
            // button_All
            // 
            this.button_All.Location = new System.Drawing.Point(783, 328);
            this.button_All.Name = "button_All";
            this.button_All.Size = new System.Drawing.Size(63, 62);
            this.button_All.TabIndex = 4;
            this.button_All.Text = "所有";
            this.button_All.UseVisualStyleBackColor = true;
            this.button_All.Click += new System.EventHandler(this.button_All_Click);
            // 
            // button_Each
            // 
            this.button_Each.Location = new System.Drawing.Point(711, 328);
            this.button_Each.Name = "button_Each";
            this.button_Each.Size = new System.Drawing.Size(63, 62);
            this.button_Each.TabIndex = 3;
            this.button_Each.Text = "各学期";
            this.button_Each.UseVisualStyleBackColor = true;
            this.button_Each.Click += new System.EventHandler(this.button_Each_Click);
            // 
            // button_This
            // 
            this.button_This.Location = new System.Drawing.Point(638, 328);
            this.button_This.Name = "button_This";
            this.button_This.Size = new System.Drawing.Size(63, 62);
            this.button_This.TabIndex = 2;
            this.button_This.Text = "本学期";
            this.button_This.UseVisualStyleBackColor = true;
            this.button_This.Click += new System.EventHandler(this.button_This_Click);
            // 
            // listBox_Result
            // 
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 12;
            this.listBox_Result.Location = new System.Drawing.Point(638, 6);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(208, 316);
            this.listBox_Result.TabIndex = 1;
            this.listBox_Result.SelectedIndexChanged += new System.EventHandler(this.listBox_Result_SelectedIndexChanged);
            // 
            // tabControl_URP
            // 
            this.tabControl_URP.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_URP.Controls.Add(this.tabPage_Lazy);
            this.tabControl_URP.Controls.Add(this.tabPage_Edit);
            this.tabControl_URP.Location = new System.Drawing.Point(6, 6);
            this.tabControl_URP.Name = "tabControl_URP";
            this.tabControl_URP.SelectedIndex = 0;
            this.tabControl_URP.Size = new System.Drawing.Size(630, 384);
            this.tabControl_URP.TabIndex = 0;
            this.tabControl_URP.SelectedIndexChanged += new System.EventHandler(this.tabControl_URP_SelectedIndexChanged);
            // 
            // tabPage_Lazy
            // 
            this.tabPage_Lazy.Controls.Add(this.listView_Lazy);
            this.tabPage_Lazy.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Lazy.Name = "tabPage_Lazy";
            this.tabPage_Lazy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Lazy.Size = new System.Drawing.Size(622, 358);
            this.tabPage_Lazy.TabIndex = 0;
            this.tabPage_Lazy.Text = "懒人模式";
            this.tabPage_Lazy.UseVisualStyleBackColor = true;
            // 
            // listView_Lazy
            // 
            this.listView_Lazy.CheckBoxes = true;
            this.listView_Lazy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number_LazyMode,
            this.Name_LazyMode,
            this.Credit_LazyMode,
            this.Property_LazyMode,
            this.Score_LazyMode,
            this.GradePoint_LazyMode,
            this.Remark_LazyMode});
            this.listView_Lazy.FullRowSelect = true;
            this.listView_Lazy.GridLines = true;
            this.listView_Lazy.Location = new System.Drawing.Point(6, 6);
            this.listView_Lazy.Name = "listView_Lazy";
            this.listView_Lazy.Size = new System.Drawing.Size(610, 346);
            this.listView_Lazy.TabIndex = 0;
            this.listView_Lazy.UseCompatibleStateImageBehavior = false;
            this.listView_Lazy.View = System.Windows.Forms.View.Details;
            this.listView_Lazy.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Lazy_ItemChecked);
            // 
            // Number_LazyMode
            // 
            this.Number_LazyMode.Text = "课程号";
            this.Number_LazyMode.Width = 85;
            // 
            // Name_LazyMode
            // 
            this.Name_LazyMode.Text = "课程名";
            this.Name_LazyMode.Width = 175;
            // 
            // Credit_LazyMode
            // 
            this.Credit_LazyMode.Text = "学分";
            this.Credit_LazyMode.Width = 55;
            // 
            // Property_LazyMode
            // 
            this.Property_LazyMode.Text = "课程属性";
            // 
            // Score_LazyMode
            // 
            this.Score_LazyMode.Text = "成绩";
            this.Score_LazyMode.Width = 65;
            // 
            // GradePoint_LazyMode
            // 
            this.GradePoint_LazyMode.Text = "单科绩点";
            // 
            // Remark_LazyMode
            // 
            this.Remark_LazyMode.Text = "备注";
            this.Remark_LazyMode.Width = 75;
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Controls.Add(this.textBox_GradePoint);
            this.tabPage_Edit.Controls.Add(this.button_EditCourse);
            this.tabPage_Edit.Controls.Add(this.button_AddCourse);
            this.tabPage_Edit.Controls.Add(this.numericUpDown_Score);
            this.tabPage_Edit.Controls.Add(this.numericUpDown_Credit);
            this.tabPage_Edit.Controls.Add(this.textBox_Name);
            this.tabPage_Edit.Controls.Add(this.textBox_Number);
            this.tabPage_Edit.Controls.Add(this.label_GradePoint);
            this.tabPage_Edit.Controls.Add(this.label_Score);
            this.tabPage_Edit.Controls.Add(this.label_Credit);
            this.tabPage_Edit.Controls.Add(this.label_CourseName);
            this.tabPage_Edit.Controls.Add(this.label_CourseNumber);
            this.tabPage_Edit.Controls.Add(this.listView_Edit);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Edit.Size = new System.Drawing.Size(622, 358);
            this.tabPage_Edit.TabIndex = 1;
            this.tabPage_Edit.Text = "编辑模式";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // textBox_GradePoint
            // 
            this.textBox_GradePoint.Location = new System.Drawing.Point(459, 235);
            this.textBox_GradePoint.Name = "textBox_GradePoint";
            this.textBox_GradePoint.ReadOnly = true;
            this.textBox_GradePoint.Size = new System.Drawing.Size(157, 21);
            this.textBox_GradePoint.TabIndex = 13;
            // 
            // button_EditCourse
            // 
            this.button_EditCourse.Location = new System.Drawing.Point(533, 291);
            this.button_EditCourse.Name = "button_EditCourse";
            this.button_EditCourse.Size = new System.Drawing.Size(83, 61);
            this.button_EditCourse.TabIndex = 12;
            this.button_EditCourse.Text = "修改";
            this.button_EditCourse.UseVisualStyleBackColor = true;
            this.button_EditCourse.Click += new System.EventHandler(this.button_EditCourse_Click);
            // 
            // button_AddCourse
            // 
            this.button_AddCourse.Location = new System.Drawing.Point(440, 291);
            this.button_AddCourse.Name = "button_AddCourse";
            this.button_AddCourse.Size = new System.Drawing.Size(83, 61);
            this.button_AddCourse.TabIndex = 11;
            this.button_AddCourse.Text = "添加";
            this.button_AddCourse.UseVisualStyleBackColor = true;
            this.button_AddCourse.Click += new System.EventHandler(this.button_AddCourse_Click);
            // 
            // numericUpDown_Score
            // 
            this.numericUpDown_Score.Location = new System.Drawing.Point(459, 184);
            this.numericUpDown_Score.Maximum = new decimal(new int[] {
            710,
            0,
            0,
            0});
            this.numericUpDown_Score.Name = "numericUpDown_Score";
            this.numericUpDown_Score.Size = new System.Drawing.Size(157, 21);
            this.numericUpDown_Score.TabIndex = 9;
            this.numericUpDown_Score.ValueChanged += new System.EventHandler(this.numericUpDown_Score_ValueChanged);
            // 
            // numericUpDown_Credit
            // 
            this.numericUpDown_Credit.Location = new System.Drawing.Point(459, 133);
            this.numericUpDown_Credit.Name = "numericUpDown_Credit";
            this.numericUpDown_Credit.Size = new System.Drawing.Size(157, 21);
            this.numericUpDown_Credit.TabIndex = 8;
            // 
            // textBox_Name
            // 
            this.textBox_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_Name.Location = new System.Drawing.Point(459, 82);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(157, 21);
            this.textBox_Name.TabIndex = 7;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(459, 31);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.ReadOnly = true;
            this.textBox_Number.Size = new System.Drawing.Size(157, 21);
            this.textBox_Number.TabIndex = 6;
            // 
            // label_GradePoint
            // 
            this.label_GradePoint.AutoSize = true;
            this.label_GradePoint.Location = new System.Drawing.Point(440, 220);
            this.label_GradePoint.Name = "label_GradePoint";
            this.label_GradePoint.Size = new System.Drawing.Size(29, 12);
            this.label_GradePoint.TabIndex = 5;
            this.label_GradePoint.Text = "绩点";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(440, 169);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(29, 12);
            this.label_Score.TabIndex = 4;
            this.label_Score.Text = "得分";
            // 
            // label_Credit
            // 
            this.label_Credit.AutoSize = true;
            this.label_Credit.Location = new System.Drawing.Point(440, 118);
            this.label_Credit.Name = "label_Credit";
            this.label_Credit.Size = new System.Drawing.Size(29, 12);
            this.label_Credit.TabIndex = 3;
            this.label_Credit.Text = "学分";
            // 
            // label_CourseName
            // 
            this.label_CourseName.AutoSize = true;
            this.label_CourseName.Location = new System.Drawing.Point(440, 67);
            this.label_CourseName.Name = "label_CourseName";
            this.label_CourseName.Size = new System.Drawing.Size(41, 12);
            this.label_CourseName.TabIndex = 2;
            this.label_CourseName.Text = "课程名";
            // 
            // label_CourseNumber
            // 
            this.label_CourseNumber.AutoSize = true;
            this.label_CourseNumber.Location = new System.Drawing.Point(440, 16);
            this.label_CourseNumber.Name = "label_CourseNumber";
            this.label_CourseNumber.Size = new System.Drawing.Size(41, 12);
            this.label_CourseNumber.TabIndex = 1;
            this.label_CourseNumber.Text = "课程号";
            // 
            // listView_Edit
            // 
            this.listView_Edit.CheckBoxes = true;
            this.listView_Edit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number_EditMode,
            this.Name_EditMode,
            this.Credit_EditMode,
            this.Score_EditMode,
            this.Gradepoint_EditMode});
            this.listView_Edit.FullRowSelect = true;
            this.listView_Edit.GridLines = true;
            this.listView_Edit.Location = new System.Drawing.Point(6, 6);
            this.listView_Edit.MultiSelect = false;
            this.listView_Edit.Name = "listView_Edit";
            this.listView_Edit.Size = new System.Drawing.Size(428, 346);
            this.listView_Edit.TabIndex = 0;
            this.listView_Edit.UseCompatibleStateImageBehavior = false;
            this.listView_Edit.View = System.Windows.Forms.View.Details;
            this.listView_Edit.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Edit_ItemChecked);
            this.listView_Edit.SelectedIndexChanged += new System.EventHandler(this.listView_Edit_SelectedIndexChanged);
            // 
            // Number_EditMode
            // 
            this.Number_EditMode.Text = "课程号";
            this.Number_EditMode.Width = 85;
            // 
            // Name_EditMode
            // 
            this.Name_EditMode.Text = "课程名";
            this.Name_EditMode.Width = 100;
            // 
            // Credit_EditMode
            // 
            this.Credit_EditMode.Text = "学分";
            this.Credit_EditMode.Width = 70;
            // 
            // Score_EditMode
            // 
            this.Score_EditMode.Text = "成绩";
            this.Score_EditMode.Width = 70;
            // 
            // Gradepoint_EditMode
            // 
            this.Gradepoint_EditMode.Text = "单科绩点";
            this.Gradepoint_EditMode.Width = 70;
            // 
            // tabPage_Netgate
            // 
            this.tabPage_Netgate.Controls.Add(this.groupBox_State);
            this.tabPage_Netgate.Controls.Add(this.groupBox_NetConfig);
            this.tabPage_Netgate.Controls.Add(this.groupBox_Property);
            this.tabPage_Netgate.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Netgate.Name = "tabPage_Netgate";
            this.tabPage_Netgate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Netgate.Size = new System.Drawing.Size(852, 396);
            this.tabPage_Netgate.TabIndex = 1;
            this.tabPage_Netgate.Text = "网关管理";
            this.tabPage_Netgate.UseVisualStyleBackColor = true;
            // 
            // groupBox_State
            // 
            this.groupBox_State.Controls.Add(this.label_NetState);
            this.groupBox_State.Controls.Add(this.linkLabel_NetStateRefresh);
            this.groupBox_State.Location = new System.Drawing.Point(6, 119);
            this.groupBox_State.Name = "groupBox_State";
            this.groupBox_State.Size = new System.Drawing.Size(281, 70);
            this.groupBox_State.TabIndex = 4;
            this.groupBox_State.TabStop = false;
            this.groupBox_State.Text = "网络状态";
            // 
            // label_NetState
            // 
            this.label_NetState.AutoSize = true;
            this.label_NetState.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NetState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NetState.Location = new System.Drawing.Point(6, 28);
            this.label_NetState.Name = "label_NetState";
            this.label_NetState.Size = new System.Drawing.Size(179, 25);
            this.label_NetState.TabIndex = 1;
            this.label_NetState.Text = "正在获取网络状态...";
            this.label_NetState.TextChanged += new System.EventHandler(this.label_NetState_TextChanged);
            // 
            // linkLabel_NetStateRefresh
            // 
            this.linkLabel_NetStateRefresh.AutoSize = true;
            this.linkLabel_NetStateRefresh.Location = new System.Drawing.Point(246, 17);
            this.linkLabel_NetStateRefresh.Name = "linkLabel_NetStateRefresh";
            this.linkLabel_NetStateRefresh.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_NetStateRefresh.TabIndex = 0;
            this.linkLabel_NetStateRefresh.TabStop = true;
            this.linkLabel_NetStateRefresh.Text = "刷新";
            this.linkLabel_NetStateRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_NetStateRefresh_LinkClicked);
            // 
            // groupBox_NetConfig
            // 
            this.groupBox_NetConfig.Controls.Add(this.button_SelfService);
            this.groupBox_NetConfig.Controls.Add(this.button_Connect);
            this.groupBox_NetConfig.Controls.Add(this.button_Disconnect);
            this.groupBox_NetConfig.Location = new System.Drawing.Point(6, 6);
            this.groupBox_NetConfig.Name = "groupBox_NetConfig";
            this.groupBox_NetConfig.Size = new System.Drawing.Size(281, 107);
            this.groupBox_NetConfig.TabIndex = 3;
            this.groupBox_NetConfig.TabStop = false;
            this.groupBox_NetConfig.Text = "基本操作";
            // 
            // button_SelfService
            // 
            this.button_SelfService.Location = new System.Drawing.Point(24, 64);
            this.button_SelfService.Name = "button_SelfService";
            this.button_SelfService.Size = new System.Drawing.Size(232, 33);
            this.button_SelfService.TabIndex = 3;
            this.button_SelfService.Text = "网关自助服务系统";
            this.button_SelfService.UseVisualStyleBackColor = true;
            this.button_SelfService.Click += new System.EventHandler(this.button_SelfService_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(24, 25);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(113, 33);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "联网";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(143, 25);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(113, 33);
            this.button_Disconnect.TabIndex = 2;
            this.button_Disconnect.Text = "断网";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // groupBox_Property
            // 
            this.groupBox_Property.Controls.Add(this.label_Loading);
            this.groupBox_Property.Controls.Add(this.label_FlowPercent_Used);
            this.groupBox_Property.Controls.Add(this.label_UserNumber);
            this.groupBox_Property.Controls.Add(this.label_MoneyLimitLeft);
            this.groupBox_Property.Controls.Add(this.progressBar_Date);
            this.groupBox_Property.Controls.Add(this.label_MoneyLimit);
            this.groupBox_Property.Controls.Add(this.label_FlowUsed);
            this.groupBox_Property.Controls.Add(this.label_LeftMoney);
            this.groupBox_Property.Controls.Add(this.label_Date);
            this.groupBox_Property.Controls.Add(this.label_FlowMoney);
            this.groupBox_Property.Controls.Add(this.label_FlowPercent_Left);
            this.groupBox_Property.Controls.Add(this.label_TimeUsed);
            this.groupBox_Property.Controls.Add(this.progressBar_Flow);
            this.groupBox_Property.Location = new System.Drawing.Point(6, 195);
            this.groupBox_Property.Name = "groupBox_Property";
            this.groupBox_Property.Size = new System.Drawing.Size(281, 195);
            this.groupBox_Property.TabIndex = 0;
            this.groupBox_Property.TabStop = false;
            this.groupBox_Property.Text = "网关信息";
            // 
            // label_Loading
            // 
            this.label_Loading.AutoSize = true;
            this.label_Loading.Location = new System.Drawing.Point(81, 91);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(119, 12);
            this.label_Loading.TabIndex = 15;
            this.label_Loading.Text = "正在获取网关信息...";
            // 
            // label_FlowPercent_Used
            // 
            this.label_FlowPercent_Used.AutoSize = true;
            this.label_FlowPercent_Used.Location = new System.Drawing.Point(6, 129);
            this.label_FlowPercent_Used.Name = "label_FlowPercent_Used";
            this.label_FlowPercent_Used.Size = new System.Drawing.Size(17, 12);
            this.label_FlowPercent_Used.TabIndex = 10;
            this.label_FlowPercent_Used.Text = "x%";
            this.label_FlowPercent_Used.Visible = false;
            // 
            // label_UserNumber
            // 
            this.label_UserNumber.AutoSize = true;
            this.label_UserNumber.Location = new System.Drawing.Point(6, 17);
            this.label_UserNumber.Name = "label_UserNumber";
            this.label_UserNumber.Size = new System.Drawing.Size(65, 12);
            this.label_UserNumber.TabIndex = 1;
            this.label_UserNumber.Text = "学　　号：";
            this.label_UserNumber.Visible = false;
            // 
            // label_MoneyLimitLeft
            // 
            this.label_MoneyLimitLeft.AutoSize = true;
            this.label_MoneyLimitLeft.Location = new System.Drawing.Point(146, 174);
            this.label_MoneyLimitLeft.Name = "label_MoneyLimitLeft";
            this.label_MoneyLimitLeft.Size = new System.Drawing.Size(65, 12);
            this.label_MoneyLimitLeft.TabIndex = 14;
            this.label_MoneyLimitLeft.Text = "剩余限额：";
            this.label_MoneyLimitLeft.Visible = false;
            // 
            // progressBar_Date
            // 
            this.progressBar_Date.Location = new System.Drawing.Point(8, 113);
            this.progressBar_Date.Name = "progressBar_Date";
            this.progressBar_Date.Size = new System.Drawing.Size(266, 3);
            this.progressBar_Date.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Date.TabIndex = 8;
            this.progressBar_Date.Visible = false;
            // 
            // label_MoneyLimit
            // 
            this.label_MoneyLimit.AutoSize = true;
            this.label_MoneyLimit.Location = new System.Drawing.Point(6, 174);
            this.label_MoneyLimit.Name = "label_MoneyLimit";
            this.label_MoneyLimit.Size = new System.Drawing.Size(65, 12);
            this.label_MoneyLimit.TabIndex = 13;
            this.label_MoneyLimit.Text = "本月限额：";
            this.label_MoneyLimit.Visible = false;
            // 
            // label_FlowUsed
            // 
            this.label_FlowUsed.AutoSize = true;
            this.label_FlowUsed.Location = new System.Drawing.Point(6, 98);
            this.label_FlowUsed.Name = "label_FlowUsed";
            this.label_FlowUsed.Size = new System.Drawing.Size(65, 12);
            this.label_FlowUsed.TabIndex = 7;
            this.label_FlowUsed.Text = "已用流量：";
            this.label_FlowUsed.Visible = false;
            // 
            // label_LeftMoney
            // 
            this.label_LeftMoney.AutoSize = true;
            this.label_LeftMoney.Location = new System.Drawing.Point(6, 44);
            this.label_LeftMoney.Name = "label_LeftMoney";
            this.label_LeftMoney.Size = new System.Drawing.Size(65, 12);
            this.label_LeftMoney.TabIndex = 4;
            this.label_LeftMoney.Text = "余　　额：";
            this.label_LeftMoney.Visible = false;
            // 
            // label_Date
            // 
            this.label_Date.Location = new System.Drawing.Point(174, 98);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(100, 12);
            this.label_Date.TabIndex = 6;
            this.label_Date.Text = "xx月xx日";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label_Date.Visible = false;
            // 
            // label_FlowMoney
            // 
            this.label_FlowMoney.AutoSize = true;
            this.label_FlowMoney.Location = new System.Drawing.Point(6, 147);
            this.label_FlowMoney.Name = "label_FlowMoney";
            this.label_FlowMoney.Size = new System.Drawing.Size(65, 12);
            this.label_FlowMoney.TabIndex = 12;
            this.label_FlowMoney.Text = "流量计费：";
            this.label_FlowMoney.Visible = false;
            // 
            // label_FlowPercent_Left
            // 
            this.label_FlowPercent_Left.Location = new System.Drawing.Point(209, 129);
            this.label_FlowPercent_Left.Name = "label_FlowPercent_Left";
            this.label_FlowPercent_Left.Size = new System.Drawing.Size(65, 12);
            this.label_FlowPercent_Left.TabIndex = 11;
            this.label_FlowPercent_Left.Text = "100%";
            this.label_FlowPercent_Left.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_FlowPercent_Left.Visible = false;
            // 
            // label_TimeUsed
            // 
            this.label_TimeUsed.AutoSize = true;
            this.label_TimeUsed.Location = new System.Drawing.Point(6, 71);
            this.label_TimeUsed.Name = "label_TimeUsed";
            this.label_TimeUsed.Size = new System.Drawing.Size(65, 12);
            this.label_TimeUsed.TabIndex = 5;
            this.label_TimeUsed.Text = "已用时长：";
            this.label_TimeUsed.Visible = false;
            // 
            // progressBar_Flow
            // 
            this.progressBar_Flow.Location = new System.Drawing.Point(8, 116);
            this.progressBar_Flow.Name = "progressBar_Flow";
            this.progressBar_Flow.Size = new System.Drawing.Size(266, 10);
            this.progressBar_Flow.TabIndex = 9;
            this.progressBar_Flow.Visible = false;
            // 
            // tabPage_StdMgr
            // 
            this.tabPage_StdMgr.Controls.Add(this.groupBox_Infomation);
            this.tabPage_StdMgr.Controls.Add(this.groupBox_Politics);
            this.tabPage_StdMgr.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StdMgr.Name = "tabPage_StdMgr";
            this.tabPage_StdMgr.Size = new System.Drawing.Size(852, 396);
            this.tabPage_StdMgr.TabIndex = 2;
            this.tabPage_StdMgr.Text = "学生管理";
            this.tabPage_StdMgr.UseVisualStyleBackColor = true;
            // 
            // groupBox_Infomation
            // 
            this.groupBox_Infomation.Controls.Add(this.linkLabel_BasicInfoRefresh);
            this.groupBox_Infomation.Controls.Add(this.label_OutTime);
            this.groupBox_Infomation.Controls.Add(this.label_InTime);
            this.groupBox_Infomation.Controls.Add(this.label_TimeLimit);
            this.groupBox_Infomation.Controls.Add(this.label_Residence);
            this.groupBox_Infomation.Controls.Add(this.label_State);
            this.groupBox_Infomation.Controls.Add(this.label_Catagory);
            this.groupBox_Infomation.Controls.Add(this.label_Politics);
            this.groupBox_Infomation.Controls.Add(this.label_Class);
            this.groupBox_Infomation.Controls.Add(this.label_Birthday);
            this.groupBox_Infomation.Controls.Add(this.label_Nation);
            this.groupBox_Infomation.Controls.Add(this.label_Hometown);
            this.groupBox_Infomation.Controls.Add(this.label_Sex);
            this.groupBox_Infomation.Controls.Add(this.label_Name);
            this.groupBox_Infomation.Controls.Add(this.label_Number);
            this.groupBox_Infomation.Controls.Add(this.pictureBox_Photo);
            this.groupBox_Infomation.Location = new System.Drawing.Point(582, 3);
            this.groupBox_Infomation.Name = "groupBox_Infomation";
            this.groupBox_Infomation.Size = new System.Drawing.Size(267, 390);
            this.groupBox_Infomation.TabIndex = 1;
            this.groupBox_Infomation.TabStop = false;
            this.groupBox_Infomation.Text = "基本信息";
            // 
            // linkLabel_BasicInfoRefresh
            // 
            this.linkLabel_BasicInfoRefresh.AutoSize = true;
            this.linkLabel_BasicInfoRefresh.Location = new System.Drawing.Point(232, 371);
            this.linkLabel_BasicInfoRefresh.Name = "linkLabel_BasicInfoRefresh";
            this.linkLabel_BasicInfoRefresh.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_BasicInfoRefresh.TabIndex = 17;
            this.linkLabel_BasicInfoRefresh.TabStop = true;
            this.linkLabel_BasicInfoRefresh.Text = "刷新";
            this.linkLabel_BasicInfoRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BasicInfoRefresh_LinkClicked);
            // 
            // label_OutTime
            // 
            this.label_OutTime.AutoSize = true;
            this.label_OutTime.Location = new System.Drawing.Point(6, 371);
            this.label_OutTime.Name = "label_OutTime";
            this.label_OutTime.Size = new System.Drawing.Size(65, 12);
            this.label_OutTime.TabIndex = 16;
            this.label_OutTime.Text = "毕业时间：";
            // 
            // label_InTime
            // 
            this.label_InTime.AutoSize = true;
            this.label_InTime.Location = new System.Drawing.Point(6, 347);
            this.label_InTime.Name = "label_InTime";
            this.label_InTime.Size = new System.Drawing.Size(65, 12);
            this.label_InTime.TabIndex = 15;
            this.label_InTime.Text = "入学时间：";
            // 
            // label_TimeLimit
            // 
            this.label_TimeLimit.AutoSize = true;
            this.label_TimeLimit.Location = new System.Drawing.Point(6, 320);
            this.label_TimeLimit.Name = "label_TimeLimit";
            this.label_TimeLimit.Size = new System.Drawing.Size(65, 12);
            this.label_TimeLimit.TabIndex = 14;
            this.label_TimeLimit.Text = "学籍年限：";
            // 
            // label_Residence
            // 
            this.label_Residence.AutoSize = true;
            this.label_Residence.Location = new System.Drawing.Point(6, 212);
            this.label_Residence.Name = "label_Residence";
            this.label_Residence.Size = new System.Drawing.Size(65, 12);
            this.label_Residence.TabIndex = 13;
            this.label_Residence.Text = "户口类型：";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(6, 293);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(65, 12);
            this.label_State.TabIndex = 10;
            this.label_State.Text = "学籍状态：";
            // 
            // label_Catagory
            // 
            this.label_Catagory.AutoSize = true;
            this.label_Catagory.Location = new System.Drawing.Point(6, 266);
            this.label_Catagory.Name = "label_Catagory";
            this.label_Catagory.Size = new System.Drawing.Size(65, 12);
            this.label_Catagory.TabIndex = 9;
            this.label_Catagory.Text = "学生类型：";
            // 
            // label_Politics
            // 
            this.label_Politics.AutoSize = true;
            this.label_Politics.Location = new System.Drawing.Point(6, 239);
            this.label_Politics.Name = "label_Politics";
            this.label_Politics.Size = new System.Drawing.Size(65, 12);
            this.label_Politics.TabIndex = 8;
            this.label_Politics.Text = "政治面貌：";
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Location = new System.Drawing.Point(6, 185);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(65, 12);
            this.label_Class.TabIndex = 7;
            this.label_Class.Text = "班　　级：";
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(6, 158);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(65, 12);
            this.label_Birthday.TabIndex = 6;
            this.label_Birthday.Text = "生　　日：";
            // 
            // label_Nation
            // 
            this.label_Nation.AutoSize = true;
            this.label_Nation.Location = new System.Drawing.Point(6, 131);
            this.label_Nation.Name = "label_Nation";
            this.label_Nation.Size = new System.Drawing.Size(65, 12);
            this.label_Nation.TabIndex = 5;
            this.label_Nation.Text = "民　　族：";
            // 
            // label_Hometown
            // 
            this.label_Hometown.AutoSize = true;
            this.label_Hometown.Location = new System.Drawing.Point(6, 104);
            this.label_Hometown.Name = "label_Hometown";
            this.label_Hometown.Size = new System.Drawing.Size(65, 12);
            this.label_Hometown.TabIndex = 4;
            this.label_Hometown.Text = "籍　　贯：";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(6, 77);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(65, 12);
            this.label_Sex.TabIndex = 3;
            this.label_Sex.Text = "性　　别：";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(6, 50);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(65, 12);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "姓　　名：";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Location = new System.Drawing.Point(6, 23);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(65, 12);
            this.label_Number.TabIndex = 1;
            this.label_Number.Text = "学　　号：";
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Photo.Location = new System.Drawing.Point(141, 17);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(120, 180);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Photo.TabIndex = 0;
            this.pictureBox_Photo.TabStop = false;
            this.pictureBox_Photo.Click += new System.EventHandler(this.pictureBox_Photo_Click);
            this.pictureBox_Photo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Photo_Paint);
            // 
            // groupBox_Politics
            // 
            this.groupBox_Politics.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Politics.Name = "groupBox_Politics";
            this.groupBox_Politics.Size = new System.Drawing.Size(573, 390);
            this.groupBox_Politics.TabIndex = 0;
            this.groupBox_Politics.TabStop = false;
            this.groupBox_Politics.Text = "形势与政策";
            // 
            // linkLabel_UserInfo
            // 
            this.linkLabel_UserInfo.Location = new System.Drawing.Point(737, 25);
            this.linkLabel_UserInfo.Name = "linkLabel_UserInfo";
            this.linkLabel_UserInfo.Size = new System.Drawing.Size(131, 23);
            this.linkLabel_UserInfo.TabIndex = 6;
            this.linkLabel_UserInfo.TabStop = true;
            this.linkLabel_UserInfo.Text = "当前用户";
            this.linkLabel_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel_UserInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_UserInfo_LinkClicked);
            // 
            // timer_progressBarDisplay
            // 
            this.timer_progressBarDisplay.Tick += new System.EventHandler(this.timer_progressBarDisplay_Tick);
            // 
            // timer_TimeLimit
            // 
            this.timer_TimeLimit.Tick += new System.EventHandler(this.timer_TimeLimit_Tick);
            // 
            // tabPage_Other
            // 
            this.tabPage_Other.Controls.Add(this.groupBox_CET);
            this.tabPage_Other.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Other.Name = "tabPage_Other";
            this.tabPage_Other.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Other.Size = new System.Drawing.Size(852, 396);
            this.tabPage_Other.TabIndex = 3;
            this.tabPage_Other.Text = "其他功能";
            this.tabPage_Other.UseVisualStyleBackColor = true;
            // 
            // groupBox_CET
            // 
            this.groupBox_CET.Location = new System.Drawing.Point(6, 6);
            this.groupBox_CET.Name = "groupBox_CET";
            this.groupBox_CET.Size = new System.Drawing.Size(200, 100);
            this.groupBox_CET.TabIndex = 0;
            this.groupBox_CET.TabStop = false;
            this.groupBox_CET.Text = "CET成绩查询";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.linkLabel_UserInfo);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAU学生服务系统";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_URP.ResumeLayout(false);
            this.tabControl_URP.ResumeLayout(false);
            this.tabPage_Lazy.ResumeLayout(false);
            this.tabPage_Edit.ResumeLayout(false);
            this.tabPage_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Credit)).EndInit();
            this.tabPage_Netgate.ResumeLayout(false);
            this.groupBox_State.ResumeLayout(false);
            this.groupBox_State.PerformLayout();
            this.groupBox_NetConfig.ResumeLayout(false);
            this.groupBox_Property.ResumeLayout(false);
            this.groupBox_Property.PerformLayout();
            this.tabPage_StdMgr.ResumeLayout(false);
            this.groupBox_Infomation.ResumeLayout(false);
            this.groupBox_Infomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            this.tabPage_Other.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_URP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Select;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_URP;
        private System.Windows.Forms.TabPage tabPage_Netgate;
        private System.Windows.Forms.TabControl tabControl_URP;
        private System.Windows.Forms.TabPage tabPage_Lazy;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.ListView listView_Lazy;
        private System.Windows.Forms.ColumnHeader Number_LazyMode;
        private System.Windows.Forms.ColumnHeader Name_LazyMode;
        private System.Windows.Forms.ColumnHeader Credit_LazyMode;
        private System.Windows.Forms.ColumnHeader Property_LazyMode;
        private System.Windows.Forms.ColumnHeader Score_LazyMode;
        private System.Windows.Forms.ColumnHeader GradePoint_LazyMode;
        private System.Windows.Forms.ColumnHeader Remark_LazyMode;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.Button button_All;
        private System.Windows.Forms.Button button_Each;
        private System.Windows.Forms.Button button_This;
        private System.Windows.Forms.ProgressBar progressBar_CompletePercent;
        private System.Windows.Forms.ListView listView_Semester;
        private System.Windows.Forms.ColumnHeader Semester;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_UserManage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FondOption;
        private System.Windows.Forms.TabPage tabPage_StdMgr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Algorithm;
        private System.Windows.Forms.LinkLabel linkLabel_UserInfo;
        private System.Windows.Forms.ListView listView_Edit;
        private System.Windows.Forms.ColumnHeader Number_EditMode;
        private System.Windows.Forms.ColumnHeader Name_EditMode;
        private System.Windows.Forms.ColumnHeader Credit_EditMode;
        private System.Windows.Forms.ColumnHeader Score_EditMode;
        private System.Windows.Forms.ColumnHeader Gradepoint_EditMode;
        private System.Windows.Forms.Timer timer_progressBarDisplay;
        private System.Windows.Forms.Timer timer_TimeLimit;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label_GradePoint;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_Credit;
        private System.Windows.Forms.Label label_CourseName;
        private System.Windows.Forms.Label label_CourseNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_Score;
        private System.Windows.Forms.NumericUpDown numericUpDown_Credit;
        private System.Windows.Forms.Button button_EditCourse;
        private System.Windows.Forms.Button button_AddCourse;
        private System.Windows.Forms.TextBox textBox_GradePoint;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CourseDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Update;
        private System.Windows.Forms.GroupBox groupBox_Property;
        private System.Windows.Forms.Label label_UserNumber;
        private System.Windows.Forms.Label label_LeftMoney;
        private System.Windows.Forms.Label label_TimeUsed;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_FlowUsed;
        private System.Windows.Forms.ProgressBar progressBar_Date;
        private System.Windows.Forms.ProgressBar progressBar_Flow;
        private System.Windows.Forms.Label label_FlowPercent_Left;
        private System.Windows.Forms.Label label_FlowPercent_Used;
        private System.Windows.Forms.Label label_MoneyLimitLeft;
        private System.Windows.Forms.Label label_MoneyLimit;
        private System.Windows.Forms.Label label_FlowMoney;
        private System.Windows.Forms.Label label_Loading;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupBox_NetConfig;
        private System.Windows.Forms.Button button_SelfService;
        private System.Windows.Forms.GroupBox groupBox_State;
        private System.Windows.Forms.Label label_NetState;
        private System.Windows.Forms.LinkLabel linkLabel_NetStateRefresh;
        private System.Windows.Forms.GroupBox groupBox_Politics;
        private System.Windows.Forms.GroupBox groupBox_Infomation;
        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_Catagory;
        private System.Windows.Forms.Label label_Politics;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Nation;
        private System.Windows.Forms.Label label_Hometown;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_OutTime;
        private System.Windows.Forms.Label label_InTime;
        private System.Windows.Forms.Label label_TimeLimit;
        private System.Windows.Forms.Label label_Residence;
        private System.Windows.Forms.LinkLabel linkLabel_BasicInfoRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Helps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Restart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.TabPage tabPage_Other;
        private System.Windows.Forms.GroupBox groupBox_CET;
    }
}

