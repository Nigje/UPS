using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPS.WindowsForm.Models.Enums;

namespace UPS.WindowsForm.Forms
{
    public partial class MessageForm : TemplateForm
    {
        private readonly string _message;
        private readonly MessageTypeEnum _messageType;
        public MessageForm(MessageTypeEnum messageType, string message = "") : base(messageType.ToString())
        {
            _message = message;
            _messageType = messageType;
            InitializeComponent();
            l_message.Text = _message;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
