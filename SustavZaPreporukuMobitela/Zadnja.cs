using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SustavZaPreporukuMobitela
{
    public partial class Zadnja : UserControl
    {
        Mobitel mob1 = null;
        Mobitel mob2 = null;
        Mobitel mob3 = null;

        public Zadnja()
        {
            InitializeComponent();
        }

        private void prikaziData()
        {

            System.Threading.Thread.Sleep(3000);
            mob1 = BazaOdgovora.dajMobitel("Acer CloudMobile S500");
            pictureBox_mob1.Load(mob1.img_url);
            
        }
        private void btn_preporuci_Click(object sender, EventArgs e)
        {

            this.btn_preporuci.Hide();
            using (ZadLoadingForm zlf = new ZadLoadingForm(prikaziData))
                zlf.ShowDialog();
            lblNazivMobitela1.Show();
            lblNazivMobitela1.Text = mob1.model;
            lblNazivMobitela2.Show();
            lblNazivMobitela3.Show();
            btn_spec1.Show();
            btn_spec2.Show();
            btn_spec3.Show();
        }

        private void btn_spec1_Click(object sender, EventArgs e)
        {
            Mobitel mob = BazaOdgovora.dajMobitel("Acer CloudMobile S500");
            if (mob != null)
            {
                Specifikacije frmSpec = new Specifikacije(mob);
                frmSpec.Show();
            }
        }

        private void Zadnja_Load(object sender, EventArgs e)
        {
            this.lblNazivMobitela1.Hide();
            this.lblNazivMobitela2.Hide();
            this.lblNazivMobitela3.Hide();
            this.btn_spec1.Hide();
            this.btn_spec2.Hide();
            this.btn_spec3.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
