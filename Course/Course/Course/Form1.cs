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


namespace Course
{
    public partial class Login : CCSkinMain
    {
        public static MySqlConnection conn;
        private bool isClosing = true;

        public Login()
        {
            InitializeComponent();
            String connetStr = "server=192.168.151.61;port=3306;user=CSuser;password=123456;database=systemdb;SslMode = none;";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            conn = new MySqlConnection(connetStr);
        }

        private void login_Click(object sender, EventArgs e)
        {

            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Username or password can't be blank！");
                return;
            }

            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("Connection success!");
                //在这里使用代码对数据库进行增删查改
                string selStr = "select * from student where stud_no='" + login_username.Text + "' and password='"+ login_password.Text+"';";

                MySqlCommand mycmd = new MySqlCommand(selStr, conn);
                Object result = mycmd.ExecuteScalar();
                conn.Close();
                //如果数据集为空，则密码错误
                if (result == null)
                {
                    MessageBox.Show("Wrong password!");
                }
                else
                {
                    MessageBox.Show("Log in success！");
                    MainBox.getLogin(login_username.Text);
                    isClosing = false;
                    this.Close();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(reg_stuNo.Text == "" || reg_password.Text == "" || reg_name.Text == "" || (!reg_sex1.Checked && !reg_sex2.Checked))
            {
                MessageBox.Show("Please fill in all the blanks！");
                return;
            }
           
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("Connection success");
                //在这里使用代码对数据库进行增删查改
                string UserName = this.reg_stuNo.Text;
                string password = this.reg_password.Text;
                string name = this.reg_name.Text;

                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^\d{13}$");
                System.Text.RegularExpressions.Regex reg2 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9_]{4,16}$");
                System.Text.RegularExpressions.Regex reg3 = new System.Text.RegularExpressions.Regex(@"^[\u4E00-\u9FA5A-Za-z0-9]{1,30}$");

                if (!reg1.IsMatch(UserName))
                {
                    MessageBox.Show("Username should be your student number with 13 bits");
                    return;
                }

                if (!reg2.IsMatch(password))
                {
                    MessageBox.Show("Password should be digits, words or underline with 4 to 16 bits");
                    return;
                }

                if (!reg3.IsMatch(name))
                {
                    MessageBox.Show("Name should be Chinese charactors, words or digits with 1 to 30 bits");
                    return;
                }

                //创建SQL语句
                string selStr = "select * from student where stud_no='" + UserName + "'";

                MySqlCommand mycmd = new MySqlCommand(selStr, conn);
                Object result = mycmd.ExecuteScalar();
                conn.Close();
                //如果数据集不为空，则用户名已经存在
                if (result!=null)
                {
                    int count = int.Parse(result.ToString());
                    MessageBox.Show("Username already exists！"+count);
                }
                else
                {
                    conn.Open();
                    var uuid = Guid.NewGuid().ToString();
                    string reg_sex = "";
                    if (reg_sex1.Checked)
                    {
                        reg_sex = "男";
                    }
                    else if (reg_sex2.Checked)
                    {
                        reg_sex = "女";
                    }

                    string insertAccount = "insert into student(student_id,name,sex,stud_no,password) values('" +uuid+ "','" + name + "','" + reg_sex + "','" + UserName+ "','" + password + "')";
                    MySqlCommand cmd = new MySqlCommand(insertAccount, conn);
                    int result2 = cmd.ExecuteNonQuery();
                    MessageBox.Show("Register success！");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void loginExit(object sender, FormClosingEventArgs e)
        {
            if (isClosing)
            {
                if (MessageBox.Show("Sure to Exit？", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    System.Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void login_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.login_Click(sender, e);//触发button事件  
            }
        }
    }
}

////增
//string sql = "insert into student(student_id,name,sex,stud_no,password) values('233','燊大佬','男','2016302580235','123456" + "')";
////string sql = "delete from user where userid='9'";
////string sql = "update user set username='啊哈',password='123' where userid='8'";
//MySqlCommand cmd = new MySqlCommand(sql, conn);
//int result = cmd.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的行数，返回1可做true判断。执行失败不返回任何数据，报错，下面代码都不执行

////查询条件固定
//string sql = "select * from user";
//MySqlCommand cmd = new MySqlCommand(sql, conn);
//MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
//while (reader.Read())//初始索引是-1，执行读取下一行数据，返回值是bool
//{
//    //Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
//    //Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
//    Console.WriteLine(reader.GetInt32("userid") + reader.GetString("username") + reader.GetString("password"));//"userid"是数据库对应的列名，推荐这种方式
//}
////查询条件不固定
////string sql = "select * from user where username='"+username+"' and password='"+password+"'"; //我们自己按照查询条件去组拼
//string sql = "select * from user where username=@para1 and password=@para2";//在sql语句中定义parameter，然后再给parameter赋值
//MySqlCommand cmd = new MySqlCommand(sql, conn);
//cmd.Parameters.AddWithValue("para1", username);
//cmd.Parameters.AddWithValue("para2", password);

//MySqlDataReader reader = cmd.ExecuteReader();
//if (reader.Read())//如果用户名和密码正确则能查询到一条语句，即读取下一行返回true
//{
//    return true;
//}
////查询并返回一个值
//string sql = "select count(*) from user";
//MySqlCommand cmd = new MySqlCommand(sql, conn);
//Object result = cmd.ExecuteScalar();//执行查询，并返回查询结果集中第一行的第一列。所有其他的列和行将被忽略。select语句无记录返回时，ExecuteScalar()返回NULL值
//if (result != null)
//{
//    int count = int.Parse(result.ToString());
//}
////
