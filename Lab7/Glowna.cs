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
    public partial class Glowna : Form
    {
        public Glowna()
        {
            InitializeComponent();
        }

        private void zaloguj(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            this.Hide();
            logowanie.ShowDialog(); 
            PoZalogowaniu pz = new PoZalogowaniu();
            pz.ShowDialog();

        }

        private void zarejestruj(object sender, EventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            this.Hide();
            rejestracja.ShowDialog();
            Logowanie logowanie2 = new Logowanie();
            logowanie2.ShowDialog();
        }
    }
}
