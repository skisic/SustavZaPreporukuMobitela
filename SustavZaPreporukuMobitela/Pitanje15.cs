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
    public partial class Pitanje15 : UserControl
    {
        public Pitanje15()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje14 p = new Pitanje14();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        MessageBox.Show("brand "+BazaOdgovora.brand+"\n"+
            "budzet " + BazaOdgovora.budzet + "\n" +
            "baterija " + BazaOdgovora.baterija + "\n" +
            "operacijskiSistem " + BazaOdgovora.operacijskiSistem + "\n" +
            "tezina " + BazaOdgovora.tezina + "\n" +
            "gps " + BazaOdgovora.gps + "\n" +
            "display " + BazaOdgovora.display + "\n" +
            "kamera " + BazaOdgovora.kamera + "\n" +
            "memorijskaKartica " + BazaOdgovora.memorijskaKartica + "\n" +
            "cpu " + BazaOdgovora.cpu + "\n" +
            "ram " + BazaOdgovora.ram + "\n" +
            "unutarnjaMemorija " + BazaOdgovora.unutarnjaMemorija + "\n" +
            "poboljsaniZvucnik " + BazaOdgovora.poboljsaniZvucnik + "\n" +
            "audioPrikljucak " + BazaOdgovora.audioPrikljucak + "\n" +
            "radio " + BazaOdgovora.radio + "\n" +
            "nfc " + BazaOdgovora.nfc + "\n" +
            "cetriG " + BazaOdgovora.cetriG + "\n" +
            "bluetooth " + BazaOdgovora.bluetooth + "\n" +
            "sim " + BazaOdgovora.sim + "\n" +
            "zaobljeniEkran " + BazaOdgovora.zaobljeniEkran + "\n" +
            "godina " + BazaOdgovora.godina + "\n"
            );
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(5, 171, 166);
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(5, 171, 166);
            btnNext.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void radioModelNovi_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.godina = 100;
            btnNext.Enabled = true;
        }

        private void radioModelStari_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.godina = 0;
            btnNext.Enabled = true;
        }

        private void radioModelSvejedno_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.godina = 50;
            btnNext.Enabled = true;
        }
    }
}
