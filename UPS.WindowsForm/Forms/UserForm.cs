using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPS.WindowsForm.Models;
using UPS.WindowsForm.Models.Enums;
using UPS.WindowsForm.Services;

namespace UPS.WindowsForm.Forms
{
    public partial class UserForm : TemplateForm
    {
        //************************************************************************************************************************************
        //Variables:
        private readonly ActionTypeEnum _actionType;
        private readonly long? _userId;
        public delegate Task AfterAction();
        public event AfterAction AfterActions;
        //************************************************************************************************************************************
        public UserForm(ActionTypeEnum actionType, long? userId = null) : base(new Size(800, 600))
        {
            _userId = userId;
            _actionType = actionType;
            InitializeComponent();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Set defualt vlaues.
        /// </summary>
        /// <returns></returns>
        private async Task Configuration()
        {
            var genderList = ConfigurationService.GetInstance().GetGenderList();
            cb_gender.Items.AddRange(genderList.ToArray());
            cb_gender.DisplayMember = "Text";
            cb_gender.ValueMember = "Value";

            var statusList = ConfigurationService.GetInstance().GetStatusList();
            cb_status.Items.AddRange(statusList.ToArray());
            cb_status.DisplayMember = "Text";
            cb_status.ValueMember = "Value";

            if (_actionType == ActionTypeEnum.Add)
            {
                l_userId.Visible = false;
                tb_userId.Visible = false;
                b_userSave.Text = "Add User";
                cb_gender.SelectedItem = genderList.FirstOrDefault();
                cb_status.SelectedItem = statusList.FirstOrDefault();
            }
            else if (_actionType == ActionTypeEnum.Update)
            {
                l_userId.Visible = true;
                tb_userId.Visible = true;
                b_userSave.Text = "Update User";
                tb_userId.Text = _userId.ToString();
                User user = await UserService.GetUserAsync((long)_userId);
                tb_email.Text = user.Email;
                tb_firstName.Text = user.FirstName;
                tb_lastName.Text = user.LastName;
                cb_gender.SelectedItem = genderList.FirstOrDefault(x => x.Value == Enum.Parse<GenderEnum>(user.Gender));
                cb_status.SelectedItem = statusList.FirstOrDefault(x => x.Value == Enum.Parse<StatusEnum>(user.Status));
            }
            else
            {
                throw new NotImplementedException();
            }

        }
        //************************************************************************************************************************************
        /// <summary>
        /// OnLoad event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UserForm_Load(object sender, EventArgs e)
        {
            await Configuration();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Save changes button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void b_userSave_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser
            {
                Email = tb_email.Text,
                FirstName = tb_firstName.Text,
                LastName = tb_lastName.Text,
                Gender = ((PairValue<GenderEnum>)cb_gender.SelectedItem).Value.ToString(),
                Status = ((PairValue<StatusEnum>)cb_status.SelectedItem).Value.ToString()
            };
            if (_actionType == ActionTypeEnum.Add)
            {
                await UserService.CreateNewUserAsync(register);
            }
            else if (_actionType == ActionTypeEnum.Update)
            {
                await UserService.UpdateUserAsync((long)_userId, register);
            }
            else
            {
                throw new NotImplementedException();
            }
            await CloseFormAsync();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Close form.
        /// </summary>
        /// <returns></returns>
        private async Task CloseFormAsync()
        {
            await AfterActions();
            this.Close();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //************************************************************************************************************************************
    }
}
