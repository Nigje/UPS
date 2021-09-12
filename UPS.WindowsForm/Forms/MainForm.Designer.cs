
namespace UPS.WindowsForm.Forms
{
    partial class MainForm
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
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_users = new System.Windows.Forms.TabPage();
            this.tlp_users_body = new System.Windows.Forms.TableLayoutPanel();
            this.p_user_header = new System.Windows.Forms.Panel();
            this.b_exportCSV = new System.Windows.Forms.Button();
            this.dtp_search_toDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_search_fromDate = new System.Windows.Forms.DateTimePicker();
            this.cb_searrch_status = new System.Windows.Forms.ComboBox();
            this.tb_search_email = new System.Windows.Forms.TextBox();
            this.tb_search_lastName = new System.Windows.Forms.TextBox();
            this.tb_search_firstName = new System.Windows.Forms.TextBox();
            this.l__toDate = new System.Windows.Forms.Label();
            this.l__fromDate = new System.Windows.Forms.Label();
            this.l__status = new System.Windows.Forms.Label();
            this.l__gender = new System.Windows.Forms.Label();
            this.cb_searchGender = new System.Windows.Forms.ComboBox();
            this.l__email = new System.Windows.Forms.Label();
            this.l__lastName = new System.Windows.Forms.Label();
            this.l__firstName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.l_editUser = new System.Windows.Forms.Label();
            this.b_editUser = new System.Windows.Forms.Button();
            this.l_removeUser = new System.Windows.Forms.Label();
            this.b_removeUser = new System.Windows.Forms.Button();
            this.b_searchUser = new System.Windows.Forms.Button();
            this.l_newUser = new System.Windows.Forms.Label();
            this.c_addNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_user_body = new System.Windows.Forms.Panel();
            this.lv_userList = new System.Windows.Forms.ListView();
            this.Index = new System.Windows.Forms.ColumnHeader("(none)");
            this.UserId = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.CreationTime = new System.Windows.Forms.ColumnHeader();
            this.lv_header_nothing = new System.Windows.Forms.ColumnHeader();
            this.p_user_footer = new System.Windows.Forms.Panel();
            this.tlp_userList_paging = new System.Windows.Forms.TableLayoutPanel();
            this.p_pageSize = new System.Windows.Forms.Panel();
            this.l_totalPageCounts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_totalPages = new System.Windows.Forms.Label();
            this.cb_pageSize = new System.Windows.Forms.ComboBox();
            this.l_pageSize = new System.Windows.Forms.Label();
            this.p_userList_pageNumber = new System.Windows.Forms.Panel();
            this.tlp_userList_footer_pageNumber = new System.Windows.Forms.TableLayoutPanel();
            this.p_userList_footer_pageNumber = new System.Windows.Forms.Panel();
            this.b_previousPage = new System.Windows.Forms.Button();
            this.b_nextPage = new System.Windows.Forms.Button();
            this.tb_pageNumber = new System.Windows.Forms.TextBox();
            this.p_userList_totalCount = new System.Windows.Forms.Panel();
            this.l_total = new System.Windows.Forms.Label();
            this.l_totalText = new System.Windows.Forms.Label();
            this.tp_configuration = new System.Windows.Forms.TabPage();
            this.tb_apiToken = new System.Windows.Forms.TextBox();
            this.l__ApiToken = new System.Windows.Forms.Label();
            this.b_saveConfiguration = new System.Windows.Forms.Button();
            this.tb_apiAddress = new System.Windows.Forms.TextBox();
            this.l_apiUrl = new System.Windows.Forms.Label();
            this.p_bodyBase.SuspendLayout();
            this.tc_main.SuspendLayout();
            this.tp_users.SuspendLayout();
            this.tlp_users_body.SuspendLayout();
            this.p_user_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_user_body.SuspendLayout();
            this.p_user_footer.SuspendLayout();
            this.tlp_userList_paging.SuspendLayout();
            this.p_pageSize.SuspendLayout();
            this.p_userList_pageNumber.SuspendLayout();
            this.tlp_userList_footer_pageNumber.SuspendLayout();
            this.p_userList_footer_pageNumber.SuspendLayout();
            this.p_userList_totalCount.SuspendLayout();
            this.tp_configuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bodyBase
            // 
            this.p_bodyBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.p_bodyBase.Controls.Add(this.tc_main);
            this.p_bodyBase.Size = new System.Drawing.Size(1278, 653);
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_users);
            this.tc_main.Controls.Add(this.tp_configuration);
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main.Location = new System.Drawing.Point(0, 0);
            this.tc_main.Margin = new System.Windows.Forms.Padding(0);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(1278, 653);
            this.tc_main.TabIndex = 1;
            // 
            // tp_users
            // 
            this.tp_users.Controls.Add(this.tlp_users_body);
            this.tp_users.Location = new System.Drawing.Point(4, 24);
            this.tp_users.Name = "tp_users";
            this.tp_users.Padding = new System.Windows.Forms.Padding(3);
            this.tp_users.Size = new System.Drawing.Size(1270, 625);
            this.tp_users.TabIndex = 0;
            this.tp_users.Text = "Users";
            this.tp_users.UseVisualStyleBackColor = true;
            // 
            // tlp_users_body
            // 
            this.tlp_users_body.ColumnCount = 1;
            this.tlp_users_body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_users_body.Controls.Add(this.p_user_header, 0, 0);
            this.tlp_users_body.Controls.Add(this.p_user_body, 0, 1);
            this.tlp_users_body.Controls.Add(this.p_user_footer, 0, 2);
            this.tlp_users_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_users_body.Location = new System.Drawing.Point(3, 3);
            this.tlp_users_body.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_users_body.Name = "tlp_users_body";
            this.tlp_users_body.RowCount = 3;
            this.tlp_users_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_users_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_users_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlp_users_body.Size = new System.Drawing.Size(1264, 619);
            this.tlp_users_body.TabIndex = 0;
            // 
            // p_user_header
            // 
            this.p_user_header.Controls.Add(this.b_exportCSV);
            this.p_user_header.Controls.Add(this.dtp_search_toDate);
            this.p_user_header.Controls.Add(this.dtp_search_fromDate);
            this.p_user_header.Controls.Add(this.cb_searrch_status);
            this.p_user_header.Controls.Add(this.tb_search_email);
            this.p_user_header.Controls.Add(this.tb_search_lastName);
            this.p_user_header.Controls.Add(this.tb_search_firstName);
            this.p_user_header.Controls.Add(this.l__toDate);
            this.p_user_header.Controls.Add(this.l__fromDate);
            this.p_user_header.Controls.Add(this.l__status);
            this.p_user_header.Controls.Add(this.l__gender);
            this.p_user_header.Controls.Add(this.cb_searchGender);
            this.p_user_header.Controls.Add(this.l__email);
            this.p_user_header.Controls.Add(this.l__lastName);
            this.p_user_header.Controls.Add(this.l__firstName);
            this.p_user_header.Controls.Add(this.pictureBox3);
            this.p_user_header.Controls.Add(this.pictureBox2);
            this.p_user_header.Controls.Add(this.l_editUser);
            this.p_user_header.Controls.Add(this.b_editUser);
            this.p_user_header.Controls.Add(this.l_removeUser);
            this.p_user_header.Controls.Add(this.b_removeUser);
            this.p_user_header.Controls.Add(this.b_searchUser);
            this.p_user_header.Controls.Add(this.l_newUser);
            this.p_user_header.Controls.Add(this.c_addNewUser);
            this.p_user_header.Controls.Add(this.pictureBox1);
            this.p_user_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_user_header.Location = new System.Drawing.Point(0, 0);
            this.p_user_header.Margin = new System.Windows.Forms.Padding(0);
            this.p_user_header.Name = "p_user_header";
            this.p_user_header.Size = new System.Drawing.Size(1264, 120);
            this.p_user_header.TabIndex = 1;
            // 
            // b_exportCSV
            // 
            this.b_exportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exportCSV.ForeColor = System.Drawing.Color.Black;
            this.b_exportCSV.Location = new System.Drawing.Point(332, 65);
            this.b_exportCSV.Name = "b_exportCSV";
            this.b_exportCSV.Size = new System.Drawing.Size(75, 34);
            this.b_exportCSV.TabIndex = 26;
            this.b_exportCSV.Text = "Export CSV";
            this.b_exportCSV.UseVisualStyleBackColor = true;
            this.b_exportCSV.Click += new System.EventHandler(this.b_exportCSV_Click);
            // 
            // dtp_search_toDate
            // 
            this.dtp_search_toDate.Location = new System.Drawing.Point(969, 46);
            this.dtp_search_toDate.Name = "dtp_search_toDate";
            this.dtp_search_toDate.Size = new System.Drawing.Size(200, 23);
            this.dtp_search_toDate.TabIndex = 25;
            // 
            // dtp_search_fromDate
            // 
            this.dtp_search_fromDate.Location = new System.Drawing.Point(969, 18);
            this.dtp_search_fromDate.Name = "dtp_search_fromDate";
            this.dtp_search_fromDate.Size = new System.Drawing.Size(200, 23);
            this.dtp_search_fromDate.TabIndex = 24;
            // 
            // cb_searrch_status
            // 
            this.cb_searrch_status.FormattingEnabled = true;
            this.cb_searrch_status.Location = new System.Drawing.Point(721, 49);
            this.cb_searrch_status.Name = "cb_searrch_status";
            this.cb_searrch_status.Size = new System.Drawing.Size(143, 23);
            this.cb_searrch_status.TabIndex = 23;
            // 
            // tb_search_email
            // 
            this.tb_search_email.Location = new System.Drawing.Point(507, 19);
            this.tb_search_email.Name = "tb_search_email";
            this.tb_search_email.Size = new System.Drawing.Size(143, 23);
            this.tb_search_email.TabIndex = 22;
            // 
            // tb_search_lastName
            // 
            this.tb_search_lastName.Location = new System.Drawing.Point(507, 75);
            this.tb_search_lastName.Name = "tb_search_lastName";
            this.tb_search_lastName.Size = new System.Drawing.Size(143, 23);
            this.tb_search_lastName.TabIndex = 21;
            // 
            // tb_search_firstName
            // 
            this.tb_search_firstName.Location = new System.Drawing.Point(507, 47);
            this.tb_search_firstName.Name = "tb_search_firstName";
            this.tb_search_firstName.Size = new System.Drawing.Size(143, 23);
            this.tb_search_firstName.TabIndex = 20;
            // 
            // l__toDate
            // 
            this.l__toDate.AutoSize = true;
            this.l__toDate.ForeColor = System.Drawing.Color.Black;
            this.l__toDate.Location = new System.Drawing.Point(895, 50);
            this.l__toDate.Name = "l__toDate";
            this.l__toDate.Size = new System.Drawing.Size(52, 15);
            this.l__toDate.TabIndex = 18;
            this.l__toDate.Text = "To Date: ";
            // 
            // l__fromDate
            // 
            this.l__fromDate.AutoSize = true;
            this.l__fromDate.ForeColor = System.Drawing.Color.Black;
            this.l__fromDate.Location = new System.Drawing.Point(895, 24);
            this.l__fromDate.Name = "l__fromDate";
            this.l__fromDate.Size = new System.Drawing.Size(68, 15);
            this.l__fromDate.TabIndex = 17;
            this.l__fromDate.Text = "From Date: ";
            // 
            // l__status
            // 
            this.l__status.AutoSize = true;
            this.l__status.ForeColor = System.Drawing.Color.Black;
            this.l__status.Location = new System.Drawing.Point(670, 52);
            this.l__status.Name = "l__status";
            this.l__status.Size = new System.Drawing.Size(45, 15);
            this.l__status.TabIndex = 16;
            this.l__status.Text = "Status: ";
            // 
            // l__gender
            // 
            this.l__gender.AutoSize = true;
            this.l__gender.ForeColor = System.Drawing.Color.Black;
            this.l__gender.Location = new System.Drawing.Point(670, 25);
            this.l__gender.Name = "l__gender";
            this.l__gender.Size = new System.Drawing.Size(51, 15);
            this.l__gender.TabIndex = 15;
            this.l__gender.Text = "Gender: ";
            // 
            // cb_searchGender
            // 
            this.cb_searchGender.FormattingEnabled = true;
            this.cb_searchGender.Location = new System.Drawing.Point(721, 21);
            this.cb_searchGender.Name = "cb_searchGender";
            this.cb_searchGender.Size = new System.Drawing.Size(143, 23);
            this.cb_searchGender.TabIndex = 14;
            // 
            // l__email
            // 
            this.l__email.AutoSize = true;
            this.l__email.ForeColor = System.Drawing.Color.Black;
            this.l__email.Location = new System.Drawing.Point(439, 22);
            this.l__email.Name = "l__email";
            this.l__email.Size = new System.Drawing.Size(42, 15);
            this.l__email.TabIndex = 12;
            this.l__email.Text = "Email: ";
            // 
            // l__lastName
            // 
            this.l__lastName.AutoSize = true;
            this.l__lastName.ForeColor = System.Drawing.Color.Black;
            this.l__lastName.Location = new System.Drawing.Point(439, 78);
            this.l__lastName.Name = "l__lastName";
            this.l__lastName.Size = new System.Drawing.Size(69, 15);
            this.l__lastName.TabIndex = 11;
            this.l__lastName.Text = "Last Name: ";
            // 
            // l__firstName
            // 
            this.l__firstName.AutoSize = true;
            this.l__firstName.ForeColor = System.Drawing.Color.Black;
            this.l__firstName.Location = new System.Drawing.Point(439, 51);
            this.l__firstName.Name = "l__firstName";
            this.l__firstName.Size = new System.Drawing.Size(70, 15);
            this.l__firstName.TabIndex = 10;
            this.l__firstName.Text = "First Name: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::UPS.WindowsForm.Properties.Resources.VerticalLine;
            this.pictureBox3.Location = new System.Drawing.Point(307, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 80);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::UPS.WindowsForm.Properties.Resources.VerticalLine;
            this.pictureBox2.Location = new System.Drawing.Point(208, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 80);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // l_editUser
            // 
            this.l_editUser.AutoSize = true;
            this.l_editUser.ForeColor = System.Drawing.Color.Black;
            this.l_editUser.Location = new System.Drawing.Point(131, 87);
            this.l_editUser.Name = "l_editUser";
            this.l_editUser.Size = new System.Drawing.Size(53, 15);
            this.l_editUser.TabIndex = 7;
            this.l_editUser.Text = "Edit User";
            // 
            // b_editUser
            // 
            this.b_editUser.BackgroundImage = global::UPS.WindowsForm.Properties.Resources.EditUser_2;
            this.b_editUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_editUser.Location = new System.Drawing.Point(119, 13);
            this.b_editUser.Name = "b_editUser";
            this.b_editUser.Size = new System.Drawing.Size(80, 80);
            this.b_editUser.TabIndex = 6;
            this.b_editUser.UseVisualStyleBackColor = true;
            this.b_editUser.Click += new System.EventHandler(this.b_editUser_Click);
            // 
            // l_removeUser
            // 
            this.l_removeUser.AutoSize = true;
            this.l_removeUser.ForeColor = System.Drawing.Color.Black;
            this.l_removeUser.Location = new System.Drawing.Point(223, 86);
            this.l_removeUser.Name = "l_removeUser";
            this.l_removeUser.Size = new System.Drawing.Size(76, 15);
            this.l_removeUser.TabIndex = 5;
            this.l_removeUser.Text = "Remove User";
            // 
            // b_removeUser
            // 
            this.b_removeUser.BackgroundImage = global::UPS.WindowsForm.Properties.Resources.RemoveUser_2;
            this.b_removeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_removeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removeUser.Location = new System.Drawing.Point(218, 13);
            this.b_removeUser.Name = "b_removeUser";
            this.b_removeUser.Size = new System.Drawing.Size(80, 80);
            this.b_removeUser.TabIndex = 4;
            this.b_removeUser.UseVisualStyleBackColor = true;
            this.b_removeUser.Click += new System.EventHandler(this.b_removeUser_Click);
            // 
            // b_searchUser
            // 
            this.b_searchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_searchUser.ForeColor = System.Drawing.Color.Black;
            this.b_searchUser.Location = new System.Drawing.Point(332, 24);
            this.b_searchUser.Name = "b_searchUser";
            this.b_searchUser.Size = new System.Drawing.Size(75, 34);
            this.b_searchUser.TabIndex = 3;
            this.b_searchUser.Text = "Search";
            this.b_searchUser.UseVisualStyleBackColor = false;
            this.b_searchUser.Click += new System.EventHandler(this.b_searchUser_Click);
            // 
            // l_newUser
            // 
            this.l_newUser.AutoSize = true;
            this.l_newUser.ForeColor = System.Drawing.Color.Black;
            this.l_newUser.Location = new System.Drawing.Point(35, 87);
            this.l_newUser.Name = "l_newUser";
            this.l_newUser.Size = new System.Drawing.Size(57, 15);
            this.l_newUser.TabIndex = 2;
            this.l_newUser.Text = "New User";
            // 
            // c_addNewUser
            // 
            this.c_addNewUser.BackgroundImage = global::UPS.WindowsForm.Properties.Resources.AddUser_2;
            this.c_addNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c_addNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_addNewUser.Location = new System.Drawing.Point(20, 13);
            this.c_addNewUser.Name = "c_addNewUser";
            this.c_addNewUser.Size = new System.Drawing.Size(80, 80);
            this.c_addNewUser.TabIndex = 0;
            this.c_addNewUser.UseVisualStyleBackColor = true;
            this.c_addNewUser.Click += new System.EventHandler(this.c_addNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UPS.WindowsForm.Properties.Resources.VerticalLine;
            this.pictureBox1.Location = new System.Drawing.Point(109, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // p_user_body
            // 
            this.p_user_body.Controls.Add(this.lv_userList);
            this.p_user_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_user_body.Location = new System.Drawing.Point(0, 120);
            this.p_user_body.Margin = new System.Windows.Forms.Padding(0);
            this.p_user_body.Name = "p_user_body";
            this.p_user_body.Size = new System.Drawing.Size(1264, 474);
            this.p_user_body.TabIndex = 2;
            // 
            // lv_userList
            // 
            this.lv_userList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_userList.AllowColumnReorder = true;
            this.lv_userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.UserId,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Gender,
            this.Status,
            this.CreationTime,
            this.lv_header_nothing});
            this.lv_userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_userList.FullRowSelect = true;
            this.lv_userList.GridLines = true;
            this.lv_userList.HideSelection = false;
            this.lv_userList.Location = new System.Drawing.Point(0, 0);
            this.lv_userList.MultiSelect = false;
            this.lv_userList.Name = "lv_userList";
            this.lv_userList.Size = new System.Drawing.Size(1264, 474);
            this.lv_userList.TabIndex = 0;
            this.lv_userList.UseCompatibleStateImageBehavior = false;
            this.lv_userList.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Tag = "Index";
            this.Index.Text = "";
            this.Index.Width = 20;
            // 
            // UserId
            // 
            this.UserId.Tag = "UserId";
            this.UserId.Text = "User Id";
            this.UserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstName
            // 
            this.FirstName.Tag = "FirstName";
            this.FirstName.Text = "First Name";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Width = 80;
            // 
            // LastName
            // 
            this.LastName.Tag = "LastName";
            this.LastName.Text = "Last Name";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 80;
            // 
            // Email
            // 
            this.Email.Tag = "Email";
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gender
            // 
            this.Gender.Tag = "Gender";
            this.Gender.Text = "Gender";
            this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status
            // 
            this.Status.Tag = "Status";
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreationTime
            // 
            this.CreationTime.Tag = "CreationTime";
            this.CreationTime.Text = "Creation Time";
            this.CreationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreationTime.Width = 90;
            // 
            // lv_header_nothing
            // 
            this.lv_header_nothing.Text = "";
            // 
            // p_user_footer
            // 
            this.p_user_footer.Controls.Add(this.tlp_userList_paging);
            this.p_user_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_user_footer.Location = new System.Drawing.Point(0, 594);
            this.p_user_footer.Margin = new System.Windows.Forms.Padding(0);
            this.p_user_footer.Name = "p_user_footer";
            this.p_user_footer.Size = new System.Drawing.Size(1264, 25);
            this.p_user_footer.TabIndex = 3;
            // 
            // tlp_userList_paging
            // 
            this.tlp_userList_paging.ColumnCount = 3;
            this.tlp_userList_paging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_userList_paging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_userList_paging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_userList_paging.Controls.Add(this.p_pageSize, 0, 0);
            this.tlp_userList_paging.Controls.Add(this.p_userList_pageNumber, 1, 0);
            this.tlp_userList_paging.Controls.Add(this.p_userList_totalCount, 2, 0);
            this.tlp_userList_paging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_userList_paging.Location = new System.Drawing.Point(0, 0);
            this.tlp_userList_paging.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_userList_paging.Name = "tlp_userList_paging";
            this.tlp_userList_paging.RowCount = 1;
            this.tlp_userList_paging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_userList_paging.Size = new System.Drawing.Size(1264, 25);
            this.tlp_userList_paging.TabIndex = 0;
            // 
            // p_pageSize
            // 
            this.p_pageSize.Controls.Add(this.l_totalPageCounts);
            this.p_pageSize.Controls.Add(this.label1);
            this.p_pageSize.Controls.Add(this.l_totalPages);
            this.p_pageSize.Controls.Add(this.cb_pageSize);
            this.p_pageSize.Controls.Add(this.l_pageSize);
            this.p_pageSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_pageSize.Location = new System.Drawing.Point(0, 0);
            this.p_pageSize.Margin = new System.Windows.Forms.Padding(0);
            this.p_pageSize.Name = "p_pageSize";
            this.p_pageSize.Size = new System.Drawing.Size(252, 25);
            this.p_pageSize.TabIndex = 0;
            // 
            // l_totalPageCounts
            // 
            this.l_totalPageCounts.AutoSize = true;
            this.l_totalPageCounts.ForeColor = System.Drawing.Color.Black;
            this.l_totalPageCounts.Location = new System.Drawing.Point(206, 5);
            this.l_totalPageCounts.Name = "l_totalPageCounts";
            this.l_totalPageCounts.Size = new System.Drawing.Size(0, 15);
            this.l_totalPageCounts.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // l_totalPages
            // 
            this.l_totalPages.AutoSize = true;
            this.l_totalPages.ForeColor = System.Drawing.Color.Black;
            this.l_totalPages.Location = new System.Drawing.Point(135, 5);
            this.l_totalPages.Name = "l_totalPages";
            this.l_totalPages.Size = new System.Drawing.Size(72, 15);
            this.l_totalPages.TabIndex = 2;
            this.l_totalPages.Text = "Total Pages: ";
            // 
            // cb_pageSize
            // 
            this.cb_pageSize.FormattingEnabled = true;
            this.cb_pageSize.ItemHeight = 15;
            this.cb_pageSize.Location = new System.Drawing.Point(73, 2);
            this.cb_pageSize.Name = "cb_pageSize";
            this.cb_pageSize.Size = new System.Drawing.Size(44, 23);
            this.cb_pageSize.TabIndex = 1;
            // 
            // l_pageSize
            // 
            this.l_pageSize.AutoSize = true;
            this.l_pageSize.ForeColor = System.Drawing.Color.Black;
            this.l_pageSize.Location = new System.Drawing.Point(10, 5);
            this.l_pageSize.Name = "l_pageSize";
            this.l_pageSize.Size = new System.Drawing.Size(59, 15);
            this.l_pageSize.TabIndex = 0;
            this.l_pageSize.Text = "Page Size:";
            // 
            // p_userList_pageNumber
            // 
            this.p_userList_pageNumber.Controls.Add(this.tlp_userList_footer_pageNumber);
            this.p_userList_pageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_userList_pageNumber.Location = new System.Drawing.Point(252, 0);
            this.p_userList_pageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.p_userList_pageNumber.Name = "p_userList_pageNumber";
            this.p_userList_pageNumber.Size = new System.Drawing.Size(758, 25);
            this.p_userList_pageNumber.TabIndex = 1;
            // 
            // tlp_userList_footer_pageNumber
            // 
            this.tlp_userList_footer_pageNumber.ColumnCount = 3;
            this.tlp_userList_footer_pageNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_userList_footer_pageNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_userList_footer_pageNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_userList_footer_pageNumber.Controls.Add(this.p_userList_footer_pageNumber, 1, 0);
            this.tlp_userList_footer_pageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_userList_footer_pageNumber.Location = new System.Drawing.Point(0, 0);
            this.tlp_userList_footer_pageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_userList_footer_pageNumber.Name = "tlp_userList_footer_pageNumber";
            this.tlp_userList_footer_pageNumber.RowCount = 1;
            this.tlp_userList_footer_pageNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_userList_footer_pageNumber.Size = new System.Drawing.Size(758, 25);
            this.tlp_userList_footer_pageNumber.TabIndex = 0;
            // 
            // p_userList_footer_pageNumber
            // 
            this.p_userList_footer_pageNumber.Controls.Add(this.b_previousPage);
            this.p_userList_footer_pageNumber.Controls.Add(this.b_nextPage);
            this.p_userList_footer_pageNumber.Controls.Add(this.tb_pageNumber);
            this.p_userList_footer_pageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_userList_footer_pageNumber.Location = new System.Drawing.Point(252, 0);
            this.p_userList_footer_pageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.p_userList_footer_pageNumber.MinimumSize = new System.Drawing.Size(252, 0);
            this.p_userList_footer_pageNumber.Name = "p_userList_footer_pageNumber";
            this.p_userList_footer_pageNumber.Size = new System.Drawing.Size(252, 25);
            this.p_userList_footer_pageNumber.TabIndex = 0;
            // 
            // b_previousPage
            // 
            this.b_previousPage.ForeColor = System.Drawing.Color.Black;
            this.b_previousPage.Location = new System.Drawing.Point(0, 1);
            this.b_previousPage.Margin = new System.Windows.Forms.Padding(0);
            this.b_previousPage.Name = "b_previousPage";
            this.b_previousPage.Size = new System.Drawing.Size(89, 23);
            this.b_previousPage.TabIndex = 5;
            this.b_previousPage.Text = "Previous Page";
            this.b_previousPage.UseVisualStyleBackColor = true;
            this.b_previousPage.Click += new System.EventHandler(this.b_previousPage_Click);
            // 
            // b_nextPage
            // 
            this.b_nextPage.ForeColor = System.Drawing.Color.Black;
            this.b_nextPage.Location = new System.Drawing.Point(163, 1);
            this.b_nextPage.Name = "b_nextPage";
            this.b_nextPage.Size = new System.Drawing.Size(89, 23);
            this.b_nextPage.TabIndex = 4;
            this.b_nextPage.Text = "Next Page";
            this.b_nextPage.UseVisualStyleBackColor = true;
            this.b_nextPage.Click += new System.EventHandler(this.b_nextPage_Click);
            // 
            // tb_pageNumber
            // 
            this.tb_pageNumber.Location = new System.Drawing.Point(104, 1);
            this.tb_pageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tb_pageNumber.Name = "tb_pageNumber";
            this.tb_pageNumber.Size = new System.Drawing.Size(44, 23);
            this.tb_pageNumber.TabIndex = 3;
            this.tb_pageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_userList_totalCount
            // 
            this.p_userList_totalCount.Controls.Add(this.l_total);
            this.p_userList_totalCount.Controls.Add(this.l_totalText);
            this.p_userList_totalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_userList_totalCount.Location = new System.Drawing.Point(1010, 0);
            this.p_userList_totalCount.Margin = new System.Windows.Forms.Padding(0);
            this.p_userList_totalCount.Name = "p_userList_totalCount";
            this.p_userList_totalCount.Size = new System.Drawing.Size(254, 25);
            this.p_userList_totalCount.TabIndex = 2;
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.ForeColor = System.Drawing.Color.Black;
            this.l_total.Location = new System.Drawing.Point(83, 4);
            this.l_total.Margin = new System.Windows.Forms.Padding(3);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(0, 15);
            this.l_total.TabIndex = 1;
            // 
            // l_totalText
            // 
            this.l_totalText.AutoSize = true;
            this.l_totalText.ForeColor = System.Drawing.Color.Black;
            this.l_totalText.Location = new System.Drawing.Point(0, 5);
            this.l_totalText.Margin = new System.Windows.Forms.Padding(5);
            this.l_totalText.Name = "l_totalText";
            this.l_totalText.Size = new System.Drawing.Size(83, 15);
            this.l_totalText.TabIndex = 0;
            this.l_totalText.Text = "Total Records: ";
            // 
            // tp_configuration
            // 
            this.tp_configuration.Controls.Add(this.tb_apiToken);
            this.tp_configuration.Controls.Add(this.l__ApiToken);
            this.tp_configuration.Controls.Add(this.b_saveConfiguration);
            this.tp_configuration.Controls.Add(this.tb_apiAddress);
            this.tp_configuration.Controls.Add(this.l_apiUrl);
            this.tp_configuration.Location = new System.Drawing.Point(4, 24);
            this.tp_configuration.Name = "tp_configuration";
            this.tp_configuration.Padding = new System.Windows.Forms.Padding(3);
            this.tp_configuration.Size = new System.Drawing.Size(1270, 625);
            this.tp_configuration.TabIndex = 2;
            this.tp_configuration.Text = "Configuration";
            this.tp_configuration.UseVisualStyleBackColor = true;
            // 
            // tb_apiToken
            // 
            this.tb_apiToken.Location = new System.Drawing.Point(109, 61);
            this.tb_apiToken.Name = "tb_apiToken";
            this.tb_apiToken.Size = new System.Drawing.Size(625, 23);
            this.tb_apiToken.TabIndex = 4;
            // 
            // l__ApiToken
            // 
            this.l__ApiToken.AutoSize = true;
            this.l__ApiToken.ForeColor = System.Drawing.Color.Black;
            this.l__ApiToken.Location = new System.Drawing.Point(34, 64);
            this.l__ApiToken.Name = "l__ApiToken";
            this.l__ApiToken.Size = new System.Drawing.Size(65, 15);
            this.l__ApiToken.TabIndex = 3;
            this.l__ApiToken.Text = "Api Token: ";
            // 
            // b_saveConfiguration
            // 
            this.b_saveConfiguration.ForeColor = System.Drawing.Color.Black;
            this.b_saveConfiguration.Location = new System.Drawing.Point(760, 32);
            this.b_saveConfiguration.Name = "b_saveConfiguration";
            this.b_saveConfiguration.Size = new System.Drawing.Size(99, 31);
            this.b_saveConfiguration.TabIndex = 2;
            this.b_saveConfiguration.Text = "Save";
            this.b_saveConfiguration.UseVisualStyleBackColor = true;
            this.b_saveConfiguration.Click += new System.EventHandler(this.b_saveConfiguration_Click);
            // 
            // tb_apiAddress
            // 
            this.tb_apiAddress.Location = new System.Drawing.Point(109, 32);
            this.tb_apiAddress.Name = "tb_apiAddress";
            this.tb_apiAddress.Size = new System.Drawing.Size(625, 23);
            this.tb_apiAddress.TabIndex = 1;
            // 
            // l_apiUrl
            // 
            this.l_apiUrl.AutoSize = true;
            this.l_apiUrl.ForeColor = System.Drawing.Color.Black;
            this.l_apiUrl.Location = new System.Drawing.Point(34, 35);
            this.l_apiUrl.Name = "l_apiUrl";
            this.l_apiUrl.Size = new System.Drawing.Size(69, 15);
            this.l_apiUrl.TabIndex = 0;
            this.l_apiUrl.Text = "Api Adress: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "DesktopApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.p_bodyBase.ResumeLayout(false);
            this.tc_main.ResumeLayout(false);
            this.tp_users.ResumeLayout(false);
            this.tlp_users_body.ResumeLayout(false);
            this.p_user_header.ResumeLayout(false);
            this.p_user_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_user_body.ResumeLayout(false);
            this.p_user_footer.ResumeLayout(false);
            this.tlp_userList_paging.ResumeLayout(false);
            this.p_pageSize.ResumeLayout(false);
            this.p_pageSize.PerformLayout();
            this.p_userList_pageNumber.ResumeLayout(false);
            this.tlp_userList_footer_pageNumber.ResumeLayout(false);
            this.p_userList_footer_pageNumber.ResumeLayout(false);
            this.p_userList_footer_pageNumber.PerformLayout();
            this.p_userList_totalCount.ResumeLayout(false);
            this.p_userList_totalCount.PerformLayout();
            this.tp_configuration.ResumeLayout(false);
            this.tp_configuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_users;
        private System.Windows.Forms.TableLayoutPanel tlp_users_body;
        private System.Windows.Forms.Button c_addNewUser;
        private System.Windows.Forms.TabPage tp_configuration;
        private System.Windows.Forms.Panel p_user_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_newUser;
        private System.Windows.Forms.Panel p_user_body;
        private System.Windows.Forms.Panel p_user_footer;
        private System.Windows.Forms.ListView lv_userList;
        private System.Windows.Forms.TextBox tb_apiAddress;
        private System.Windows.Forms.Label l_apiUrl;
        private System.Windows.Forms.Button b_searchUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label l_editUser;
        private System.Windows.Forms.Button b_editUser;
        private System.Windows.Forms.Label l_removeUser;
        private System.Windows.Forms.Button b_removeUser;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader UserId;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader CreationTime;
        private System.Windows.Forms.TableLayoutPanel tlp_userList_paging;
        private System.Windows.Forms.Panel p_pageSize;
        private System.Windows.Forms.ComboBox cb_pageSize;
        private System.Windows.Forms.Label l_pageSize;
        private System.Windows.Forms.Panel p_userList_pageNumber;
        private System.Windows.Forms.Panel p_userList_totalCount;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Label l_totalText;
        private System.Windows.Forms.TableLayoutPanel tlp_userList_footer_pageNumber;
        private System.Windows.Forms.Panel p_userList_footer_pageNumber;
        private System.Windows.Forms.Button b_nextPage;
        private System.Windows.Forms.TextBox tb_pageNumber;
        private System.Windows.Forms.Button b_previousPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_totalPages;
        private System.Windows.Forms.Label l_totalPageCounts;
        private System.Windows.Forms.Label l__toDate;
        private System.Windows.Forms.Label l__fromDate;
        private System.Windows.Forms.Label l__status;
        private System.Windows.Forms.Label l__gender;
        private System.Windows.Forms.ComboBox cb_searchGender;
        private System.Windows.Forms.Label l__email;
        private System.Windows.Forms.Label l__lastName;
        private System.Windows.Forms.Label l__firstName;
        private System.Windows.Forms.ComboBox cb_searrch_status;
        private System.Windows.Forms.TextBox tb_search_email;
        private System.Windows.Forms.TextBox tb_search_lastName;
        private System.Windows.Forms.TextBox tb_search_firstName;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtp_search_fromDate;
        private System.Windows.Forms.DateTimePicker dtp_search_toDate;
        private System.Windows.Forms.Button b_exportCSV;
        private System.Windows.Forms.Button b_saveConfiguration;
        private System.Windows.Forms.TextBox tb_apiToken;
        private System.Windows.Forms.Label l__ApiToken;
        private System.Windows.Forms.ColumnHeader lv_header_nothing;
    }
}