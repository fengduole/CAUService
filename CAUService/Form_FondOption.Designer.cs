namespace CAUService
{
    partial class Form_FondOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FondOption));
            this.tabControl_FondOption = new System.Windows.Forms.TabControl();
            this.tabPage_Envi = new System.Windows.Forms.TabPage();
            this.groupBox_Background = new System.Windows.Forms.GroupBox();
            this.label_Tips_Background = new System.Windows.Forms.Label();
            this.checkBox_Background_Minimize = new System.Windows.Forms.CheckBox();
            this.groupBox_AutoUpdate = new System.Windows.Forms.GroupBox();
            this.label_Tips_AutpUpdate = new System.Windows.Forms.Label();
            this.textBox_UpdateAddress = new System.Windows.Forms.TextBox();
            this.label_Update_Email = new System.Windows.Forms.Label();
            this.radioButton_Update_Off = new System.Windows.Forms.RadioButton();
            this.radioButton_Update_On = new System.Windows.Forms.RadioButton();
            this.groupBox_MainPage = new System.Windows.Forms.GroupBox();
            this.label_Tips_MainPage = new System.Windows.Forms.Label();
            this.radioButton_MainPage_StdMgr = new System.Windows.Forms.RadioButton();
            this.radioButton_MainPage_Netgate = new System.Windows.Forms.RadioButton();
            this.radioButton_MainPage_URP = new System.Windows.Forms.RadioButton();
            this.tabPage_URP = new System.Windows.Forms.TabPage();
            this.groupBox_Algorithm = new System.Windows.Forms.GroupBox();
            this.label_Tips_Algorithm = new System.Windows.Forms.Label();
            this.button_Algorithm = new System.Windows.Forms.Button();
            this.groupBox_TimeLimit = new System.Windows.Forms.GroupBox();
            this.label_Tips_TimeLimit = new System.Windows.Forms.Label();
            this.label_TimeLimit_Second = new System.Windows.Forms.Label();
            this.numericUpDown_TimeLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBox_AutoCalc = new System.Windows.Forms.GroupBox();
            this.label_Tips_AutoCalc = new System.Windows.Forms.Label();
            this.radioButton_AutoCalc_Off = new System.Windows.Forms.RadioButton();
            this.radioButton_AutoCalc_All = new System.Windows.Forms.RadioButton();
            this.radioButton_AutoCalc_Each = new System.Windows.Forms.RadioButton();
            this.radioButton_AutoCalc_This = new System.Windows.Forms.RadioButton();
            this.tabPage_Netgate = new System.Windows.Forms.TabPage();
            this.groupBox_AutoConnect = new System.Windows.Forms.GroupBox();
            this.label_Tips_AutoConnect = new System.Windows.Forms.Label();
            this.radioButton_AutoConnect_Off = new System.Windows.Forms.RadioButton();
            this.radioButton_AutoConnect_On = new System.Windows.Forms.RadioButton();
            this.groupBox_FlowLimit = new System.Windows.Forms.GroupBox();
            this.label_Tips_FlowLimit = new System.Windows.Forms.Label();
            this.label_FlowLimit_GB = new System.Windows.Forms.Label();
            this.numericUpDown_FlowLimit = new System.Windows.Forms.NumericUpDown();
            this.tabPage_StdMgr = new System.Windows.Forms.TabPage();
            this.label_UserInfo = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_CacheMgr = new System.Windows.Forms.GroupBox();
            this.button_DelNow = new System.Windows.Forms.Button();
            this.button_DelAll = new System.Windows.Forms.Button();
            this.label_CacheMgr = new System.Windows.Forms.Label();
            this.tabControl_FondOption.SuspendLayout();
            this.tabPage_Envi.SuspendLayout();
            this.groupBox_Background.SuspendLayout();
            this.groupBox_AutoUpdate.SuspendLayout();
            this.groupBox_MainPage.SuspendLayout();
            this.tabPage_URP.SuspendLayout();
            this.groupBox_Algorithm.SuspendLayout();
            this.groupBox_TimeLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeLimit)).BeginInit();
            this.groupBox_AutoCalc.SuspendLayout();
            this.tabPage_Netgate.SuspendLayout();
            this.groupBox_AutoConnect.SuspendLayout();
            this.groupBox_FlowLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FlowLimit)).BeginInit();
            this.tabPage_StdMgr.SuspendLayout();
            this.groupBox_CacheMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_FondOption
            // 
            this.tabControl_FondOption.Controls.Add(this.tabPage_Envi);
            this.tabControl_FondOption.Controls.Add(this.tabPage_URP);
            this.tabControl_FondOption.Controls.Add(this.tabPage_Netgate);
            this.tabControl_FondOption.Controls.Add(this.tabPage_StdMgr);
            this.tabControl_FondOption.Location = new System.Drawing.Point(12, 41);
            this.tabControl_FondOption.Name = "tabControl_FondOption";
            this.tabControl_FondOption.SelectedIndex = 0;
            this.tabControl_FondOption.Size = new System.Drawing.Size(254, 380);
            this.tabControl_FondOption.TabIndex = 0;
            // 
            // tabPage_Envi
            // 
            this.tabPage_Envi.Controls.Add(this.groupBox_Background);
            this.tabPage_Envi.Controls.Add(this.groupBox_AutoUpdate);
            this.tabPage_Envi.Controls.Add(this.groupBox_MainPage);
            this.tabPage_Envi.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Envi.Name = "tabPage_Envi";
            this.tabPage_Envi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Envi.Size = new System.Drawing.Size(246, 354);
            this.tabPage_Envi.TabIndex = 0;
            this.tabPage_Envi.Text = "环境设置";
            this.tabPage_Envi.UseVisualStyleBackColor = true;
            // 
            // groupBox_Background
            // 
            this.groupBox_Background.Controls.Add(this.label_Tips_Background);
            this.groupBox_Background.Controls.Add(this.checkBox_Background_Minimize);
            this.groupBox_Background.Location = new System.Drawing.Point(6, 252);
            this.groupBox_Background.Name = "groupBox_Background";
            this.groupBox_Background.Size = new System.Drawing.Size(234, 89);
            this.groupBox_Background.TabIndex = 2;
            this.groupBox_Background.TabStop = false;
            this.groupBox_Background.Text = "后台管理";
            // 
            // label_Tips_Background
            // 
            this.label_Tips_Background.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_Background.Location = new System.Drawing.Point(6, 48);
            this.label_Tips_Background.Name = "label_Tips_Background";
            this.label_Tips_Background.Size = new System.Drawing.Size(222, 38);
            this.label_Tips_Background.TabIndex = 1;
            this.label_Tips_Background.Text = "Tips:若启用该功能，当您最小化程序时，它将隐藏至您的系统托盘，方便下次打开。";
            // 
            // checkBox_Background_Minimize
            // 
            this.checkBox_Background_Minimize.AutoSize = true;
            this.checkBox_Background_Minimize.Location = new System.Drawing.Point(19, 20);
            this.checkBox_Background_Minimize.Name = "checkBox_Background_Minimize";
            this.checkBox_Background_Minimize.Size = new System.Drawing.Size(132, 16);
            this.checkBox_Background_Minimize.TabIndex = 0;
            this.checkBox_Background_Minimize.Text = "最小化时至系统托盘";
            this.checkBox_Background_Minimize.UseVisualStyleBackColor = true;
            // 
            // groupBox_AutoUpdate
            // 
            this.groupBox_AutoUpdate.Controls.Add(this.label_Tips_AutpUpdate);
            this.groupBox_AutoUpdate.Controls.Add(this.textBox_UpdateAddress);
            this.groupBox_AutoUpdate.Controls.Add(this.label_Update_Email);
            this.groupBox_AutoUpdate.Controls.Add(this.radioButton_Update_Off);
            this.groupBox_AutoUpdate.Controls.Add(this.radioButton_Update_On);
            this.groupBox_AutoUpdate.Location = new System.Drawing.Point(6, 115);
            this.groupBox_AutoUpdate.Name = "groupBox_AutoUpdate";
            this.groupBox_AutoUpdate.Size = new System.Drawing.Size(234, 131);
            this.groupBox_AutoUpdate.TabIndex = 1;
            this.groupBox_AutoUpdate.TabStop = false;
            this.groupBox_AutoUpdate.Text = "自动更新";
            // 
            // label_Tips_AutpUpdate
            // 
            this.label_Tips_AutpUpdate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_AutpUpdate.Location = new System.Drawing.Point(6, 76);
            this.label_Tips_AutpUpdate.Name = "label_Tips_AutpUpdate";
            this.label_Tips_AutpUpdate.Size = new System.Drawing.Size(222, 48);
            this.label_Tips_AutpUpdate.TabIndex = 4;
            this.label_Tips_AutpUpdate.Text = "Tips:当程序检测到有更新包时，更新将以邮件方式推送至您的电子邮箱，若禁用此功能，您将不会收到更新推送。(建议开启)";
            // 
            // textBox_UpdateAddress
            // 
            this.textBox_UpdateAddress.Location = new System.Drawing.Point(53, 45);
            this.textBox_UpdateAddress.Name = "textBox_UpdateAddress";
            this.textBox_UpdateAddress.Size = new System.Drawing.Size(120, 21);
            this.textBox_UpdateAddress.TabIndex = 3;
            // 
            // label_Update_Email
            // 
            this.label_Update_Email.AutoSize = true;
            this.label_Update_Email.Location = new System.Drawing.Point(6, 48);
            this.label_Update_Email.Name = "label_Update_Email";
            this.label_Update_Email.Size = new System.Drawing.Size(41, 12);
            this.label_Update_Email.TabIndex = 2;
            this.label_Update_Email.Text = "Email:";
            // 
            // radioButton_Update_Off
            // 
            this.radioButton_Update_Off.AutoSize = true;
            this.radioButton_Update_Off.Location = new System.Drawing.Point(126, 20);
            this.radioButton_Update_Off.Name = "radioButton_Update_Off";
            this.radioButton_Update_Off.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Update_Off.TabIndex = 1;
            this.radioButton_Update_Off.TabStop = true;
            this.radioButton_Update_Off.Text = "禁用";
            this.radioButton_Update_Off.UseVisualStyleBackColor = true;
            // 
            // radioButton_Update_On
            // 
            this.radioButton_Update_On.AutoSize = true;
            this.radioButton_Update_On.Location = new System.Drawing.Point(19, 20);
            this.radioButton_Update_On.Name = "radioButton_Update_On";
            this.radioButton_Update_On.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Update_On.TabIndex = 0;
            this.radioButton_Update_On.TabStop = true;
            this.radioButton_Update_On.Text = "启用";
            this.radioButton_Update_On.UseVisualStyleBackColor = true;
            this.radioButton_Update_On.CheckedChanged += new System.EventHandler(this.radioButton_Update_On_CheckedChanged);
            // 
            // groupBox_MainPage
            // 
            this.groupBox_MainPage.Controls.Add(this.label_Tips_MainPage);
            this.groupBox_MainPage.Controls.Add(this.radioButton_MainPage_StdMgr);
            this.groupBox_MainPage.Controls.Add(this.radioButton_MainPage_Netgate);
            this.groupBox_MainPage.Controls.Add(this.radioButton_MainPage_URP);
            this.groupBox_MainPage.Location = new System.Drawing.Point(6, 6);
            this.groupBox_MainPage.Name = "groupBox_MainPage";
            this.groupBox_MainPage.Size = new System.Drawing.Size(234, 103);
            this.groupBox_MainPage.TabIndex = 0;
            this.groupBox_MainPage.TabStop = false;
            this.groupBox_MainPage.Text = "首页设定";
            // 
            // label_Tips_MainPage
            // 
            this.label_Tips_MainPage.AutoSize = true;
            this.label_Tips_MainPage.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_MainPage.Location = new System.Drawing.Point(6, 80);
            this.label_Tips_MainPage.Name = "label_Tips_MainPage";
            this.label_Tips_MainPage.Size = new System.Drawing.Size(191, 12);
            this.label_Tips_MainPage.TabIndex = 3;
            this.label_Tips_MainPage.Text = "Tips:程序启动初始页面在这里设置";
            // 
            // radioButton_MainPage_StdMgr
            // 
            this.radioButton_MainPage_StdMgr.AutoSize = true;
            this.radioButton_MainPage_StdMgr.Location = new System.Drawing.Point(19, 52);
            this.radioButton_MainPage_StdMgr.Name = "radioButton_MainPage_StdMgr";
            this.radioButton_MainPage_StdMgr.Size = new System.Drawing.Size(71, 16);
            this.radioButton_MainPage_StdMgr.TabIndex = 2;
            this.radioButton_MainPage_StdMgr.TabStop = true;
            this.radioButton_MainPage_StdMgr.Text = "学生管理";
            this.radioButton_MainPage_StdMgr.UseVisualStyleBackColor = true;
            // 
            // radioButton_MainPage_Netgate
            // 
            this.radioButton_MainPage_Netgate.AutoSize = true;
            this.radioButton_MainPage_Netgate.Location = new System.Drawing.Point(126, 20);
            this.radioButton_MainPage_Netgate.Name = "radioButton_MainPage_Netgate";
            this.radioButton_MainPage_Netgate.Size = new System.Drawing.Size(71, 16);
            this.radioButton_MainPage_Netgate.TabIndex = 1;
            this.radioButton_MainPage_Netgate.TabStop = true;
            this.radioButton_MainPage_Netgate.Text = "网关管理";
            this.radioButton_MainPage_Netgate.UseVisualStyleBackColor = true;
            // 
            // radioButton_MainPage_URP
            // 
            this.radioButton_MainPage_URP.AutoSize = true;
            this.radioButton_MainPage_URP.Location = new System.Drawing.Point(19, 20);
            this.radioButton_MainPage_URP.Name = "radioButton_MainPage_URP";
            this.radioButton_MainPage_URP.Size = new System.Drawing.Size(71, 16);
            this.radioButton_MainPage_URP.TabIndex = 0;
            this.radioButton_MainPage_URP.TabStop = true;
            this.radioButton_MainPage_URP.Text = "教务系统";
            this.radioButton_MainPage_URP.UseVisualStyleBackColor = true;
            // 
            // tabPage_URP
            // 
            this.tabPage_URP.Controls.Add(this.groupBox_Algorithm);
            this.tabPage_URP.Controls.Add(this.groupBox_TimeLimit);
            this.tabPage_URP.Controls.Add(this.groupBox_AutoCalc);
            this.tabPage_URP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_URP.Name = "tabPage_URP";
            this.tabPage_URP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_URP.Size = new System.Drawing.Size(246, 354);
            this.tabPage_URP.TabIndex = 1;
            this.tabPage_URP.Text = "教务系统";
            this.tabPage_URP.UseVisualStyleBackColor = true;
            // 
            // groupBox_Algorithm
            // 
            this.groupBox_Algorithm.Controls.Add(this.label_Tips_Algorithm);
            this.groupBox_Algorithm.Controls.Add(this.button_Algorithm);
            this.groupBox_Algorithm.Location = new System.Drawing.Point(6, 232);
            this.groupBox_Algorithm.Name = "groupBox_Algorithm";
            this.groupBox_Algorithm.Size = new System.Drawing.Size(234, 116);
            this.groupBox_Algorithm.TabIndex = 2;
            this.groupBox_Algorithm.TabStop = false;
            this.groupBox_Algorithm.Text = "算法选择";
            // 
            // label_Tips_Algorithm
            // 
            this.label_Tips_Algorithm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_Algorithm.Location = new System.Drawing.Point(8, 70);
            this.label_Tips_Algorithm.Name = "label_Tips_Algorithm";
            this.label_Tips_Algorithm.Size = new System.Drawing.Size(220, 40);
            this.label_Tips_Algorithm.TabIndex = 1;
            this.label_Tips_Algorithm.Text = "Tips:程序为您提供了多种成绩计算算法，以满足您不同的需求，您可以在这里管理它们。";
            // 
            // button_Algorithm
            // 
            this.button_Algorithm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Algorithm.Location = new System.Drawing.Point(55, 20);
            this.button_Algorithm.Name = "button_Algorithm";
            this.button_Algorithm.Size = new System.Drawing.Size(124, 43);
            this.button_Algorithm.TabIndex = 0;
            this.button_Algorithm.Text = "算法选择";
            this.button_Algorithm.UseVisualStyleBackColor = true;
            this.button_Algorithm.Click += new System.EventHandler(this.button_Algorithm_Click);
            // 
            // groupBox_TimeLimit
            // 
            this.groupBox_TimeLimit.Controls.Add(this.label_Tips_TimeLimit);
            this.groupBox_TimeLimit.Controls.Add(this.label_TimeLimit_Second);
            this.groupBox_TimeLimit.Controls.Add(this.numericUpDown_TimeLimit);
            this.groupBox_TimeLimit.Location = new System.Drawing.Point(6, 132);
            this.groupBox_TimeLimit.Name = "groupBox_TimeLimit";
            this.groupBox_TimeLimit.Size = new System.Drawing.Size(234, 94);
            this.groupBox_TimeLimit.TabIndex = 1;
            this.groupBox_TimeLimit.TabStop = false;
            this.groupBox_TimeLimit.Text = "获取时限";
            // 
            // label_Tips_TimeLimit
            // 
            this.label_Tips_TimeLimit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_TimeLimit.Location = new System.Drawing.Point(8, 49);
            this.label_Tips_TimeLimit.Name = "label_Tips_TimeLimit";
            this.label_Tips_TimeLimit.Size = new System.Drawing.Size(226, 40);
            this.label_Tips_TimeLimit.TabIndex = 2;
            this.label_Tips_TimeLimit.Text = "Tips:为程序设置一个教务系统访问时限，超时将自动停止访问。(校内用户建议5秒)";
            // 
            // label_TimeLimit_Second
            // 
            this.label_TimeLimit_Second.AutoSize = true;
            this.label_TimeLimit_Second.Location = new System.Drawing.Point(168, 22);
            this.label_TimeLimit_Second.Name = "label_TimeLimit_Second";
            this.label_TimeLimit_Second.Size = new System.Drawing.Size(17, 12);
            this.label_TimeLimit_Second.TabIndex = 1;
            this.label_TimeLimit_Second.Text = "秒";
            // 
            // numericUpDown_TimeLimit
            // 
            this.numericUpDown_TimeLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_TimeLimit.Location = new System.Drawing.Point(19, 20);
            this.numericUpDown_TimeLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_TimeLimit.Name = "numericUpDown_TimeLimit";
            this.numericUpDown_TimeLimit.Size = new System.Drawing.Size(143, 21);
            this.numericUpDown_TimeLimit.TabIndex = 0;
            // 
            // groupBox_AutoCalc
            // 
            this.groupBox_AutoCalc.Controls.Add(this.label_Tips_AutoCalc);
            this.groupBox_AutoCalc.Controls.Add(this.radioButton_AutoCalc_Off);
            this.groupBox_AutoCalc.Controls.Add(this.radioButton_AutoCalc_All);
            this.groupBox_AutoCalc.Controls.Add(this.radioButton_AutoCalc_Each);
            this.groupBox_AutoCalc.Controls.Add(this.radioButton_AutoCalc_This);
            this.groupBox_AutoCalc.Location = new System.Drawing.Point(6, 6);
            this.groupBox_AutoCalc.Name = "groupBox_AutoCalc";
            this.groupBox_AutoCalc.Size = new System.Drawing.Size(234, 120);
            this.groupBox_AutoCalc.TabIndex = 0;
            this.groupBox_AutoCalc.TabStop = false;
            this.groupBox_AutoCalc.Text = "自动计算";
            // 
            // label_Tips_AutoCalc
            // 
            this.label_Tips_AutoCalc.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_AutoCalc.Location = new System.Drawing.Point(8, 86);
            this.label_Tips_AutoCalc.Name = "label_Tips_AutoCalc";
            this.label_Tips_AutoCalc.Size = new System.Drawing.Size(226, 28);
            this.label_Tips_AutoCalc.TabIndex = 4;
            this.label_Tips_AutoCalc.Text = "Tips:当您的首页设定为\"教务系统\"时，您将可以设定成绩自动计算方式。";
            // 
            // radioButton_AutoCalc_Off
            // 
            this.radioButton_AutoCalc_Off.AutoSize = true;
            this.radioButton_AutoCalc_Off.Location = new System.Drawing.Point(126, 52);
            this.radioButton_AutoCalc_Off.Name = "radioButton_AutoCalc_Off";
            this.radioButton_AutoCalc_Off.Size = new System.Drawing.Size(83, 16);
            this.radioButton_AutoCalc_Off.TabIndex = 3;
            this.radioButton_AutoCalc_Off.TabStop = true;
            this.radioButton_AutoCalc_Off.Text = "禁用该功能";
            this.radioButton_AutoCalc_Off.UseVisualStyleBackColor = true;
            // 
            // radioButton_AutoCalc_All
            // 
            this.radioButton_AutoCalc_All.AutoSize = true;
            this.radioButton_AutoCalc_All.Location = new System.Drawing.Point(19, 52);
            this.radioButton_AutoCalc_All.Name = "radioButton_AutoCalc_All";
            this.radioButton_AutoCalc_All.Size = new System.Drawing.Size(71, 16);
            this.radioButton_AutoCalc_All.TabIndex = 2;
            this.radioButton_AutoCalc_All.TabStop = true;
            this.radioButton_AutoCalc_All.Text = "所有成绩";
            this.radioButton_AutoCalc_All.UseVisualStyleBackColor = true;
            // 
            // radioButton_AutoCalc_Each
            // 
            this.radioButton_AutoCalc_Each.AutoSize = true;
            this.radioButton_AutoCalc_Each.Location = new System.Drawing.Point(126, 20);
            this.radioButton_AutoCalc_Each.Name = "radioButton_AutoCalc_Each";
            this.radioButton_AutoCalc_Each.Size = new System.Drawing.Size(83, 16);
            this.radioButton_AutoCalc_Each.TabIndex = 1;
            this.radioButton_AutoCalc_Each.TabStop = true;
            this.radioButton_AutoCalc_Each.Text = "各学期成绩";
            this.radioButton_AutoCalc_Each.UseVisualStyleBackColor = true;
            // 
            // radioButton_AutoCalc_This
            // 
            this.radioButton_AutoCalc_This.AutoSize = true;
            this.radioButton_AutoCalc_This.Location = new System.Drawing.Point(19, 20);
            this.radioButton_AutoCalc_This.Name = "radioButton_AutoCalc_This";
            this.radioButton_AutoCalc_This.Size = new System.Drawing.Size(83, 16);
            this.radioButton_AutoCalc_This.TabIndex = 0;
            this.radioButton_AutoCalc_This.TabStop = true;
            this.radioButton_AutoCalc_This.Text = "本学期成绩";
            this.radioButton_AutoCalc_This.UseVisualStyleBackColor = true;
            // 
            // tabPage_Netgate
            // 
            this.tabPage_Netgate.Controls.Add(this.groupBox_AutoConnect);
            this.tabPage_Netgate.Controls.Add(this.groupBox_FlowLimit);
            this.tabPage_Netgate.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Netgate.Name = "tabPage_Netgate";
            this.tabPage_Netgate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Netgate.Size = new System.Drawing.Size(246, 354);
            this.tabPage_Netgate.TabIndex = 2;
            this.tabPage_Netgate.Text = "网关管理";
            this.tabPage_Netgate.UseVisualStyleBackColor = true;
            // 
            // groupBox_AutoConnect
            // 
            this.groupBox_AutoConnect.Controls.Add(this.label_Tips_AutoConnect);
            this.groupBox_AutoConnect.Controls.Add(this.radioButton_AutoConnect_Off);
            this.groupBox_AutoConnect.Controls.Add(this.radioButton_AutoConnect_On);
            this.groupBox_AutoConnect.Location = new System.Drawing.Point(6, 88);
            this.groupBox_AutoConnect.Name = "groupBox_AutoConnect";
            this.groupBox_AutoConnect.Size = new System.Drawing.Size(234, 67);
            this.groupBox_AutoConnect.TabIndex = 1;
            this.groupBox_AutoConnect.TabStop = false;
            this.groupBox_AutoConnect.Text = "开机自动联网";
            // 
            // label_Tips_AutoConnect
            // 
            this.label_Tips_AutoConnect.AutoSize = true;
            this.label_Tips_AutoConnect.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_AutoConnect.Location = new System.Drawing.Point(6, 46);
            this.label_Tips_AutoConnect.Name = "label_Tips_AutoConnect";
            this.label_Tips_AutoConnect.Size = new System.Drawing.Size(203, 12);
            this.label_Tips_AutoConnect.TabIndex = 2;
            this.label_Tips_AutoConnect.Text = "Tips:在开机之后自动帮您登录网关。";
            // 
            // radioButton_AutoConnect_Off
            // 
            this.radioButton_AutoConnect_Off.AutoSize = true;
            this.radioButton_AutoConnect_Off.Location = new System.Drawing.Point(126, 20);
            this.radioButton_AutoConnect_Off.Name = "radioButton_AutoConnect_Off";
            this.radioButton_AutoConnect_Off.Size = new System.Drawing.Size(47, 16);
            this.radioButton_AutoConnect_Off.TabIndex = 1;
            this.radioButton_AutoConnect_Off.TabStop = true;
            this.radioButton_AutoConnect_Off.Text = "禁用";
            this.radioButton_AutoConnect_Off.UseVisualStyleBackColor = true;
            // 
            // radioButton_AutoConnect_On
            // 
            this.radioButton_AutoConnect_On.AutoSize = true;
            this.radioButton_AutoConnect_On.Location = new System.Drawing.Point(19, 20);
            this.radioButton_AutoConnect_On.Name = "radioButton_AutoConnect_On";
            this.radioButton_AutoConnect_On.Size = new System.Drawing.Size(47, 16);
            this.radioButton_AutoConnect_On.TabIndex = 0;
            this.radioButton_AutoConnect_On.TabStop = true;
            this.radioButton_AutoConnect_On.Text = "启用";
            this.radioButton_AutoConnect_On.UseVisualStyleBackColor = true;
            // 
            // groupBox_FlowLimit
            // 
            this.groupBox_FlowLimit.Controls.Add(this.label_Tips_FlowLimit);
            this.groupBox_FlowLimit.Controls.Add(this.label_FlowLimit_GB);
            this.groupBox_FlowLimit.Controls.Add(this.numericUpDown_FlowLimit);
            this.groupBox_FlowLimit.Location = new System.Drawing.Point(6, 6);
            this.groupBox_FlowLimit.Name = "groupBox_FlowLimit";
            this.groupBox_FlowLimit.Size = new System.Drawing.Size(234, 76);
            this.groupBox_FlowLimit.TabIndex = 0;
            this.groupBox_FlowLimit.TabStop = false;
            this.groupBox_FlowLimit.Text = "流量设置";
            // 
            // label_Tips_FlowLimit
            // 
            this.label_Tips_FlowLimit.AutoSize = true;
            this.label_Tips_FlowLimit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Tips_FlowLimit.Location = new System.Drawing.Point(6, 53);
            this.label_Tips_FlowLimit.Name = "label_Tips_FlowLimit";
            this.label_Tips_FlowLimit.Size = new System.Drawing.Size(203, 12);
            this.label_Tips_FlowLimit.TabIndex = 2;
            this.label_Tips_FlowLimit.Text = "Tips:在这里设置您套餐的流量上限。";
            // 
            // label_FlowLimit_GB
            // 
            this.label_FlowLimit_GB.AutoSize = true;
            this.label_FlowLimit_GB.Location = new System.Drawing.Point(168, 22);
            this.label_FlowLimit_GB.Name = "label_FlowLimit_GB";
            this.label_FlowLimit_GB.Size = new System.Drawing.Size(47, 12);
            this.label_FlowLimit_GB.TabIndex = 1;
            this.label_FlowLimit_GB.Text = "GB / 月";
            // 
            // numericUpDown_FlowLimit
            // 
            this.numericUpDown_FlowLimit.Location = new System.Drawing.Point(19, 20);
            this.numericUpDown_FlowLimit.Name = "numericUpDown_FlowLimit";
            this.numericUpDown_FlowLimit.Size = new System.Drawing.Size(143, 21);
            this.numericUpDown_FlowLimit.TabIndex = 0;
            // 
            // tabPage_StdMgr
            // 
            this.tabPage_StdMgr.Controls.Add(this.groupBox_CacheMgr);
            this.tabPage_StdMgr.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StdMgr.Name = "tabPage_StdMgr";
            this.tabPage_StdMgr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_StdMgr.Size = new System.Drawing.Size(246, 354);
            this.tabPage_StdMgr.TabIndex = 3;
            this.tabPage_StdMgr.Text = "学生管理";
            this.tabPage_StdMgr.UseVisualStyleBackColor = true;
            // 
            // label_UserInfo
            // 
            this.label_UserInfo.AutoSize = true;
            this.label_UserInfo.Location = new System.Drawing.Point(12, 14);
            this.label_UserInfo.Name = "label_UserInfo";
            this.label_UserInfo.Size = new System.Drawing.Size(59, 12);
            this.label_UserInfo.TabIndex = 1;
            this.label_UserInfo.Text = "用户信息:";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(191, 427);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(12, 427);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox_CacheMgr
            // 
            this.groupBox_CacheMgr.Controls.Add(this.label_CacheMgr);
            this.groupBox_CacheMgr.Controls.Add(this.button_DelAll);
            this.groupBox_CacheMgr.Controls.Add(this.button_DelNow);
            this.groupBox_CacheMgr.Location = new System.Drawing.Point(6, 225);
            this.groupBox_CacheMgr.Name = "groupBox_CacheMgr";
            this.groupBox_CacheMgr.Size = new System.Drawing.Size(234, 123);
            this.groupBox_CacheMgr.TabIndex = 0;
            this.groupBox_CacheMgr.TabStop = false;
            this.groupBox_CacheMgr.Text = "缓存清理";
            // 
            // button_DelNow
            // 
            this.button_DelNow.Location = new System.Drawing.Point(6, 20);
            this.button_DelNow.Name = "button_DelNow";
            this.button_DelNow.Size = new System.Drawing.Size(136, 45);
            this.button_DelNow.TabIndex = 0;
            this.button_DelNow.Text = "清理当前用户缓存";
            this.button_DelNow.UseVisualStyleBackColor = true;
            this.button_DelNow.Click += new System.EventHandler(this.button_DelNow_Click);
            // 
            // button_DelAll
            // 
            this.button_DelAll.Location = new System.Drawing.Point(6, 70);
            this.button_DelAll.Name = "button_DelAll";
            this.button_DelAll.Size = new System.Drawing.Size(136, 45);
            this.button_DelAll.TabIndex = 1;
            this.button_DelAll.Text = "清理所有用户缓存";
            this.button_DelAll.UseVisualStyleBackColor = true;
            this.button_DelAll.Click += new System.EventHandler(this.button_DelAll_Click);
            // 
            // label_CacheMgr
            // 
            this.label_CacheMgr.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_CacheMgr.Location = new System.Drawing.Point(148, 20);
            this.label_CacheMgr.Name = "label_CacheMgr";
            this.label_CacheMgr.Size = new System.Drawing.Size(80, 95);
            this.label_CacheMgr.TabIndex = 2;
            this.label_CacheMgr.Text = "Tips:如果您遇到缓存文件加载错误，可以通过该功能清理并重建缓存文件以修复错误。";
            // 
            // Form_FondOption
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(277, 458);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_UserInfo);
            this.Controls.Add(this.tabControl_FondOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_FondOption";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "偏好设置";
            this.Load += new System.EventHandler(this.Form_FondOption_Load);
            this.tabControl_FondOption.ResumeLayout(false);
            this.tabPage_Envi.ResumeLayout(false);
            this.groupBox_Background.ResumeLayout(false);
            this.groupBox_Background.PerformLayout();
            this.groupBox_AutoUpdate.ResumeLayout(false);
            this.groupBox_AutoUpdate.PerformLayout();
            this.groupBox_MainPage.ResumeLayout(false);
            this.groupBox_MainPage.PerformLayout();
            this.tabPage_URP.ResumeLayout(false);
            this.groupBox_Algorithm.ResumeLayout(false);
            this.groupBox_TimeLimit.ResumeLayout(false);
            this.groupBox_TimeLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeLimit)).EndInit();
            this.groupBox_AutoCalc.ResumeLayout(false);
            this.groupBox_AutoCalc.PerformLayout();
            this.tabPage_Netgate.ResumeLayout(false);
            this.groupBox_AutoConnect.ResumeLayout(false);
            this.groupBox_AutoConnect.PerformLayout();
            this.groupBox_FlowLimit.ResumeLayout(false);
            this.groupBox_FlowLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FlowLimit)).EndInit();
            this.tabPage_StdMgr.ResumeLayout(false);
            this.groupBox_CacheMgr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_FondOption;
        private System.Windows.Forms.TabPage tabPage_Envi;
        private System.Windows.Forms.TabPage tabPage_URP;
        private System.Windows.Forms.TabPage tabPage_Netgate;
        private System.Windows.Forms.TabPage tabPage_StdMgr;
        private System.Windows.Forms.Label label_UserInfo;
        private System.Windows.Forms.GroupBox groupBox_MainPage;
        private System.Windows.Forms.RadioButton radioButton_MainPage_StdMgr;
        private System.Windows.Forms.RadioButton radioButton_MainPage_Netgate;
        private System.Windows.Forms.RadioButton radioButton_MainPage_URP;
        private System.Windows.Forms.GroupBox groupBox_AutoUpdate;
        private System.Windows.Forms.Label label_Tips_MainPage;
        private System.Windows.Forms.RadioButton radioButton_Update_Off;
        private System.Windows.Forms.RadioButton radioButton_Update_On;
        private System.Windows.Forms.TextBox textBox_UpdateAddress;
        private System.Windows.Forms.Label label_Update_Email;
        private System.Windows.Forms.Label label_Tips_AutpUpdate;
        private System.Windows.Forms.GroupBox groupBox_Background;
        private System.Windows.Forms.Label label_Tips_Background;
        private System.Windows.Forms.CheckBox checkBox_Background_Minimize;
        private System.Windows.Forms.GroupBox groupBox_AutoCalc;
        private System.Windows.Forms.RadioButton radioButton_AutoCalc_Off;
        private System.Windows.Forms.RadioButton radioButton_AutoCalc_All;
        private System.Windows.Forms.RadioButton radioButton_AutoCalc_Each;
        private System.Windows.Forms.RadioButton radioButton_AutoCalc_This;
        private System.Windows.Forms.Label label_Tips_AutoCalc;
        private System.Windows.Forms.GroupBox groupBox_TimeLimit;
        private System.Windows.Forms.Label label_TimeLimit_Second;
        private System.Windows.Forms.NumericUpDown numericUpDown_TimeLimit;
        private System.Windows.Forms.Label label_Tips_TimeLimit;
        private System.Windows.Forms.GroupBox groupBox_Algorithm;
        private System.Windows.Forms.Label label_Tips_Algorithm;
        private System.Windows.Forms.Button button_Algorithm;
        private System.Windows.Forms.GroupBox groupBox_FlowLimit;
        private System.Windows.Forms.Label label_Tips_FlowLimit;
        private System.Windows.Forms.Label label_FlowLimit_GB;
        private System.Windows.Forms.NumericUpDown numericUpDown_FlowLimit;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_AutoConnect;
        private System.Windows.Forms.RadioButton radioButton_AutoConnect_Off;
        private System.Windows.Forms.RadioButton radioButton_AutoConnect_On;
        private System.Windows.Forms.Label label_Tips_AutoConnect;
        private System.Windows.Forms.GroupBox groupBox_CacheMgr;
        private System.Windows.Forms.Button button_DelAll;
        private System.Windows.Forms.Button button_DelNow;
        private System.Windows.Forms.Label label_CacheMgr;
    }
}