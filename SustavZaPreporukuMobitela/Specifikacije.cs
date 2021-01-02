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
    public partial class Specifikacije : Form
    {
        Mobitel mobitel;
        public Specifikacije(Mobitel mob)
        {
            InitializeComponent();
            mobitel = mob;
            prikaziSpecifikacije(mobitel);
        }

        private void prikaziSpecifikacije(Mobitel mobitel)
        {
            lab_key.Text = mobitel.primary_camera;
        }

    }
}
