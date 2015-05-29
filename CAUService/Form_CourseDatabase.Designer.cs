namespace CAUService
{
    partial class Form_CourseDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CourseDatabase));
            this.listView_CourseDatabase = new System.Windows.Forms.ListView();
            this.columnHeader_CourseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CourseProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_TotalRecord = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_SearchCount = new System.Windows.Forms.Label();
            this.label_KeyWord = new System.Windows.Forms.Label();
            this.textBox_KeyWord = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
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
            this.listView_CourseDatabase.Location = new System.Drawing.Point(12, 41);
            this.listView_CourseDatabase.MultiSelect = false;
            this.listView_CourseDatabase.Name = "listView_CourseDatabase";
            this.listView_CourseDatabase.Size = new System.Drawing.Size(460, 391);
            this.listView_CourseDatabase.TabIndex = 2;
            this.listView_CourseDatabase.UseCompatibleStateImageBehavior = false;
            this.listView_CourseDatabase.View = System.Windows.Forms.View.Details;
            this.listView_CourseDatabase.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_CourseDatabase_MouseDoubleClick);
            // 
            // columnHeader_CourseNumber
            // 
            this.columnHeader_CourseNumber.Text = "课程号";
            this.columnHeader_CourseNumber.Width = 90;
            // 
            // columnHeader_CourseName
            // 
            this.columnHeader_CourseName.Text = "课程名";
            this.columnHeader_CourseName.Width = 230;
            // 
            // columnHeader_CourseProperty
            // 
            this.columnHeader_CourseProperty.Text = "属性";
            this.columnHeader_CourseProperty.Width = 110;
            // 
            // label_TotalRecord
            // 
            this.label_TotalRecord.AutoSize = true;
            this.label_TotalRecord.Location = new System.Drawing.Point(10, 440);
            this.label_TotalRecord.Name = "label_TotalRecord";
            this.label_TotalRecord.Size = new System.Drawing.Size(59, 12);
            this.label_TotalRecord.TabIndex = 1;
            this.label_TotalRecord.Text = "总课程数:";
            // 
            // label_Version
            // 
            this.label_Version.Location = new System.Drawing.Point(287, 440);
            this.label_Version.Name = "label_Version";
            this.label_Version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Version.Size = new System.Drawing.Size(187, 12);
            this.label_Version.TabIndex = 2;
            this.label_Version.Text = "数据库版本";
            // 
            // label_SearchCount
            // 
            this.label_SearchCount.Location = new System.Drawing.Point(139, 435);
            this.label_SearchCount.Name = "label_SearchCount";
            this.label_SearchCount.Size = new System.Drawing.Size(207, 23);
            this.label_SearchCount.TabIndex = 3;
            this.label_SearchCount.Text = "共找到xx条记录";
            this.label_SearchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_SearchCount.Visible = false;
            // 
            // label_KeyWord
            // 
            this.label_KeyWord.AutoSize = true;
            this.label_KeyWord.Location = new System.Drawing.Point(12, 17);
            this.label_KeyWord.Name = "label_KeyWord";
            this.label_KeyWord.Size = new System.Drawing.Size(47, 12);
            this.label_KeyWord.TabIndex = 4;
            this.label_KeyWord.Text = "关键字:";
            // 
            // textBox_KeyWord
            // 
            this.textBox_KeyWord.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textBox_KeyWord.Location = new System.Drawing.Point(65, 14);
            this.textBox_KeyWord.MaxLength = 20;
            this.textBox_KeyWord.Name = "textBox_KeyWord";
            this.textBox_KeyWord.Size = new System.Drawing.Size(327, 21);
            this.textBox_KeyWord.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(397, 12);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "检索";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // Form_CourseDatabase
            // 
            this.AcceptButton = this.button_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_KeyWord);
            this.Controls.Add(this.label_KeyWord);
            this.Controls.Add(this.label_SearchCount);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_TotalRecord);
            this.Controls.Add(this.listView_CourseDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CourseDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "课程数据库";
            this.Load += new System.EventHandler(this.Form_CourseDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_CourseDatabase;
        private System.Windows.Forms.ColumnHeader columnHeader_CourseNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_CourseName;
        private System.Windows.Forms.ColumnHeader columnHeader_CourseProperty;
        private System.Windows.Forms.Label label_TotalRecord;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_SearchCount;
        private System.Windows.Forms.Label label_KeyWord;
        private System.Windows.Forms.TextBox textBox_KeyWord;
        private System.Windows.Forms.Button button_Search;
    }
}