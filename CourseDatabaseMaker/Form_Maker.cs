using System;
using System.Windows.Forms;
using System.IO;

namespace CourseDatabaseMaker
{
    public partial class Form_Maker : Form
    {
        mfCourse.DataCourseAdmin database = new mfCourse.DataCourseAdmin("CourseLibrary.txt");
        bool isRun_textBox_Number_TextChanged = true;
        int DB_index;

        public Form_Maker()
        {
            InitializeComponent();
        }


        //窗口加载
        private void Form_Maker_Load(object sender, EventArgs e)
        {
            database.Display(ref listView_CourseDatabase);

            label_TotalCourse.Text = "总课程数:" + database.n.ToString();
            label_Version.Text = "版本号:" + database.version;
        }


        //课程号TextBox改变
        private void textBox_Number_TextChanged(object sender, EventArgs e)
        {
            if (!isRun_textBox_Number_TextChanged)
                return;

            if (textBox_Number.Text == "")
            {
                database.Default(true);
                database.Display(ref listView_CourseDatabase);
                return;
            }

            if (textBox_Number.Text.Length < 2)
                return;

            int count = database.Search(textBox_Number.Text, true);
            database.Display(ref listView_CourseDatabase);

            if (textBox_Number.Text.Length == textBox_Number.MaxLength)
                textBox_Name.Focus();

            if (listView_CourseDatabase.Items.Count == 0 && textBox_Number.Text.Length == textBox_Number.MaxLength)
                button_Add.Enabled = true;
            else
                button_Add.Enabled = false;
        }


        //添加课程
        private void button_Add_Click(object sender, EventArgs e)
        {
            database.AddRecord(textBox_Number.Text, textBox_Name.Text, textBox_Property.Text);
            database.Save();

            textBox_Number.Text = textBox_Name.Text = "";
            label_TotalCourse.Text = "总课程数:" + database.n.ToString();
            label_Version.Text = "版本号:" + database.version;
            button_Add.Enabled = false;
        }


        //修改课程
        private void button_Edit_Click(object sender, EventArgs e)
        {
            database.dataCourse[DB_index].number = textBox_Number.Text;
            database.dataCourse[DB_index].name = textBox_Name.Text;
            database.dataCourse[DB_index].property = textBox_Property.Text;

            database.Save();
            database.Display(ref listView_CourseDatabase);
        }


        //
        private void listView_CourseDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LV_index = SelectIndex();

            button_Edit.Enabled = false;

            if (LV_index == -1)
                return;

            button_Edit.Enabled = true;

            DB_index = database.Find(listView_CourseDatabase.Items[LV_index].Text);

            isRun_textBox_Number_TextChanged = false;

            textBox_Number.Text = database.dataCourse[DB_index].number;
            textBox_Name.Text = database.dataCourse[DB_index].name;
            textBox_Property.Text = database.dataCourse[DB_index].property;

            isRun_textBox_Number_TextChanged = true;
        }


        //所选项编号
        private int SelectIndex()
        {
            foreach (ListViewItem item in listView_CourseDatabase.Items)
            {
                if (item.Selected)
                {
                    return item.Index;
                }
            }

            return -1;
        }


        //发布
        private void button_Release_Click(object sender, EventArgs e)
        {
            mfRegEdit.mfRegEdit regEdit = new mfRegEdit.mfRegEdit();

            string path = regEdit.Load("ProgramPath", "") + "\\CourseLibrary.txt";

            if (File.Exists(path))
                File.Delete(path);

            File.Copy("CourseLibrary.txt", path);
            MessageBox.Show("发布成功！");
        }
    }
}