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
    public partial class FormPocetna : Form
    {

        public FormPocetna()
        {
            InitializeComponent();
            pitanje11.Hide();
            pitanje21.Hide();
            pitanje31.Hide();
            pitanje41.Hide();

        }

        private void BtnPocetak_Click(object sender, EventArgs e)
        {
            panelPocetna.Hide();
            pitanje11.Show();
            pitanje11.BringToFront();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
