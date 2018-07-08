using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MSWord = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;

namespace Course
{
    public partial class MainBox : CCSkinMain
    {
        public static MySqlConnection conn;
        private static string stuNum = "";

        public static void getLogin(string id)
        {
            stuNum = id;
        }

        public MainBox()
        {
            Login log = new Login();
            log.ShowDialog();
            MessageBox.Show("Welcome! " + stuNum);
            String connetStr = "server=192.168.151.61;port=3306;user=CSuser;password=123456;database=systemdb;SslMode = none;";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            conn = new MySqlConnection(connetStr);
            InitializeComponent();
            InitialStudent();
            InitialForm();
            InitialSelectForm();
        }

        private void InitialStudent()
        {
            while (this.skinDataGridView1.Rows.Count > 0)
            {
                this.skinDataGridView1.Rows.RemoveAt(0);
            }
            conn.Open();
            string readData = "select sex, name from student where stud_no = '" + stuNum + "';";
            MySqlCommand cmdRead = new MySqlCommand(readData, conn);
            using (MySqlDataReader myReader = cmdRead.ExecuteReader())
            {
                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        this.studentNum.Text = stuNum;
                        this.studentSex.Text = myReader.GetString(0);
                        this.studentName.Text = myReader.GetString(1);
                        this.stuTitleNum.Visible = true;
                        this.stuTitleSex.Visible = true;
                        this.stuTitleName.Visible = true;
                    }
                }

