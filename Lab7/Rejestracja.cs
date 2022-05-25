using Lab7.Rozne_male;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Rejestracja : Form
    {
        LogReg lg;
        public Rejestracja()
        {
            InitializeComponent();
            lg = new LogReg();
            
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_gotowe_Click(object sender, EventArgs e)
        {
            lg.rejestracja(tb_username.Text, tb_password.Text);
            this.Hide();
        }
    }
}
