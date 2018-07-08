namespace Course
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.login_username = new CCWin.SkinControl.SkinTextBox();
            this.login_password = new CCWin.SkinControl.SkinTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.login_register = new CCWin.SkinControl.SkinTabControl();
            this.loginPage = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.reg_sex2 = new CCWin.SkinControl.SkinRadioButton();
            this.reg_sex1 = new CCWin.SkinControl.SkinRadioButton();
            this.reg_name = new CCWin.SkinControl.SkinTextBox();
            this.reg_password = new CCWin.SkinControl.SkinTextBox();
            this.reg_stuNo = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.login_register.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(17, 50);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(124, 25);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "Username：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(17, 128);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(118, 25);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "Password：";
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.Transparent;
            this.login_username.DownBack = null;
            this.login_username.Icon = null;
            this.login_username.IconIsButton = false;
            this.login_username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.login_username.IsPasswordChat = '\0';
            this.login_username.IsSystemPasswordChar = false;
            this.login_username.Lines = new string[0];
            this.login_username.Location = new System.Drawing.Point(135, 48);
            this.login_username.Margin = new System.Windows.Forms.Padding(0);
            this.login_username.MaxLength = 16;
            this.login_username.MinimumSize = new System.Drawing.Size(28, 28);
            this.login_username.MouseBack = null;
            this.login_username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.NormlBack = null;
            this.login_username.Padding = new System.Windows.Forms.Padding(5);
            this.login_username.ReadOnly = false;
            this.login_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_username.Size = new System.Drawing.Size(200, 30);
            // 
            // 
            // 
            this.login_username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_username.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.login_username.SkinTxt.MaxLength = 16;
            this.login_username.SkinTxt.Multiline = true;
            this.login_username.SkinTxt.Name = "BaseText";
            this.login_username.SkinTxt.Size = new System.Drawing.Size(190, 20);
            this.login_username.SkinTxt.TabIndex = 0;
            this.login_username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.login_username.SkinTxt.WaterText = "";
            this.login_username.TabIndex = 3;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.login_username.WaterText = "";
            this.login_username.WordWrap = true;
            this.login_username.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.login_KeyDown);
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.Transparent;
            this.login_password.DownBack = null;
            this.login_password.Icon = null;
            this.login_password.IconIsButton = false;
            this.login_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.login_password.IsPasswordChat = '*';
            this.login_password.IsSystemPasswordChar = false;
            this.login_password.Lines = new string[0];
            this.login_password.Location = new System.Drawing.Point(135, 126);
            this.login_password.Margin = new System.Windows.Forms.Padding(0);
            this.login_password.MaxLength = 16;
            this.login_password.MinimumSize = new System.Drawing.Size(28, 28);
            this.login_password.MouseBack = null;
            this.login_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.NormlBack = null;
            this.login_password.Padding = new System.Windows.Forms.Padding(5);
            this.login_password.ReadOnly = false;
            this.login_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_password.Size = new System.Drawing.Size(200, 30);
            // 
            // 
            // 
            this.login_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.login_password.SkinTxt.MaxLength = 16;
            this.login_password.SkinTxt.Multiline = true;
            this.login_password.SkinTxt.Name = "BaseText";
            this.login_password.SkinTxt.PasswordChar = '*';
            this.login_password.SkinTxt.Size = new System.Drawing.Size(190, 20);
            this.login_password.SkinTxt.TabIndex = 0;
            this.login_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.login_password.SkinTxt.WaterText = "";
            this.login_password.TabIndex = 4;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.login_password.WaterText = "";
            this.login_password.WordWrap = true;
            this.login_password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.login_KeyDown);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(130, 220);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(100, 35);
            this.skinButton1.TabIndex = 7;
            this.skinButton1.Text = "Log in";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.login_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(130, 220);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(100, 35);
            this.skinButton2.TabIndex = 8;
            this.skinButton2.Text = "Register";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.register_Click);
            // 
            // login_register
            // 
            this.login_register.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.login_register.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.login_register.Controls.Add(this.loginPage);
            this.login_register.Controls.Add(this.skinTabPage2);
            this.login_register.HeadBack = null;
            this.login_register.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.login_register.ItemSize = new System.Drawing.Size(178, 40);
            this.login_register.Location = new System.Drawing.Point(20, 50);
            this.login_register.Name = "login_register";
            this.login_register.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("login_register.PageArrowDown")));
            this.login_register.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("login_register.PageArrowHover")));
            this.login_register.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("login_register.PageCloseHover")));
            this.login_register.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("login_register.PageCloseNormal")));
            this.login_register.PageDown = ((System.Drawing.Image)(resources.GetObject("login_register.PageDown")));
            this.login_register.PageHover = ((System.Drawing.Image)(resources.GetObject("login_register.PageHover")));
            this.login_register.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.login_register.PageNorml = null;
            this.login_register.SelectedIndex = 0;
            this.login_register.Size = new System.Drawing.Size(360, 330);
            this.login_register.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.login_register.TabIndex = 9;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.White;
            this.loginPage.Controls.Add(this.login_username);
            this.loginPage.Controls.Add(this.skinLabel2);
            this.loginPage.Controls.Add(this.skinButton1);
            this.loginPage.Controls.Add(this.skinLabel1);
            this.loginPage.Controls.Add(this.login_password);
            this.loginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPage.Location = new System.Drawing.Point(0, 40);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(360, 290);
            this.loginPage.TabIndex = 0;
            this.loginPage.TabItemImage = null;
            this.loginPage.Text = "Login";
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Controls.Add(this.reg_sex2);
            this.skinTabPage2.Controls.Add(this.reg_sex1);
            this.skinTabPage2.Controls.Add(this.reg_name);
            this.skinTabPage2.Controls.Add(this.reg_password);
            this.skinTabPage2.Controls.Add(this.reg_stuNo);
            this.skinTabPage2.Controls.Add(this.skinLabel6);
            this.skinTabPage2.Controls.Add(this.skinLabel5);
            this.skinTabPage2.Controls.Add(this.skinLabel4);
            this.skinTabPage2.Controls.Add(this.skinLabel3);
            this.skinTabPage2.Controls.Add(this.skinButton2);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 40);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(360, 290);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "Register";
            // 
            // reg_sex2
            // 
            this.reg_sex2.AutoSize = true;
            this.reg_sex2.BackColor = System.Drawing.Color.Transparent;
            this.reg_sex2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.reg_sex2.DownBack = null;
            this.reg_sex2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_sex2.Location = new System.Drawing.Point(240, 173);
            this.reg_sex2.MouseBack = null;
            this.reg_sex2.Name = "reg_sex2";
            this.reg_sex2.NormlBack = null;
            this.reg_sex2.SelectedDownBack = null;
            this.reg_sex2.SelectedMouseBack = null;
            this.reg_sex2.SelectedNormlBack = null;
            this.reg_sex2.Size = new System.Drawing.Size(99, 29);
            this.reg_sex2.TabIndex = 17;
            this.reg_sex2.TabStop = true;
            this.reg_sex2.Text = "Female";
            this.reg_sex2.UseVisualStyleBackColor = false;
            // 
            // reg_sex1
            // 
            this.reg_sex1.AutoSize = true;
            this.reg_sex1.BackColor = System.Drawing.Color.Transparent;
            this.reg_sex1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.reg_sex1.DownBack = null;
            this.reg_sex1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_sex1.Location = new System.Drawing.Point(150, 173);
            this.reg_sex1.MouseBack = null;
            this.reg_sex1.Name = "reg_sex1";
            this.reg_sex1.NormlBack = null;
            this.reg_sex1.SelectedDownBack = null;
            this.reg_sex1.SelectedMouseBack = null;
            this.reg_sex1.SelectedNormlBack = null;
            this.reg_sex1.Size = new System.Drawing.Size(79, 29);
            this.reg_sex1.TabIndex = 16;
            this.reg_sex1.TabStop = true;
            this.reg_sex1.Text = "Male";
            this.reg_sex1.UseVisualStyleBackColor = false;
            // 
            // reg_name
            // 
            this.reg_name.BackColor = System.Drawing.Color.Transparent;
            this.reg_name.DownBack = null;
            this.reg_name.Icon = null;
            this.reg_name.IconIsButton = false;
            this.reg_name.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.reg_name.IsPasswordChat = '\0';
            this.reg_name.IsSystemPasswordChar = false;
            this.reg_name.Lines = new string[0];
            this.reg_name.Location = new System.Drawing.Point(150, 125);
            this.reg_name.Margin = new System.Windows.Forms.Padding(0);
            this.reg_name.MaxLength = 30;
            this.reg_name.MinimumSize = new System.Drawing.Size(28, 28);
            this.reg_name.MouseBack = null;
            this.reg_name.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.reg_name.Multiline = true;
            this.reg_name.Name = "reg_name";
            this.reg_name.NormlBack = null;
            this.reg_name.Padding = new System.Windows.Forms.Padding(5);
            this.reg_name.ReadOnly = false;
            this.reg_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reg_name.Size = new System.Drawing.Size(185, 30);
            // 
            // 
            // 
            this.reg_name.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reg_name.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reg_name.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_name.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.reg_name.SkinTxt.MaxLength = 30;
            this.reg_name.SkinTxt.Multiline = true;
            this.reg_name.SkinTxt.Name = "BaseText";
            this.reg_name.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.reg_name.SkinTxt.TabIndex = 0;
            this.reg_name.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.reg_name.SkinTxt.WaterText = "";
            this.reg_name.TabIndex = 15;
            this.reg_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.reg_name.WaterText = "";
            this.reg_name.WordWrap = true;
            // 
            // reg_password
            // 
            this.reg_password.BackColor = System.Drawing.Color.Transparent;
            this.reg_password.DownBack = null;
            this.reg_password.Icon = null;
            this.reg_password.IconIsButton = false;
            this.reg_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.reg_password.IsPasswordChat = '*';
            this.reg_password.IsSystemPasswordChar = false;
            this.reg_password.Lines = new string[0];
            this.reg_password.Location = new System.Drawing.Point(150, 80);
            this.reg_password.Margin = new System.Windows.Forms.Padding(0);
            this.reg_password.MaxLength = 16;
            this.reg_password.MinimumSize = new System.Drawing.Size(28, 28);
            this.reg_password.MouseBack = null;
            this.reg_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.reg_password.Multiline = true;
            this.reg_password.Name = "reg_password";
            this.reg_password.NormlBack = null;
            this.reg_password.Padding = new System.Windows.Forms.Padding(5);
            this.reg_password.ReadOnly = false;
            this.reg_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reg_password.Size = new System.Drawing.Size(185, 30);
            // 
            // 
            // 
            this.reg_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reg_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reg_password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.reg_password.SkinTxt.MaxLength = 16;
            this.reg_password.SkinTxt.Multiline = true;
            this.reg_password.SkinTxt.Name = "BaseText";
            this.reg_password.SkinTxt.PasswordChar = '*';
            this.reg_password.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.reg_password.SkinTxt.TabIndex = 0;
            this.reg_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.reg_password.SkinTxt.WaterText = "";
            this.reg_password.TabIndex = 14;
            this.reg_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.reg_password.WaterText = "";
            this.reg_password.WordWrap = true;
            // 
            // reg_stuNo
            // 
            this.reg_stuNo.BackColor = System.Drawing.Color.Transparent;
            this.reg_stuNo.DownBack = null;
            this.reg_stuNo.Icon = null;
            this.reg_stuNo.IconIsButton = false;
            this.reg_stuNo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.reg_stuNo.IsPasswordChat = '\0';
            this.reg_stuNo.IsSystemPasswordChar = false;
            this.reg_stuNo.Lines = new string[0];
            this.reg_stuNo.Location = new System.Drawing.Point(150, 35);
            this.reg_stuNo.Margin = new System.Windows.Forms.Padding(0);
            this.reg_stuNo.MaxLength = 13;
            this.reg_stuNo.MinimumSize = new System.Drawing.Size(28, 28);
            this.reg_stuNo.MouseBack = null;
            this.reg_stuNo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.reg_stuNo.Multiline = true;
            this.reg_stuNo.Name = "reg_stuNo";
            this.reg_stuNo.NormlBack = null;
            this.reg_stuNo.Padding = new System.Windows.Forms.Padding(5);
            this.reg_stuNo.ReadOnly = false;
            this.reg_stuNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reg_stuNo.Size = new System.Drawing.Size(185, 30);
            // 
            // 
            // 
            this.reg_stuNo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reg_stuNo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reg_stuNo.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reg_stuNo.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.reg_stuNo.SkinTxt.MaxLength = 13;
            this.reg_stuNo.SkinTxt.Multiline = true;
            this.reg_stuNo.SkinTxt.Name = "BaseText";
            this.reg_stuNo.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.reg_stuNo.SkinTxt.TabIndex = 0;
            this.reg_stuNo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.reg_stuNo.SkinTxt.WaterText = "";
            this.reg_stuNo.TabIndex = 13;
            this.reg_stuNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_stuNo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.reg_stuNo.WaterText = "";
            this.reg_stuNo.WordWrap = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(81, 175);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(63, 25);
            this.skinLabel6.TabIndex = 12;
            this.skinLabel6.Text = "Sex：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(58, 130);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(86, 25);
            this.skinLabel5.TabIndex = 11;
            this.skinLabel5.Text = "Name：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(26, 80);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(118, 25);
            this.skinLabel4.TabIndex = 10;
            this.skinLabel4.Text = "Password：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(20, 40);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(124, 25);
            this.skinLabel3.TabIndex = 9;
            this.skinLabel3.Text = "Username：";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.login_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginExit);
            this.login_register.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.skinTabPage2.ResumeLayout(false);
            this.skinTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;

        private CCWin.SkinControl.SkinTextBox login_username;
        private CCWin.SkinControl.SkinTextBox login_password;

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinTabControl login_register;
        private CCWin.SkinControl.SkinTabPage loginPage;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinRadioButton reg_sex2;
        private CCWin.SkinControl.SkinRadioButton reg_sex1;
        private CCWin.SkinControl.SkinTextBox reg_name;
        private CCWin.SkinControl.SkinTextBox reg_password;
        private CCWin.SkinControl.SkinTextBox reg_stuNo;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}

