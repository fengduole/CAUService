namespace CourseDatabaseMaker
{
    partial class Form_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Maker));
            this.listView_CourseDatabase = new System.Windows.Forms.ListView();
            this.columnHeader_CourseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CourseProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Property = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_TotalCourse = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Release = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_CourseDatabase
            // 
            this.listView_CourseDatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_CourseNumber,
            this.columnHeader_CourseName,
            this.columnHeader_CourseProperty});
            this.listView_CourseDatabase.FullRowSelect = true;
            this.listView_CourseDatabase.GridLines = true;
            this.listView_CourseDatabase.Location = new System.Drawing.Point(12, 12);
            this.listView_CourseDatabase.MultiSelect = false;
            this.listView_CourseDatabase.Name = "listView_CourseDatabase";
            this.listView_CourseDatabase.Size = new System.Drawing.Size(460, 619);
            this.listView_CourseDatabase.TabIndex = 5;
            this.listView_CourseDatabase.UseCompatibleStateImageBehavior = false;
            this.listView_CourseDatabase.View = System.Windows.Forms.View.Details;
            this.listView_CourseDatabase.SelectedIndexChanged += new System.EventHandler(this.listView_CourseDatabase_SelectedIndexChanged);
            // 
            // columnHeader_CourseNumber
            // 
            this.columnHeader_CourseNumber.Text = "课程号";
            this.columnHeader_CourseNumber.Width = 70;
            // 
            // columnHeader_CourseName
            // 
            this.columnHeader_CourseName.Text = "课程名";
            this.columnHeader_CourseName.Width = 240;
            // 
            // columnHeader_CourseProperty
            // 
            this.columnHeader_CourseProperty.Text = "属性";
            this.columnHeader_CourseProperty.Width = 120;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(12, 637);
            this.textBox_Number.MaxLength = 8;
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(69, 21);
            this.textBox_Number.TabIndex = 0;
            this.textBox_Number.TextChanged += new System.EventHandler(this.textBox_Number_TextChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textBox_Name.Location = new System.Drawing.Point(87, 637);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(237, 21);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Property
            // 
            this.textBox_Property.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textBox_Property.Location = new System.Drawing.Point(330, 637);
            this.textBox_Property.Name = "textBox_Property";
            this.textBox_Property.Size = new System.Drawing.Size(142, 21);
            this.textBox_Property.TabIndex = 2;
            // 
            // button_Add
            // 
            this.button_Add.Enabled = false;
            this.button_Add.Location = new System.Drawing.Point(397, 664);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "添加";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_TotalCourse
            // 
            this.label_TotalCourse.AutoSize = true;
            this.label_TotalCourse.Location = new System.Drawing.Point(10, 669);
            this.label_TotalCourse.Name = "label_TotalCourse";
            this.label_TotalCourse.Size = new System.Drawing.Size(59, 12);
            this.label_TotalCourse.TabIndex = 6;
            this.label_TotalCourse.Text = "总课程数:";
            // 
            // label_Version
            // 
            this.label_Version.Location = new System.Drawing.Point(129, 664);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(100, 23);
            this.label_Version.TabIndex = 7;
            this.label_Version.Text = "版本号:";
            this.label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Edit
            // 
            this.button_Edit.Enabled = false;
            this.button_Edit.Location = new System.Drawing.Point(316, 664);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "修改";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Release
            // 
            this.button_Release.Location = new System.Drawing.Point(235, 664);
            this.button_Release.Name = "button_Release";
            this.button_Release.Size = new System.Drawing.Size(75, 23);
            this.button_Release.TabIndex = 5;
            this.button_Release.Text = "发布";
            this.button_Release.UseVisualStyleBackColor = true;
            this.button_Release.Click += new System.EventHandler(this.button_Release_Click);
            // 
            // Form_Maker
            // 
            this.AcceptButton = this.button_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 699);
            this.Controls.Add(this.button_Release);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_TotalCourse);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Property);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.listView_CourseDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Maker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "数据库生成器";
            this.Load += new System.EventHandler(this.Form_Maker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_CourseDatabase;
        private System.Windows.Forms.ColumnHeader columnHeader_CourseNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_CourseName;
        private System.Windows.Forms.ColumnHeader columnHeader_CourseProperty;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Property;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_TotalCourse;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Release;
    }
}

