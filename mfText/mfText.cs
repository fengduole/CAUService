using System;
using System.Text;
using System.Text.RegularExpressions;

namespace mfText
{
    public class TextFunction
    {
        //网页转对象——本学期
        public mfCourse.CourseAdmin ThisToClass(string html)
        {
            mfCourse.CourseAdmin course_this = new mfCourse.CourseAdmin();

            string pattern_record = @"<TR onmouseover.*?</TR>";
            Regex regex_record = new Regex(pattern_record, RegexOptions.Singleline | RegexOptions.IgnoreCase);

            MatchCollection matches_record = regex_record.Matches(html);

            if (regex_record.IsMatch(html))
            {
                for (int i = 0; i < matches_record.Count; i++)
                {
                    string number = "", serial = "", name = "", property = "", remark = "", cnscore = "";
                    double credit = 0, score = 0;

                    string word_record = matches_record[i].Value;

                    string pattern_this = @"(?<=<TD align=center>).*?(?=</TD>)";
                    Regex regex_this = new Regex(pattern_this, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    MatchCollection matches_this = regex_this.Matches(word_record);

                    if (regex_this.IsMatch(word_record))
                    {
                        number = matches_this[0].Value.Trim();
                        serial = matches_this[1].Value.Trim();
                        name = matches_this[2].Value.Trim();
                        credit = double.Parse(matches_this[4].Value.Trim());
                        property = matches_this[5].Value.Trim();
                        try
                        {
                            score = double.Parse(matches_this[6].Value.Trim());
                        }
                        catch
                        {
                            cnscore = matches_this[6].Value.Trim();
                        }

                        mfCourse.Course course = new mfCourse.Course(number, serial, name, credit, property, score, cnscore, remark);

                        course_this.Add(course);
                    }
                }
            }
            else
                return null;

            return course_this;
        }


        //网页转对象——各学期
        public mfCourse.CourseAdmin EachToClass(string html)
        {
            mfCourse.CourseAdmin course_each = new mfCourse.CourseAdmin();

            string pattern_semester = @"<A name=.*?最低修读学分";
            Regex regex_semester = new Regex(pattern_semester, RegexOptions.Singleline | RegexOptions.IgnoreCase);

            MatchCollection matches_semester = regex_semester.Matches(html);

            if (regex_semester.IsMatch(html))
            {
                for (int j = 0; j < matches_semester.Count; j++)
                {
                    string word_semester = matches_semester[j].Value;
                    string Semester = Cut(word_semester, "<A name=", "></A>").Trim();

                    string pattern_record = @"<TR onmouseover.*?</TR>";
                    Regex regex_record = new Regex(pattern_record, RegexOptions.Singleline | RegexOptions.IgnoreCase);

                    MatchCollection matches_record = regex_record.Matches(word_semester);

                    for (int i = 0; i < matches_record.Count; i++)
                    {
                        string number = "", serial = "", name = "", property = "", remark = "", cnscore = "", semester = Semester;
                        double credit = 0, score = 0;

                        string word_record = matches_record[i].Value;

                        string pattern_each = @"(?<=<TD align=center>).*?(?=</TD>)";
                        Regex regex_each = new Regex(pattern_each, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        MatchCollection matches_each = regex_each.Matches(word_record);

                        if (regex_each.IsMatch(word_record))
                        {
                            number = matches_each[0].Value.Trim();
                            serial = matches_each[1].Value.Trim();
                            name = matches_each[2].Value.Trim();
                            credit = double.Parse(matches_each[4].Value.Trim());
                            property = matches_each[5].Value.Trim();
                        }

                        pattern_each = @"(?<=<P align=center>).*?(?=&nbsp;)";
                        regex_each = new Regex(pattern_each, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        matches_each = regex_each.Matches(word_record);

                        if (regex_each.IsMatch(word_record))
                        {
                            try
                            {
                                score = double.Parse(matches_each[0].Value.Trim());
                            }
                            catch
                            {
                                cnscore = matches_each[0].Value.Trim();
                            }
                        }

                        mfCourse.Course course = new mfCourse.Course(semester,number, serial, name, credit, property, score, cnscore, remark);

                        course_each.Add(course);
                    }
                }
            }
            else
                return null;

            return course_each;
        }


        //网页转对象——所有
        public mfCourse.CourseAdmin AllToClass(string html)
        {
            mfCourse.CourseAdmin course_all = new mfCourse.CourseAdmin();

            string pattern_record = @"<TR onmouseover.*?</TR>";
            Regex regex_record = new Regex(pattern_record, RegexOptions.Singleline | RegexOptions.IgnoreCase);

            MatchCollection matches_record = regex_record.Matches(html);

            if (regex_record.IsMatch(html))
            {
                for (int i = 0; i < matches_record.Count; i++)
                {
                    string number = "", serial = "", name = "", property = "", remark = "",cnscore="";
                    double credit=0, score=0;

                    string word_record = matches_record[i].Value;

                    string pattern_each = @"(?<=<TD align=center>).*?(?=</TD>)";
                    Regex regex_each = new Regex(pattern_each, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    MatchCollection matches_each = regex_each.Matches(word_record);

                    if (regex_each.IsMatch(word_record))
                    {
                        number = matches_each[0].Value.Trim();
                        serial = matches_each[1].Value.Trim();
                        name = matches_each[2].Value.Trim();
                            credit = double.Parse(matches_each[4].Value.Trim());                       
                        property = matches_each[5].Value.Trim();
                    }

                    pattern_each = @"(?<=<P align=center>).*?(?=&nbsp;)";
                    regex_each = new Regex(pattern_each, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    matches_each = regex_each.Matches(word_record);

                    if (regex_each.IsMatch(word_record))
                    {
                        try
                        {
                            score = double.Parse(matches_each[0].Value.Trim());
                        }
                        catch
                        {
                            cnscore = matches_each[0].Value.Trim();
                        }
                        remark = matches_each[1].Value.Trim();
                    }

                    mfCourse.Course course = new mfCourse.Course(number, serial, name, credit, property, score,cnscore, remark);
                    
                    course_all.Add(course);
                }
            }
            else
                return null;

            return course_all;
        }


        //解析升级数据
        public void AnalyzeUpdateInfo(string text, ref string version, ref  string level, ref string notes, ref  string address)
        {
            version = CutAndDel(ref text, "version：[", "]");
            level = CutAndDel(ref text, "level：[", "]");
            notes = CutAndDel(ref text, "notes：[", "]");
            address = CutAndDel(ref text, "address：[", "]");

            notes = notes.Replace("；", "；\n    ");
        }


        //解析网关信息
        public void AnalyzeNetInfo(string html,
                                   ref string number,
                                   ref double moneyLeft, 
                                   ref double timeUsed,
                                   ref double flowUsed, 
                                   ref double flowMoney,
                                   ref double moneyLimit,
                                   ref double moneyLimitLeft)
        {
            CutAndDel(ref html, "余额", "<FONT");
            moneyLeft = double.Parse(CutAndDel(ref html, "redtext>", "</FONT"));

            CutAndDel(ref html, "本月限额", "class=");
            moneyLimit = double.Parse(CutAndDel(ref html, "&nbsp;", "</TD>"));

            CutAndDel(ref html, "本月时长", "class=");
            timeUsed = double.Parse(CutAndDel(ref html, "&nbsp;", "</TD>"));

            CutAndDel(ref html, "本月流量", "class=");
            flowUsed = double.Parse(CutAndDel(ref html, "&nbsp;", "</TD>"));

            CutAndDel(ref html, "流量计费", "class=");
            flowMoney = double.Parse(CutAndDel(ref html, "&nbsp;", "</TD>"));

            CutAndDel(ref html, "剩余限额", "class=");
            moneyLimitLeft = double.Parse(CutAndDel(ref html, "redtext>", "</FONT"));

            CutAndDel(ref html, "一卡通号码", "class=");
            number = CutAndDel(ref html, "&nbsp;", "</TD>");
        }


        //解析基本信息
        public void AnalyzeUserInfo(string html,
                                    ref string number,
                                    ref string name,
                                    ref string sex,
                                    ref string hometown,
                                    ref string source,
                                    ref string nation,
                                    ref string birthday,
                                    ref string residence,
                                    ref string classes,
                                    ref string politics,
                                    ref string catagory,
                                    ref string timeLimit,
                                    ref string state,
                                    ref string inTime,
                                    ref string outTime,
                                    ref string idNum)
        {
            CutAndDel(ref html, "号：", "<TD class");
            number = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (number == "")
                number = "未知";

            CutAndDel(ref html, "名：", "<TD class");
            name = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (name == "")
                name = "未知";

            CutAndDel(ref html, "别：", "<TD class");
            sex = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (sex == "")
                sex = "未知";

            CutAndDel(ref html, "贯：", "<TD class");
            hometown = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (hometown == "")
                hometown = "未知";

            CutAndDel(ref html, "源：", "<TD class");
            source = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (source == "")
                source = "未知";

            CutAndDel(ref html, "族：", "<TD class");
            nation = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (nation == "")
                nation = "未知";

            CutAndDel(ref html, "出生日期：", "<TD class");
            birthday = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (birthday == "")
                birthday = "未知";

            CutAndDel(ref html, "家庭户籍：", "<TD class");
            residence = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (residence == "")
                residence = "未知";

            CutAndDel(ref html, "级：", "<TD class");
            classes = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (classes == "")
                classes = "未知";

            CutAndDel(ref html, "政治面貌：", "<TD class");
            politics = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (politics == "")
                politics = "未知";

            CutAndDel(ref html, "学生类型：", "<TD class");
            catagory = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (catagory == "")
                catagory = "未知";

            CutAndDel(ref html, "学籍年限：", "<TD class");
            timeLimit = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (timeLimit == "")
                timeLimit = "未知";

            CutAndDel(ref html, "在校状态：", "<TD class");
            state = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (state == "")
                state = "未知";

            CutAndDel(ref html, "入学时间：", "<TD class");
            inTime = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (inTime == "")
                inTime = "未知";

            CutAndDel(ref html, "毕业时间：", "<TD class");
            outTime = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (outTime == "")
                outTime = "未知";

            CutAndDel(ref html, "身份证号：", "<TD class");
            idNum = CutAndDel(ref html, "left>", "</TD>").Trim();
            if (idNum == "")
                idNum = "未知";
        }


        //获取用户名
        public string GetUserName(string html)
        {
            string pattern = @"(?<=欢迎光临&nbsp;).*?(?=&nbsp;)";
            Regex regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);

            Match match = regex.Match(html);

            if (regex.IsMatch(html))
                return match.Value;
            else
                return "";
        }


        //截取并删除
        public string CutAndDel(ref string str, string start, string end)
        {
            string ans;

            str = str.Substring(str.IndexOf(start) + start.Length);
            ans = str.Substring(0, str.IndexOf(end)).Trim();
            str = str.Substring(str.IndexOf(end) + end.Length);

            return ans;
        }


        //截取
        public string Cut(string str, string start, string end)
        {
            string ans;

            str = str.Substring(str.IndexOf(start) + start.Length);
            ans = str.Substring(0, str.IndexOf(end)).Trim();
            str = str.Substring(str.IndexOf(end) + end.Length);

            return ans;
        }
    }
}