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
    public partial class Logowanie : Form
    {
        LogReg l;
        public Logowanie()
        {
            InitializeComponent();
            l = new LogReg();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_gotowe_Click(object sender, EventArgs e)
        {
            l.logowanie(tb_name.Text, tb_password.Text);
            this.Hide();
        }
    }
}
