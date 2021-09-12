using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPS.WindowsForm.Forms
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            
        }
        private void CloseCurrentForm(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HideCurrentForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadForm_Shown(object sender, EventArgs e)
        {
            Program.MainForm = new MainForm();
            Program.MainForm.Shown += HideCurrentForm;
            Program.MainForm.FormClosed += CloseCurrentForm;
            Program.MainForm.Show();
        }
    }
}
