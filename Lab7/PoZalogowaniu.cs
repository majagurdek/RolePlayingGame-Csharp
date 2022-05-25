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
    public partial class PoZalogowaniu : Form
    {
        
        public PoZalogowaniu()
        {
            InitializeComponent();
            
        }

        private void bt_dodajpostac_Click(object sender, EventArgs e)
        {
            DodajPostac dp = new DodajPostac();
            dp.ShowDialog();
        }

        private void bt_usunpostac_Click(object sender, EventArgs e)
        {
            UsunPostac up = new UsunPostac();
            up.ShowDialog();
        }

        private void bt_przegladaj_Click(object sender, EventArgs e)
        {
            PrzegladajPostacie pp = new PrzegladajPostacie();
            pp.ShowDialog();

        }

        private void bt_ranking_Click(object sender, EventArgs e)
        {
            PrzegladajRanking pr = new PrzegladajRanking();
            pr.ShowDialog();
        }
    }
}
