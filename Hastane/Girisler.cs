using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            HastaGiris fr = new HastaGiris();
            fr.Show();
            this.Hide();

        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            DoktorGiris fr = new DoktorGiris();
            fr.Show();
            this.Hide();

        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            SekreterGiris fr = new SekreterGiris();
            fr.Show();
            this.Hide();

        }
    }
}
