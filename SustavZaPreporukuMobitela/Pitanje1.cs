using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SustavZaPreporukuMobitela
{
    public partial class Pitanje1 : UserControl
    {
        public Pitanje1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPocetna fp = new FormPocetna();
            fp.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje2 p = new Pitanje2();
            this.Parent.Controls.Add(p);
        }

        private void Pitanje1_Load(object sender, EventArgs e)
        {

        }
    }
}
