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
        public Zadnja()
        {
            InitializeComponent();
        }

        private void btn_preporuci_Click(object sender, EventArgs e)
        {
            String tekst = "";
            foreach(String item in BazaOdgovora.brand)
            {
                tekst = tekst + item+"; ";
            }
            MessageBox.Show("brand " + tekst + "\n" +
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
    }
}
