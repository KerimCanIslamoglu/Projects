using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcibademProje.Model;


namespace AcibademProje
{
    public partial class frmAnaSayfa : Form
    {
        AcibademDataContext _db = new AcibademDataContext();

        Model.Formlar _f = new Model.Formlar();

        public static int opAktarma;
        public static int Aktarma;
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            _f.HastaGiris();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btndrkoopgiris_Click(object sender, EventArgs e)
        {
            _f.drkoopGiris();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            _f.SorguList();
        }
    }
}