                myReader.Dispose();
            }
            cmdRead.Dispose();
            conn.Close();
        }

        private void InitialForm()
        {
            while (this.skinDataGridView1.Rows.Count > 0)
            {
                this.skinDataGridView1.Rows.RemoveAt(0);
            }
            conn.Open();
            string readData = getSearchStr();
            MySqlCommand cmdRead = new MySqlCommand(readData, conn);
            using (MySqlDataReader myReader = cmdRead.ExecuteReader())
            {
                int index = 0;

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        skinDataGridView1.Rows.Add(row);
                        for (int i = 0; i < 10; i++)
                        {
                            skinDataGridView1.Rows[index].Cells[i].Value = myReader.GetString(i);
                        }

                        index++;
                    }
                }

                myReader.Dispose();
            }
            cmdRead.Dispose();
            conn.Close();
        }

        private void InitialSelectForm()
        {
            while (this.skinDataGridView2.Rows.Count > 0)
            {
                this.skinDataGridView2.Rows.RemoveAt(0);
            }
            conn.Open();
            string readData = "select c.name, c.credit, t.name, c.weekday, c.course_time," +
                "c.start_week, c.end_week, c.type, c.district, c.selected_count from course c " +
                "join teacher t on c.teacher_id = t.teacher_id " +
                "join course_has_student cs on c.course_id = cs.course_id " +
                "join student s on cs.student_id = s.student_id " +
                "where s.stud_no = '" + stuNum + "';";
            MySqlCommand cmdRead = new MySqlCommand(readData, conn);
            using (MySqlDataReader myReader = cmdRead.ExecuteReader())
            {
                int index = 0;

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        skinDataGridView2.Rows.Add(row);
                        for (int i = 0; i < 10; i++)
                        {
                            skinDataGridView2.Rows[index].Cells[i].Value = myReader.GetString(i);
                        }

                        index++;
                    }
                }

                myReader.Dispose();
            }
            cmdRead.Dispose();
            conn.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (weekStart.Text != "" && weekEnd.Text != "" && !weekStart.Text.Equals("不限") && !weekEnd.Text.Equals("不限"))
            {
                int sWeek = Convert.ToInt32(weekStart.Text);
                int eWeek = Convert.ToInt32(weekEnd.Text); 
                if (sWeek > eWeek)
                {
                    MessageBox.Show("Start week can't be more than end week!");
                    return;
                }

            }
            
            if (creditMax.Text != "" && creditMin.Text != "" && !creditMax.Text.Equals("不限") && !creditMin.Text.Equals("不限"))
            {
                double max = Convert.ToDouble(creditMax.Text);
                double min = Convert.ToDouble(creditMin.Text);
                if (max < min)
                {
                    MessageBox.Show("The maximum of credit can't be less than its minimum!");
                    return;
                }
            }

            while (this.skinDataGridView1.Rows.Count > 0)
            {
                this.skinDataGridView1.Rows.RemoveAt(0);
            }
            
            string readData = getSearchStr();
            conn.Open();
            MySqlCommand cmdRead = new MySqlCommand(readData, conn);
            using (MySqlDataReader myReader = cmdRead.ExecuteReader())
            {
                int index = 0;

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        skinDataGridView1.Rows.Add(row);
                        for (int i = 0; i < 10; i++)
                        {
                            skinDataGridView1.Rows[index].Cells[i].Value = myReader.GetString(i);
                        }

                        index++;
                    }
                }

                myReader.Dispose();
            }
            cmdRead.Dispose();
            conn.Close();
        }

        private string getSearchStr()
        {
            string select = "select c.name, c.credit, t.name, c.weekday, c.course_time," +
                "c.start_week, c.end_week, c.type, c.district, c.selected_count from course c " +
                "join teacher t" +
                " on c.teacher_id = t.teacher_id ";
            string addWord = "where ";

            //关键字搜索
            if (keywords.Text.Trim().Length != 0)
            {
                select += addWord;
                addWord = "and ";
                string kw = "'%" + keywords.Text + "%'";
                select += "c.name like " + kw + " or t.name like " + kw + " ";
            }

            //校区搜索
            if (district1.Checked || district2.Checked || district3.Checked || district4.Checked)
            {
                select += addWord;
                addWord = "and ";
                string linkWord = "(";
                if (district1.Checked)
                {
                    select += linkWord + "district like '%1区%' ";
                    linkWord = "or ";
                }
                if (district2.Checked)
                {
                    select += linkWord + "district like '%2区%' ";
                    linkWord = "or ";
                }
                if (district3.Checked)
                {
                    select += linkWord + "district like '%3区%' ";
                    linkWord = "or ";
                }
                if (district4.Checked)
                {
                    select += linkWord + "district like '%4区%' ";
                }
                select += ") ";
            }

            //类别搜索
            if (category1.Checked || category2.Checked || category3.Checked || category4.Checked || category5.Checked || category6.Checked || category7.Checked)
            {
                select += addWord;
                addWord = "and ";
                string linkWord = "(";
                if (category1.Checked)
                {
                    select += linkWord + "type = '" + category1.Text + "类' ";
                    linkWord = "or ";
                }
                if (category2.Checked)
                {
                    select += linkWord + "type = '" + category2.Text + "类' ";
                    linkWord = "or ";
                }
                if (category3.Checked)
                {
                    select += linkWord + "type = '" + category3.Text + "类' ";
                    linkWord = "or ";
                }
                if (category4.Checked)
                {
                    select += linkWord + "type = '" + category4.Text + "类' ";
                    linkWord = "or ";
                }
                if (category5.Checked)
                {
                    select += linkWord + "type = '" + category5.Text + "类' ";
                    linkWord = "or ";
                }
                if (category6.Checked)
                {
                    select += linkWord + "type = '" + category6.Text + "类' ";
                    linkWord = "or ";
                }
                if (category7.Checked)
                {
                    select += linkWord + "type = '" + category7.Text + "类' ";
                    linkWord = "or ";
                }
                select += ") ";
            }

            //学分限制
            if ((creditMax.Text != "" && !creditMax.Text.Equals("不限")) || (creditMin.Text != "" && !creditMin.Text.Equals("不限")))
            {
                select += addWord;
                addWord = "and ";
                if (creditMax.Text != "" && !creditMax.Text.Equals("不限") && creditMin.Text != "" && !creditMin.Text.Equals("不限"))
                    select += "credit between " + creditMin.Text + " and " + creditMax.Text + " ";
                else if (creditMax.Text != "" && !creditMax.Text.Equals("不限"))
                    select += "credit <= " + creditMax.Text + " ";
                else
                    select += "credit >= " + creditMin.Text + " ";
            }

            //星期
            if (weekday1.Checked || weekday2.Checked || weekday3.Checked || weekday4.Checked || weekday5.Checked || weekday6.Checked || weekday7.Checked)
            {
                select += addWord;
                addWord = "and ";
                string linkWord = "(";
                if (weekday1.Checked)
                {
                    select += linkWord + "weekday = '周一' ";
                    linkWord = "or ";
                }
                if (weekday2.Checked)
                {
                    select += linkWord + "weekday = '周二' ";
                    linkWord = "or ";
                }
                if (weekday3.Checked)
                {
                    select += linkWord + "weekday = '周三' ";
                    linkWord = "or ";
                }
                if (weekday4.Checked)
                {
                    select += linkWord + "weekday = '周四' ";
                    linkWord = "or ";
                }
                if (weekday5.Checked)
                {
                    select += linkWord + "weekday = '周五' ";
                    linkWord = "or ";
                }
                if (weekday6.Checked)
                {
                    select += linkWord + "weekday = '周六' ";
                    linkWord = "or ";
                }
                if (weekday7.Checked)
                {
                    select += linkWord + "weekday = '周日' ";
                    linkWord = "or ";
                }
                select += ") ";
            }

            //上课时间
            if (courseTime.Text != "" && !courseTime.Text.Equals("不限"))
            {
                select += addWord;
                addWord = "and ";
                select += "course_time = '" + courseTime.Text + "' ";
            }

            //开始、结束时间
            if (weekStart.Text != "" && !weekStart.Text.Equals("不限"))
            {
                select += addWord;
                addWord = "and ";
                select += "start_week >= " + weekStart.Text + " ";
            }
            if (weekEnd.Text != "" && !weekEnd.Text.Equals("不限"))
            {
                select += addWord;
                addWord = "and ";
                select += "end_week <= " + weekEnd.Text + " ";
            }


            select += ";";

            return select;
        }

        private void selectTeacher(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tName = this.skinDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.skinTabControl1.SelectTab(1);
                searchTeacher(tName);
            }
        }

        private void searchTea_Click(object sender, EventArgs e)
        {
            string tName = this.teacherName.Text;
            searchTeacher(tName);
        }

        private void searchTeacher(string tName)
        {
            string searchStr = "select distinct t.sex, t.title, t.department, c.name, c.weekday, c.course_time from teacher t " +
                "join course c on c.teacher_id = t.teacher_id and t.name = '" + tName + "';";

            conn.Open();
            MySqlCommand cmdRead = new MySqlCommand(searchStr, conn);
            try
            {
                using (MySqlDataReader myReader = cmdRead.ExecuteReader())
                {
                    int index = 0;
                    string weekday = "";
                    string time = "";


                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            this.teachName.Text = tName;
                            if (index == 0)
                            {
                                this.titleTName.Visible = true;
                                this.titleTSex.Visible = true;
                                this.titleTTitle.Visible = true;
                                this.titleTDep.Visible = true;
                                this.titleTCou.Visible = true;
                                this.teachSex.Text = myReader.GetString(0);
                                this.teachTitle.Text = myReader.GetString(1);
                                this.teachDep.Text = myReader.GetString(2);
                                this.teachCou.Text = "";
                            }

                            weekday = myReader.GetString(4);
                            time = myReader.GetString(5);

                            teachCou.Text += myReader.GetString(3) + " (" + weekday + " " + time + ")\n\n";

                            index++;
                        }
                    }
                    myReader.Dispose();
                }
                cmdRead.Dispose();
                conn.Close();
                if (this.titleTName.Visible == false)
                {
                    MessageBox.Show("No result！");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void addCourse(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {
                conn.Open();

                string courName = this.skinDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string courWeek = this.skinDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                //获取课程ID号
                string getCourID = "select course_id from course where name = '" + courName + "'" +
                    " and weekday = '" + courWeek + "';";
                string courID = "";
                MySqlCommand cmdCour = new MySqlCommand(getCourID, conn);
                using (MySqlDataReader myReader = cmdCour.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            courID = myReader.GetString(0);
                        }
                    }
                    myReader.Dispose();
                }
                cmdCour.Dispose();

                //获取用户ID号
                string studID = "";
                string getStudID = "select student_id from student where stud_no = '" + stuNum + "';";
                MySqlCommand cmdStud = new MySqlCommand(getStudID, conn);
                using (MySqlDataReader myReader = cmdStud.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            studID = myReader.GetString(0);
                        }
                    }
                    myReader.Dispose();
                }
                cmdStud.Dispose();

                //检测选课人数是否已达上限
                string courCount = this.skinDataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                int count = Convert.ToInt32(courCount);
                if(count == 30)
                {
                    MessageBox.Show("Selection failed！Course filled!");
                    conn.Close();
                    return;
                }

                //检测用户是否已经选过该课程
                bool check = true;
                string repeatStr = "select student_id from course_has_student where course_id = '" + courID + "' and student_id = '" + studID + "';";
                MySqlCommand cmdRepeat = new MySqlCommand(repeatStr, conn);
                using (MySqlDataReader myReader = cmdRepeat.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            check = false;
                            MessageBox.Show("Selection failed！You have already selected this course！");
                        }
                    }
                    myReader.Dispose();
                }
                cmdRepeat.Dispose();

                if (!check)
                {
                    conn.Close();
                    return;
                }
                
                //插入用户选课信息
                string insertData = "insert into course_has_student values('" + courID + "', '" + studID + "');";
                MySqlCommand cmdInsert = new MySqlCommand(insertData, conn);
                cmdInsert.ExecuteNonQuery();
                cmdInsert.Dispose();

                //刷新该课程选课人数字段信息
                string addData = "update course set selected_count = selected_count+1 where course_id = '" + courID + "';";
                MySqlCommand cmdAdd = new MySqlCommand(addData, conn);
                cmdAdd.ExecuteNonQuery();
                cmdAdd.Dispose();

                conn.Close();
                MessageBox.Show("Selection success！");
                InitialForm();
                InitialSelectForm();
            }
        }
        
        private void deleteCourse(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                conn.Open();

                string courName = this.skinDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                string courWeek = this.skinDataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

                //获取课程ID号
                string getCourID = "select course_id from course where name = '" + courName + "'" +
                    " and weekday = '" + courWeek + "';";
                string courID = "";
                MySqlCommand cmdCour = new MySqlCommand(getCourID, conn);
                using (MySqlDataReader myReader = cmdCour.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            courID = myReader.GetString(0);
                        }
                    }
                    myReader.Dispose();
                }
                cmdCour.Dispose();

                //获取用户ID号
                string studID = "";
                string getStudID = "select student_id from student where stud_no = '" + stuNum + "';";
                MySqlCommand cmdStud = new MySqlCommand(getStudID, conn);
                using (MySqlDataReader myReader = cmdStud.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            studID = myReader.GetString(0);
                        }
                    }
                    myReader.Dispose();
                }
                cmdStud.Dispose();

                //从用户选课信息删除该课程
                string insertData = "delete from course_has_student where course_id = '" + courID + "' and student_id = '" + studID + "' ;";
                MySqlCommand cmdDelete = new MySqlCommand(insertData, conn);
                cmdDelete.ExecuteNonQuery();
                cmdDelete.Dispose();

                //从该课程选课人数中减去1
                string minusData = "update course set selected_count = selected_count-1 where course_id = '" + courID + "';";
                MySqlCommand cmdMinus = new MySqlCommand(minusData, conn);
                cmdMinus.ExecuteNonQuery();
                cmdMinus.Dispose();

                conn.Close();
                MessageBox.Show("Withdraw success！");
                InitialForm();
                InitialSelectForm();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strContent;                        //文本内容变量
            MSWord.Application wordApp;                   //Word应用程序变量 
            MSWord.Document wordDoc;                  //Word文档变量
            
            wordApp = new MSWord.ApplicationClass(); //初始化

            wordApp.Visible = true;//使文档可见
            

            //由于使用的是COM库，因此有许多变量需要用Missing.Value代替
            Object Nothing = Missing.Value;
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            //页面设置
            wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
            wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
            wordDoc.PageSetup.TopMargin = 57.0f;
            wordDoc.PageSetup.BottomMargin = 57.0f;
            wordDoc.PageSetup.LeftMargin = 57.0f;
            wordDoc.PageSetup.RightMargin = 57.0f;
            wordDoc.PageSetup.HeaderDistance = 30.0f;//页眉位置


            //写入普通文本
            object unite = MSWord.WdUnits.wdStory;
            wordApp.Selection.EndKey(ref unite, ref Nothing);//将光标移到文本末尾
            wordApp.Selection.ParagraphFormat.FirstLineIndent = 0;//取消首行缩进的长度
            strContent = "Report\n";
            wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
            wordDoc.Paragraphs.Last.Range.Font.Name = "黑体";
            wordDoc.Paragraphs.Last.Range.Font.Size = 28;
            wordDoc.Paragraphs.Last.Range.Text = strContent;


            wordDoc.Content.InsertAfter("\n");//这一句与下一句的顺序不能颠倒，原因还没搞透
            wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
            wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;
            wordDoc.Paragraphs.Last.Range.Font.Name = "宋体";
            wordDoc.Paragraphs.Last.Range.Font.Size = 12;

            //设置表格的行数和列数
            int tableRow = 1;
            int tableColumn = 10;

            //定义一个Word中的表格对象
            MSWord.Table table = wordDoc.Tables.Add(wordApp.Selection.Range,
            tableRow, tableColumn, ref Nothing, ref Nothing);

            //默认创建的表格没有边框，这里修改其属性，使得创建的表格带有边框 
            table.Borders.Enable = 1;//这个值可以设置得很大，例如5、13等等

            //表格的索引是从1开始的。
            table.Cell(1, 1).Range.Text = "课程名";
            table.Cell(1, 2).Range.Text = "学分";
            table.Cell(1, 3).Range.Text = "老师";
            table.Cell(1, 4).Range.Text = "星期";
            table.Cell(1, 5).Range.Text = "时间";
            table.Cell(1, 6).Range.Text = "开始周";
            table.Cell(1, 7).Range.Text = "结束周";
            table.Cell(1, 8).Range.Text = "类别";
            table.Cell(1, 9).Range.Text = "地点";
            table.Cell(1, 10).Range.Text = "已选人数";

            //搜索结果写入表格
            string readData = getSearchStr();
            MySqlCommand cmdRead = new MySqlCommand(readData, conn);

            conn.Open();
            using (MySqlDataReader myReader = cmdRead.ExecuteReader())
            {
                int index = 0;

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        //表格添加行
                        table.Rows.Add(ref Nothing);

                        for (int i = 0; i < 10; i++)
                        {
                            table.Cell(index + 2, i + 1).Range.Text = myReader.GetString(i);
                        }

                        index++;
                    }
                }

                myReader.Dispose();
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word 文档(*.docx)|*.docx|所有文件(*.*)|*.*";
            sfd.FileName = "report.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                object path = sfd.FileName;

                wordDoc.SaveAs(ref path, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //关闭word
                wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
            }

            cmdRead.Dispose();
            conn.Close();
            MessageBox.Show("Save Success！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            MessageBox.Show("Welcome! " + stuNum);
            this.Show();
            InitialStudent();
            InitialForm();
            InitialSelectForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //object path;                              //文件路径变量
            string strContent;                        //文本内容变量
            MSWord.Application wordApp;                   //Word应用程序变量 
            MSWord.Document wordDoc;                  //Word文档变量


            //path = Environment.CurrentDirectory + "\\MyWord_Print.doc";
            wordApp = new MSWord.Application(); //初始化

            wordApp.Visible = true;//使文档可见

            //如果已存在，则删除
            //if (File.Exists((string)path))
            //{
            //    File.Delete((string)path);
            //}

            //由于使用的是COM库，因此有许多变量需要用Missing.Value代替
            Object Nothing = Missing.Value;
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            //页面设置
            wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
            wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
            wordDoc.PageSetup.TopMargin = 57.0f;
            wordDoc.PageSetup.BottomMargin = 57.0f;
            wordDoc.PageSetup.LeftMargin = 57.0f;
            wordDoc.PageSetup.RightMargin = 57.0f;
            wordDoc.PageSetup.HeaderDistance = 30.0f;//页眉位置


            //写入普通文本
            object unite = MSWord.WdUnits.wdStory;
            wordApp.Selection.EndKey(ref unite, ref Nothing);//将光标移到文本末尾
            wordApp.Selection.ParagraphFormat.FirstLineIndent = 0;//取消首行缩进的长度
            strContent = "Selected Course List\n";
            wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
            wordDoc.Paragraphs.Last.Range.Font.Name = "黑体";
            wordDoc.Paragraphs.Last.Range.Font.Size = 28;
            wordDoc.Paragraphs.Last.Range.Text = strContent;


            wordDoc.Content.InsertAfter("\n");//这一句与下一句的顺序不能颠倒，原因还没搞透
            wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
            wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;
            wordDoc.Paragraphs.Last.Range.Font.Name = "宋体";
            wordDoc.Paragraphs.Last.Range.Font.Size = 12;

            //设置表格的行数和列数
            int tableRow = 1;
            int tableColumn = 10;

            //定义一个Word中的表格对象
            MSWord.Table table = wordDoc.Tables.Add(wordApp.Selection.Range,
            tableRow, tableColumn, ref Nothing, ref Nothing);

            //默认创建的表格没有边框，这里修改其属性，使得创建的表格带有边框 
            table.Borders.Enable = 1;//这个值可以设置得很大，例如5、13等等

            //表格的索引是从1开始的。
            table.Cell(1, 1).Range.Text = "课程名";
            table.Cell(1, 2).Range.Text = "学分";
            table.Cell(1, 3).Range.Text = "老师";
            table.Cell(1, 4).Range.Text = "星期";
            table.Cell(1, 5).Range.Text = "时间";
            table.Cell(1, 6).Range.Text = "开始周";
            table.Cell(1, 7).Range.Text = "结束周";
            table.Cell(1, 8).Range.Text = "类别";
            table.Cell(1, 9).Range.Text = "地点";
            table.Cell(1, 10).Range.Text = "已选人数";

            //搜索结果写入表格
            string readData = "select c.name, c.credit, t.name, c.weekday, c.course_time," +
                "c.start_week, c.end_week, c.type, c.district, c.selected_count from course c " +
                "join teacher t on c.teacher_id = t.teacher_id " +
                "join course_has_student cs on c.course_id = cs.course_id " +
                "join student s on cs.student_id = s.student_id " +
                "where s.stud_no = '" + stuNum + "';";
            MySqlCommand cmdRead = new MySqlCommand(readData, conn);
            conn.Open();
            using (MySqlDataReader myReader = cmdRead.ExecuteReader())
            {
                int index = 0;

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        //表格添加行
                        table.Rows.Add(ref Nothing);

                        for (int i = 0; i < 10; i++)
                        {
                            table.Cell(index + 2, i + 1).Range.Text = myReader.GetString(i);
                        }

                        index++;
                    }
                }

                myReader.Dispose();
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word 文档(*.docx)|*.docx|所有文件(*.*)|*.*";
            sfd.FileName = "report.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                object path = sfd.FileName;

                wordDoc.SaveAs(ref path, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //关闭word
                wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
            }
            //关闭wordDoc文档对象


            cmdRead.Dispose();
            conn.Close();
            MessageBox.Show("Save Success！");
        }
    }
}


