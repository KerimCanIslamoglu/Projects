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

namespace AcibademProje.Formlar
{
    public partial class frmHastaBul : Form
    {
        AcibademDataContext _db = new AcibademDataContext();

        public bool Secim = false;

        int _secimId = -1;

        public frmHastaBul()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblHastaBilgileris
                       where s.HastaAdi.Contains(txtHadiAra.Text) && s.ProtokolNo.Contains(txtProNoAra.Text)
                       select s).OrderBy(x => x.ID).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.HastaAdi;
                Liste.Rows[i].Cells[2].Value = k.ProtokolNo;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }

        //private void txtHadiAra_TextChanged(object sender, EventArgs e)
        //{
        //    Listele();
        //}

        //private void txtProNoAra_TextChanged(object sender, EventArgs e)
        //{
        //    Listele();
        //}

        private void frmHastaBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && _secimId > 0)
            {
                frmAnaSayfa.Aktarma = _secimId;
                Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //Listele();
        }

        private void txtHadiAra_TextChanged(object sender, EventArgs e)
        {
            Listele();

        }

        private void txtProNoAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
