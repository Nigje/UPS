
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPS.WindowsForm.Models;
using UPS.WindowsForm.Models.Enums;
using UPS.WindowsForm.Services;
using static System.Windows.Forms.ListViewItem;

namespace UPS.WindowsForm.Forms
{
    public partial class MainForm : TemplateForm
    {
        //************************************************************************************************************************************
        //Variables:
        //************************************************************************************************************************************
        public MainForm() : base(new Size(1280, 720), "")
        {
            InitializeComponent();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Add new user button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void c_addNewUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(ActionTypeEnum.Add);
            userForm.AfterActions += async () => await SearchAsync();
            userForm.Show();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Search user button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_searchUser_Click(object sender, EventArgs e)
        {
            await SearchAsync();

        }
        //************************************************************************************************************************************
        /// <summary>
        /// Search users.
        /// </summary>
        /// <returns></returns>
        private async Task SearchAsync()
        {
            UserQuery userQuery = GetUserQuery();
            int currentPageSize = int.Parse(cb_pageSize.Text);
            int pageNumber = 1;
            userQuery.PageNumber = pageNumber;
            userQuery.PageSize = currentPageSize;

            await BindDataToListViewAsync(userQuery);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Next page result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_nextPage_Click(object sender, EventArgs e)
        {
            UserQuery userQuery = GetUserQuery();
            int currentPageSize = int.Parse(cb_pageSize.Text);
            int pageNumber = int.Parse(tb_pageNumber.Text);
            pageNumber++;
            userQuery.PageSize = currentPageSize;
            userQuery.PageNumber = pageNumber;
            await BindDataToListViewAsync(userQuery);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Fetch user list and asign to listview.
        /// </summary>
        /// <param name="userQuery"></param>
        /// <returns></returns>
        private async Task BindDataToListViewAsync(UserQuery userQuery)
        {
            PagedUsers users = await UserService.GetUsersAsync(userQuery);
            l_totalPageCounts.Text = "";
            int counter = 1;
            lv_userList.Items.Clear();
            foreach (var item in users.Items)
            {
                ListViewItem lvi = new ListViewItem(counter++.ToString());
                lvi.SubItems.Add(new ListViewSubItem { Name = "UserId", Tag = "UserId", Text = item.Id.ToString() });
                lvi.SubItems.Add(new ListViewSubItem { Name = "FirstName", Tag = "FirstName", Text = item.FirstName });
                lvi.SubItems.Add(new ListViewSubItem { Name = "LastName", Tag = "LastName", Text = item.LastName });
                lvi.SubItems.Add(new ListViewSubItem { Name = "Email", Tag = "Email", Text = item.Email });
                lvi.SubItems.Add(new ListViewSubItem { Name = "Gender", Tag = "Gender", Text = item.Gender });
                lvi.SubItems.Add(new ListViewSubItem { Name = "Status", Tag = "Status", Text = item.Status });
                lvi.SubItems.Add(new ListViewSubItem { Name = "CreationTime", Tag = "CreationTime", Text = item.CreationTime.ToString() });
                lvi.SubItems.Add(new ListViewSubItem { Name = "", Tag = "", Text = "" });
                lv_userList.Items.Add(lvi);
            }
            for (int i = 0; i < 8; i++)
            {
                lv_userList.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                lv_userList.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            l_total.Text = users.TotalCount.ToString();
            int totalPageCounts = users.TotalCount / (int)userQuery.PageSize;
            if ((users.TotalCount % userQuery.PageSize) > 0) totalPageCounts++;
            if (totalPageCounts != 0)
                l_totalPageCounts.Text = totalPageCounts.ToString();
            tb_pageNumber.Text = users.PageNumber.ToString();
        }

        //************************************************************************************************************************************
        /// <summary>
        /// Remove user button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_removeUser_Click(object sender, EventArgs e)
        {
            if (lv_userList.SelectedItems.Count == 0)
            {
                throw new BusinessException("Please select a user.");
            }
            long userId = long.Parse(lv_userList.SelectedItems[0].SubItems["UserId"].Text);
            await UserService.DeleteUserAsync(userId);
            await SearchAsync();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Onload event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {

            List<string> pagesizes = new List<string>() { "10", "20", "50", "100" };
            cb_pageSize.Items.AddRange(pagesizes.ToArray());
            cb_pageSize.SelectedItem = pagesizes.FirstOrDefault(x => x == "20");

            cb_searrch_status.Items.AddRange(ConfigurationService.GetInstance().GetStatusList().ToArray());
            cb_searchGender.Items.AddRange(ConfigurationService.GetInstance().GetGenderList().ToArray());
            cb_searrch_status.DisplayMember = "Text";
            cb_searrch_status.ValueMember = "Value";
            cb_searchGender.DisplayMember = "Text";
            cb_searchGender.ValueMember = "Value";
            dtp_search_fromDate.Value = DateTime.Now.AddMonths(-1);

            tb_apiAddress.Text = ConfigurationService.GetInstance().Get("BaseUrl");
            tb_apiToken.Text = ConfigurationService.GetInstance().Get("Authorization");

            await SearchAsync();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Get user query.
        /// </summary>
        /// <returns></returns>
        private UserQuery GetUserQuery()
        {
            UserQuery userQuery = new UserQuery();

            if (!string.IsNullOrEmpty(tb_search_firstName.Text))
                userQuery.FirstName = tb_search_firstName.Text;

            if (!string.IsNullOrEmpty(tb_search_lastName.Text))
                userQuery.LastName = tb_search_lastName.Text;

            if (!string.IsNullOrEmpty(tb_search_email.Text))
                userQuery.Email = tb_search_email.Text;

            if (cb_searchGender.SelectedItem != null)
                userQuery.Gender = ((PairValue<GenderEnum>)cb_searchGender.SelectedItem).Value.ToString();

            if (cb_searrch_status.SelectedItem != null)
                userQuery.Status = ((PairValue<StatusEnum>)cb_searrch_status.SelectedItem).Value.ToString();

            userQuery.FromDate = dtp_search_fromDate.Value;
            userQuery.ToDate = dtp_search_toDate.Value;

            return userQuery;
        }


        //************************************************************************************************************************************
        /// <summary>
        /// Save configuration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_saveConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationService.GetInstance().Set("BaseUrl", tb_apiAddress.Text);
            ConfigurationService.GetInstance().Set("Authorization", tb_apiToken.Text);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Edit user button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_editUser_Click(object sender, EventArgs e)
        {
            if (lv_userList.SelectedItems.Count == 0)
            {
                throw new BusinessException("Please select a user.");
            }
            long userId = long.Parse(lv_userList.SelectedItems[0].SubItems["UserId"].Text);
            UserForm userForm = new UserForm(ActionTypeEnum.Update, userId);
            userForm.AfterActions += async () => await SearchAsync();
            userForm.Show();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Export csv file button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_exportCSV_Click(object sender, EventArgs e)
        {
            UserQuery userQuery = GetUserQuery();
            userQuery.PageNumber = 1;
            userQuery.PageSize = int.MaxValue;
            string csv = await UserService.GetUsersCsvAsync(userQuery);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file(*.csv)| *.csv";
            saveFileDialog.ShowDialog();
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                await File.WriteAllTextAsync(saveFileDialog.FileName, csv);
            }
            else
            {
                throw new BusinessException("Invalid file path.");
            }

        }
        //************************************************************************************************************************************
        /// <summary>
        /// Previous page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_previousPage_Click(object sender, EventArgs e)
        {
            UserQuery userQuery = GetUserQuery();
            int currentPageSize = int.Parse(cb_pageSize.Text);
            int pageNumber = int.Parse(tb_pageNumber.Text);
            if (--pageNumber <= 0)
                pageNumber = 1;
            userQuery.PageSize = currentPageSize;
            userQuery.PageNumber = pageNumber;
            await BindDataToListViewAsync(userQuery);
        }

        //************************************************************************************************************************************
    }
}
