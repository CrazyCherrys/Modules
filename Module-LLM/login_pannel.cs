using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_LLM
{
    public partial class loginin_pannel : Form
    {
        public loginin_pannel()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string passwd = passwd_text.Text;

            if (username == "123" && passwd == "456")
            {
                MessageBox.Show("you have login");
                calculate_pannel calform = new calculate_pannel();
                this.Hide();
                calform.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("login fail");
            }
        }
    }
}
