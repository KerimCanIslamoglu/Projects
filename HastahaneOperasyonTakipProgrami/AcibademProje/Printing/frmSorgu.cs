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

namespace AcibademProje.Printing
{
    public partial class frmSorgu : Form
    {
        AcibademDataContext _db = new AcibademDataContext();
      
        Mesajlar _m = new Mesajlar();
        public bool Secim = false;
        
        public frmSorgu()
        {
            InitializeComponent();
        }

        private void frmSorgu_Load(object sender, EventArgs e)
        {
            Combo();
            cbPatt.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        void Combo()
        {
            var patlstt = (from s in _db.tblPatolojis
                           select new
                           {
                               s.Patoloji
                           }).Distinct();

            foreach (var k in patlstt)
            {
                cbPatt.Items.Add(k.Patoloji);
            }
        }
        void Listele()
        {
            Liste.Rows.Clear();
            if (txtTumMin.Text=="")
            {
                txtTumMin.Text = "0";
            }
            if (txtTumMax.Text=="")
            {
                txtTumMax.Text = "999999";
            }
            if (txtKanMin.Text=="")
            {
                txtKanMin.Text = "0";
            }
            if (txtKanMax.Text=="")
            {
                txtKanMax.Text = "9999999";
            }
            int i = 0;
            int tummin = int.Parse(txtTumMin.Text);
            int tummax = int.Parse(txtTumMax.Text);
            int kanmin = int.Parse(txtKanMin.Text);
            int kanmax = int.Parse(txtKanMax.Text);

            var lst = (from s in _db.tblDemografiks where s.Boyut <= tummax && s.Boyut >= tummin select s.HastaID).ToList();
            foreach (var k in lst)
            {
                var lstt = (from a in _db.tblOperatifOzelliklers where a.HastaID == k && a.Kanama <= kanmax && a.Kanama >= kanmin select a.HastaID).ToList();
                foreach (var y in lstt)
                {
                    var lsttt = (from b in _db.tblPatolojikVerilers where b.HastaID == y && b.Patoloji == cbPatt.Text select b.HastaID).ToList();
                    foreach (var t in lsttt)
                    {
                        var lstttt = (from c in _db.tblOperatifOzelliklers where c.HastaID == t && c.PKSAciklama == comboBox2.Text select c.HastaID).ToList();
                        foreach (var z in lstttt)
                        {
                            Liste.Rows.Add();
                            Liste.Rows[i].Cells[0].Value = _db.tblHastaBilgileris.First(x => x.ID == z).ID;
                            Liste.Rows[i].Cells[1].Value = _db.tblHastaBilgileris.First(x => x.ID == z).ProtokolNo;
                            Liste.Rows[i].Cells[2].Value = _db.tblHastaBilgileris.First(x => x.ID == z).HastaAdi;
                            Liste.Rows[i].Cells[3].Value = _db.tblHastaBilgileris.First(x => x.ID == z).HastaSoyadi;
                            Liste.Rows[i].Cells[4].Value = _db.tblHastaBilgileris.First(x => x.ID == z).OperasyonTarihi;
                            Liste.Rows[i].Cells[5].Value = _db.tblDemografiks.First(x => x.HastaID == z).Boyut;
                            Liste.Rows[i].Cells[6].Value = _db.tblOperatifOzelliklers.First(x => x.HastaID == z).Kanama;
                            Liste.Rows[i].Cells[7].Value = _db.tblPatolojikVerilers.First(x => x.HastaID == z).Patoloji;
                            Liste.Rows[i].Cells[8].Value = _db.tblOperatifOzelliklers.First(x => x.HastaID == z).PKSAciklama;
                            i++;
                        }
                    }
                }
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
