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
    public partial class dr_ko_op_giris : Form
    {
        AcibademDataContext _db = new AcibademDataContext();
        Mesajlar _m = new Mesajlar();
        frmHastaGirisi _ff = new frmHastaGirisi();


        public bool Secim = false;
        bool _edit = false;
        int _opID = -1;
        int _koID = -1;
        int _drID = -1;

        int _opsilID = -1;

        string a, b, c;

        public dr_ko_op_giris()
        {
            InitializeComponent();
        }

        private void dr_ko_op_giris_Load(object sender, EventArgs e)
        {
            OPListele();
            KOListele();
            DRListele();
        }
        void OPListele()
        {
            dgvOpTur.Rows.Clear();
            int i = 0;

            var lst = _db.tblOperasyonTurus.ToList();
            foreach (var k in lst)
            {
                dgvOpTur.Rows.Add();
                dgvOpTur.Rows[i].Cells[0].Value = k.ID;
                dgvOpTur.Rows[i].Cells[1].Value = k.OperasyonTuru;
                i++;
            }
            dgvOpTur.AllowUserToAddRows = false;
        }
        void KOListele()
        {
            dgvKOMob.Rows.Clear();
            int j = 0;
            var lst = _db.tblKOMorbidites.ToList();
            foreach (var k in lst)
            {
                dgvKOMob.Rows.Add();
                dgvKOMob.Rows[j].Cells[0].Value = k.ID;
                dgvKOMob.Rows[j].Cells[1].Value = k.KO_Morbidite;
                j++;
            }
            dgvKOMob.AllowUserToAddRows = false;
        }
        void DRListele()
        {
            dgvDrAdi.Rows.Clear();
            int p = 0;
            var lst = _db.tblDrListesis.ToList();
            foreach (var k in lst)
            {
                dgvDrAdi.Rows.Add();
                dgvDrAdi.Rows[p].Cells[0].Value = k.ID;
                dgvDrAdi.Rows[p].Cells[1].Value = k.DrAdi;
                p++;
            }
            dgvDrAdi.AllowUserToAddRows = false;
        }


        private void btnOpKaydet_Click(object sender, EventArgs e)
        {
            tblOperasyonTuru ot = new tblOperasyonTuru();
            if (txtOpTurGir.Text!="")
            {
                ot.OperasyonTuru = txtOpTurGir.Text;
                _db.tblOperasyonTurus.InsertOnSubmit(ot);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla eklenmiştir");
            }
            else
            {
                MessageBox.Show("Boş kayıt girilemez");
            }
           
            txtOpTurGir.Text = "";
            OPListele();
            KOListele();
            DRListele();
        }

        private void btnKOKaydet_Click(object sender, EventArgs e)
        {
            tblKOMorbidite kom = new tblKOMorbidite();
            if (txtKOMobGir.Text!="")
            {
                kom.KO_Morbidite = txtKOMobGir.Text;
                _db.tblKOMorbidites.InsertOnSubmit(kom);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla eklenmiştir");
            }
            else
            {
                MessageBox.Show("Boş kayıt girilemez");
            }

            txtKOMobGir.Text = "";
            OPListele();
            KOListele();
            DRListele();
        }

        private void btnDrKaydet_Click(object sender, EventArgs e)
        {
            tblDrListesi dr = new tblDrListesi();
            if (txtDrGiris.Text!="")
            {
                dr.DrAdi = txtDrGiris.Text;
                _db.tblDrListesis.InsertOnSubmit(dr);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla eklenmiştir");
            }
            else
            {
                MessageBox.Show("Boş kayıt girilemez");
            }
            txtDrGiris.Text = "";
            OPListele();
            KOListele();
            DRListele();
        }
        void OpSec()
        {
            try
            {
                _edit = true;
                _opID = int.Parse(dgvOpTur.CurrentRow.Cells[0].Value.ToString());
                txtOpTurGir.Text = dgvOpTur.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _opID = -1;
            }
        }
        void KoSec()
        {
            try
            {
                _edit = true;
                _koID = int.Parse(dgvKOMob.CurrentRow.Cells[0].Value.ToString());
                txtKOMobGir.Text = dgvKOMob.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _koID = -1;
            }
        }
        void DrSec()
        {
            try
            {
                _edit = true;
                _drID = int.Parse(dgvDrAdi.CurrentRow.Cells[0].Value.ToString());
                txtDrGiris.Text = dgvDrAdi.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _drID = -1;
            }
        }
        void OpSil()
        {
            _db.tblOperasyonTurus.DeleteOnSubmit(_db.tblOperasyonTurus.First(x => x.ID == _opID));
            _db.SubmitChanges();
            OPListele();
        }
        void KoSil()
        {
            _db.tblKOMorbidites.DeleteOnSubmit(_db.tblKOMorbidites.First(x => x.ID == _koID));
            _db.SubmitChanges();
            KOListele();
        }
        void DrSil()
        {
            _db.tblDrListesis.DeleteOnSubmit(_db.tblDrListesis.First(x => x.ID == _drID));
            _db.SubmitChanges();
            DRListele();
        }
        private void dgvDrAdi_DoubleClick(object sender, EventArgs e)
        {
            
            txtDrGiris.Text = "";
            c = dgvDrAdi.CurrentRow.Cells[1].Value.ToString();

            txtDrGiris.Text = c;
        }

        private void dgvOpTur_Click(object sender, EventArgs e)
        {
            OpSec();
        }

        private void dgvKOMob_Click(object sender, EventArgs e)
        {
            KoSec();
        }

        private void btnOpSil_Click(object sender, EventArgs e)
        {
            if (_edit && _opID > 0 && _m.Sil() == DialogResult.Yes)
            {
                OpSil();
            }
        }

        private void btnKoSil_Click(object sender, EventArgs e)
        {
            if (_edit && _koID > 0 && _m.Sil() == DialogResult.Yes)
            {
                KoSil();
            }
        }

        private void btnDrSil_Click(object sender, EventArgs e)
        {
            if (_edit && _drID > 0 && _m.Sil() == DialogResult.Yes)
            {
                DrSil();
            }
        }

        private void dgvDrAdi_Click(object sender, EventArgs e)
        {
            DrSec();
        }

        private void dgvOpTur_DoubleClick(object sender, EventArgs e)
        {
            txtOpTurGir.Text = "";
            a = dgvOpTur.CurrentRow.Cells[1].Value.ToString();

            txtOpTurGir.Text = a;
        }

        private void dgvKOMob_DoubleClick(object sender, EventArgs e)
        {
            OpSec();
            txtKOMobGir.Text = "";
            b = dgvKOMob.CurrentRow.Cells[1].Value.ToString();


            txtKOMobGir.Text = b;
        }
    }
}
