using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcibademProje.Model;


namespace AcibademProje.Formlar
{
    public partial class frmHastaGirisi : Form
    {
        AcibademDataContext _db = new AcibademDataContext();
        Model.Formlar _f = new Model.Formlar();
        Numaralar _n = new Numaralar();
        Mesajlar _m = new Mesajlar();


        bool edit = false;
        int _hastaID = -1;
        int _demoID = -1;
        int _ooID = -1;
        int _pooID = -1;
        int _patoID = -1;
        int _takipID = -1;

        public frmHastaGirisi()
        {
            InitializeComponent();
        }

        private void frmHastaGirisi_Load(object sender, EventArgs e)
        {
            Temizle();
            Listele();
            Combo();
        }
        void Temizle()
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                foreach (Control ct in item.Controls)
                {
                    if (ct is TextBox)
                    {
                        ct.Text = "";
                    }
                    if (ct is ComboBox)
                    {
                        ((ComboBox)ct).SelectedIndex = -1;
                    }

                }
            }

            foreach (int i in clbMorbi.CheckedIndices)
            {
                clbMorbi.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in clbOpTur.CheckedIndices)
            {
                clbOpTur.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in clbDrAdi.CheckedIndices)
            {
                clbDrAdi.SetItemCheckState(i, CheckState.Unchecked);
            }

            txtHastaNO.Text = _n.HastaNo();
        }
        void Combo()
        {
            var patlst = (from s in _db.tblPatolojis
                          select new
                          {
                              s.Patoloji
                          }).Distinct();
            var altlst = (from s in _db.tblAltGrups
                          select new
                          {
                              s.AltGrup
                          }).Distinct();

            foreach (var k in altlst)
            {
                cbAltGrup.Items.Add(k.AltGrup);
            }
            foreach (var t in patlst)
            {
                cbPatoloji.Items.Add(t.Patoloji);
            }
        }
        void Kaydet()
        {
            try
            {
                tblHastaBilgileri hb = new tblHastaBilgileri();
                hb.HastaNO = int.Parse(txtHastaNO.Text);
                hb.HastaAdi = txtHAdi.Text;
                hb.HastaSoyadi = txtHSoyadi.Text;
                hb.ProtokolNo = txtProNo.Text;
                hb.OperasyonTuru = txtOperasyonTur.Text;
                hb.OperasyonTarihi = DateTime.Parse(dtpOpTarih.Text);
                hb.TakipSuresi_Ay_ = txtTakipSuresi.Text != "" ? int.Parse(txtTakipSuresi.Text) : -1;
                hb.Anah = txtAnah.Text != "" ? int.Parse(txtAnah.Text) : -1;

                _db.tblHastaBilgileris.InsertOnSubmit(hb);
                _db.SubmitChanges();

                AcibademDataContext _ab = new AcibademDataContext();

                tblDemografik dmg = new tblDemografik();
                dmg.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : -1;
                dmg.Boy_cm_ = txtBoy.Text != "" ? decimal.Parse(txtBoy.Text) : -1;
                dmg.Kilo_kg_ = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : -1;
                dmg.BMI = txtBMI.Text != "" ? int.Parse(txtBMI.Text) : -1;
                dmg.ASA = cbAsa.Text != "" ? int.Parse(cbAsa.Text) : -1;
                dmg.CINS = cbCins.Text;
                dmg.Taraf = cbTaraf.Text;
                dmg.Lokalizasyon = txtLokalizasyon.Text;
                dmg.Boyut =int.Parse( txtBoy.Text);
                dmg.KOMorbidite = txtKOMorb.Text;
                dmg.DrAdi = txtDrAdi.Text;
                dmg.HastaID = hb.ID;

                _ab.tblDemografiks.InsertOnSubmit(dmg);
                _ab.SubmitChanges();

                AcibademDataContext _sb = new AcibademDataContext();

                tblOperatifOzellikler opo = new tblOperatifOzellikler();
                opo.PKSAciklama = cbPKSAciklama.Text;
                opo.SIK = cbSik.Text;
                opo.COOperasyon = txtCoOp.Text;
                opo.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : -1;
                opo.PortSayisi = cbPortSayisi.Text != "" ? int.Parse(cbPortSayisi.Text) : -1;
                opo.YardimYNT = txtYardimYNT.Text;
                opo.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                opo.Dren = txtDren.Text != "" ? int.Parse(txtDren.Text) : -1;
                opo.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                opo.Piyes = txtPiyes.Text != "" ? int.Parse(txtPiyes.Text) : -1;
                opo.HastaID = hb.ID;

                _sb.tblOperatifOzelliklers.InsertOnSubmit(opo);
                _sb.SubmitChanges();

                AcibademDataContext _fb = new AcibademDataContext();

                tblPosOperatifOzellikleri poo = new tblPosOperatifOzellikleri();
                poo.Perop_ErkenKomp = cbPeropErken.Text;
                poo.PostopAnaliz = txtPOSTOPAnaliz.Text;
                poo.Sonda = cbSonda.Text;
                poo.HospSuresi = txtHospSure.Text != "" ? int.Parse(txtHospSure.Text) : -1;
                poo.PreopKreatin = txtPreOpKrea.Text != "" ? decimal.Parse(txtPreOpKrea.Text) : -1;
                poo.PostopKreatin = txtPostopKrea.Text != "" ? decimal.Parse(txtPostopKrea.Text) : -1;
                poo.PreopHCT = txtPreopHCT.Text != "" ? decimal.Parse(txtPreopHCT.Text) : -1;
                poo.PostopHCT = txtPostopHCT.Text != "" ? decimal.Parse(txtPostopHCT.Text) : -1;
                poo.PreopHB = txtPreopHB.Text != "" ? decimal.Parse(txtPreopHB.Text) : -1;
                poo.PostopHB = txtPostopHB.Text != "" ? decimal.Parse(txtPostopHB.Text) : -1;
                poo.Takip = txtTakip.Text;
                poo.Tel = txtTel.Text;
                poo.PostopGecKomp = txtPostopGecKomp.Text;
                poo.KompClavien = cbKompClavien.Text;
                poo.HastaID = hb.ID;

                _fb.tblPosOperatifOzellikleris.InsertOnSubmit(poo);
                _fb.SubmitChanges();

                AcibademDataContext _gb = new AcibademDataContext();

                tblPatolojikVeriler pv = new tblPatolojikVeriler();
                pv.FurhmanGrade = cbFurhman.Text;
                pv.PatolojikEvre = cbPatolojikEvre.Text;
                pv.CerrahiSinir = cbCerrahiSinir.Text;
                pv.AltGrup = cbAltGrup.Text;
                pv.Patoloji = cbPatoloji.Text;
                pv.HastaID = hb.ID;

                _gb.tblPatolojikVerilers.InsertOnSubmit(pv);
                _gb.SubmitChanges();

                AcibademDataContext _hb = new AcibademDataContext();

                tblTakipVerileri tv = new tblTakipVerileri();
                tv.Postop3AyLokalNuks = cb3AyNuks.Text;
                tv.Postop3AyKreatin = txt3AyKreatin.Text != "" ? decimal.Parse(txt3AyKreatin.Text) : -1;
                tv.Postop6AyLokalNuks = cb6AyNuks.Text;
                tv.Postop6AyKreatin = txt6AyKreatin.Text != "" ? decimal.Parse(txt6AyKreatin.Text) : -1;
                tv.Postop12AyLokalNuks = cb12AyNuks.Text;
                tv.Postop12AyKreatin = txt12AyKreatin.Text != "" ? decimal.Parse(txt12AyKreatin.Text) : -1;
                tv.HastaID = hb.ID;

                _hb.tblTakipVerileris.InsertOnSubmit(tv);
                _hb.SubmitChanges();
                _m.YeniKayit("Kayıt oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                tblHastaBilgileri hb = _db.tblHastaBilgileris.First(x => x.ID == _hastaID);
                hb.HastaNO = int.Parse(txtHastaNO.Text);
                hb.HastaAdi = txtHAdi.Text;
                hb.HastaSoyadi = txtHSoyadi.Text;
                hb.ProtokolNo = txtProNo.Text;
                hb.OperasyonTuru = txtOperasyonTur.Text;
                hb.OperasyonTarihi = DateTime.Parse(dtpOpTarih.Text);
                hb.TakipSuresi_Ay_ = txtTakipSuresi.Text != "" ? int.Parse(txtTakipSuresi.Text) : -1;
                hb.Anah = txtAnah.Text != "" ? int.Parse(txtAnah.Text) : -1;

                _db.SubmitChanges();

                AcibademDataContext _ab = new AcibademDataContext();

                tblDemografik dmg = _ab.tblDemografiks.First(x => x.ID == _demoID);
                dmg.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : -1;
                dmg.Boy_cm_ = txtBoy.Text != "" ? decimal.Parse(txtBoy.Text) : -1;
                dmg.Kilo_kg_ = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : -1;
                dmg.BMI = txtBMI.Text != "" ? int.Parse(txtBMI.Text) : -1;
                dmg.ASA = cbAsa.Text != "" ? int.Parse(cbAsa.Text) : -1;
                dmg.CINS = cbCins.Text;
                dmg.Taraf = cbTaraf.Text;
                dmg.Lokalizasyon = txtLokalizasyon.Text;
                dmg.Boyut =int.Parse( txtBoy.Text);
                dmg.KOMorbidite = txtKOMorb.Text;
                dmg.DrAdi = txtDrAdi.Text;
                dmg.HastaID = hb.ID;


                _ab.SubmitChanges();

                AcibademDataContext _sb = new AcibademDataContext();

                tblOperatifOzellikler opo = _sb.tblOperatifOzelliklers.First(x => x.ID == _ooID);
                opo.PKSAciklama = cbPKSAciklama.Text;
                opo.SIK = cbSik.Text;
                opo.COOperasyon = txtCoOp.Text;
                opo.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : -1;
                opo.PortSayisi = cbPortSayisi.Text != "" ? int.Parse(cbPortSayisi.Text) : -1;
                opo.YardimYNT = txtYardimYNT.Text;
                opo.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                opo.Dren = txtDren.Text != "" ? int.Parse(txtDren.Text) : -1;
                opo.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                opo.Piyes = txtPiyes.Text != "" ? int.Parse(txtPiyes.Text) : -1;
                opo.HastaID = hb.ID;


                _sb.SubmitChanges();

                AcibademDataContext _fb = new AcibademDataContext();

                tblPosOperatifOzellikleri poo = _fb.tblPosOperatifOzellikleris.First(x => x.ID == _pooID);
                poo.Perop_ErkenKomp = cbPeropErken.Text;
                poo.PostopAnaliz = txtPOSTOPAnaliz.Text;
                poo.Sonda = cbSonda.Text;
                poo.HospSuresi = txtHospSure.Text != "" ? int.Parse(txtHospSure.Text) : -1;
                poo.PreopKreatin = txtPreOpKrea.Text != "" ? decimal.Parse(txtPreOpKrea.Text) : -1;
                poo.PostopKreatin = txtPostopKrea.Text != "" ? decimal.Parse(txtPostopKrea.Text) : -1;
                poo.PreopHCT = txtPreopHCT.Text != "" ? decimal.Parse(txtPreopHCT.Text) : -1;
                poo.PostopHCT = txtPostopHCT.Text != "" ? decimal.Parse(txtPostopHCT.Text) : -1;
                poo.PreopHB = txtPreopHB.Text != "" ? decimal.Parse(txtPreopHB.Text) : -1;
                poo.PostopHB = txtPostopHB.Text != "" ? decimal.Parse(txtPostopHB.Text) : -1;
                poo.Takip = txtTakip.Text;
                poo.Tel = txtTel.Text;
                poo.PostopGecKomp = txtPostopGecKomp.Text;
                poo.KompClavien = cbKompClavien.Text;
                poo.HastaID = hb.ID;


                _fb.SubmitChanges();

                AcibademDataContext _gb = new AcibademDataContext();

                tblPatolojikVeriler pv = _gb.tblPatolojikVerilers.First(x => x.ID == _patoID);
                pv.FurhmanGrade = cbFurhman.Text;
                pv.PatolojikEvre = cbPatolojikEvre.Text;
                pv.CerrahiSinir = cbCerrahiSinir.Text;
                pv.AltGrup = cbAltGrup.Text;
                pv.Patoloji = cbPatoloji.Text;
                pv.HastaID = hb.ID;


                _gb.SubmitChanges();

                AcibademDataContext _hb = new AcibademDataContext();

                tblTakipVerileri tv = _hb.tblTakipVerileris.First(x => x.ID == _takipID);
                tv.Postop3AyLokalNuks = cb3AyNuks.Text;
                tv.Postop3AyKreatin = txt3AyKreatin.Text != "" ? decimal.Parse(txt3AyKreatin.Text) : -1;
                tv.Postop6AyLokalNuks = cb6AyNuks.Text;
                tv.Postop6AyKreatin = txt6AyKreatin.Text != "" ? decimal.Parse(txt6AyKreatin.Text) : -1;
                tv.Postop12AyLokalNuks = cb12AyNuks.Text;
                tv.Postop12AyKreatin = txt12AyKreatin.Text != "" ? decimal.Parse(txt12AyKreatin.Text) : -1;
                tv.HastaID = hb.ID;


                _hb.SubmitChanges();
                _m.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btnhbul = new Button();
            btnhbul.Size = new Size(25, txtHastaNO.ClientSize.Height + 2);
            btnhbul.Location = new Point(txtHastaNO.ClientSize.Width - btnhbul.Width, -1);
            btnhbul.Cursor = Cursors.Default;
            txtHastaNO.Controls.Add(btnhbul);
            SendMessage(txtHastaNO.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnhbul.Width << 16));
            btnhbul.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);

            btnhbul.Click += btnhbul_Click;
        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr w, uint m, IntPtr p1, IntPtr p2);

        private void btnhbul_Click(object sender, EventArgs e)
        {
            int id = _f.HastaList(true);
            if (id > 0)
            {
                HastaListAc(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }
        void HastaListAc(int id)
        {
            try
            {
                edit = true;
                _hastaID = id;
                _demoID = id;
                _ooID = id;
                _pooID = id;
                _patoID = id;
                _takipID = id;
                tblHastaBilgileri hb = _db.tblHastaBilgileris.First(x => x.ID == _hastaID);
                txtHAdi.Text = hb.HastaAdi;
                txtHSoyadi.Text = hb.HastaSoyadi;
                txtProNo.Text = hb.ProtokolNo;
                dtpOpTarih.Text = hb.OperasyonTarihi.ToString();
                txtTakipSuresi.Text = hb.TakipSuresi_Ay_.ToString();
                txtAnah.Text = hb.Anah.ToString();
                txtOperasyonTur.Text = hb.OperasyonTuru;

                tblDemografik dmg = _db.tblDemografiks.First(x => x.HastaID == _demoID);
                txtYas.Text = dmg.Yas.ToString();
                txtBoy.Text = dmg.Boy_cm_.ToString();
                txtKilo.Text = dmg.Kilo_kg_.ToString();
                txtBMI.Text = dmg.BMI.ToString();
                cbAsa.Text = dmg.ASA.ToString();
                cbCins.Text = dmg.CINS;
                cbTaraf.Text = dmg.Taraf;
                txtLokalizasyon.Text = dmg.Lokalizasyon;
                txtBoyut.Text = dmg.Boyut.ToString();
                txtKOMorb.Text = dmg.KOMorbidite;
                txtDrAdi.Text = dmg.DrAdi;

                tblOperatifOzellikler opo = _db.tblOperatifOzelliklers.First(x => x.HastaID == _ooID);
                cbPKSAciklama.Text = opo.PKSAciklama;
                cbSik.Text = opo.SIK;
                txtCoOp.Text = opo.COOperasyon;
                txtIskemi.Text = opo.Iskemi.ToString();
                cbPortSayisi.Text = opo.PortSayisi.ToString();
                txtYardimYNT.Text = opo.YardimYNT;
                txtSure.Text = opo.Sure.ToString();
                txtDren.Text = opo.Dren.ToString();
                txtKanama.Text = opo.Kanama.ToString();
                txtPiyes.Text = opo.Piyes.ToString();

                tblPosOperatifOzellikleri poo = _db.tblPosOperatifOzellikleris.First(x => x.HastaID == _pooID);
                cbPeropErken.Text = poo.Perop_ErkenKomp;
                txtPOSTOPAnaliz.Text = poo.PostopAnaliz;
                cbSonda.Text = poo.Sonda;
                txtHospSure.Text = poo.HospSuresi.ToString();
                txtPreOpKrea.Text = poo.PreopKreatin.ToString();
                txtPostopKrea.Text = poo.PostopKreatin.ToString();
                txtPreopHCT.Text = poo.PreopHCT.ToString();
                txtPostopHCT.Text = poo.PostopHCT.ToString();
                txtPreopHB.Text = poo.PreopHB.ToString();
                txtPostopHB.Text = poo.PostopHB.ToString();
                txtTakip.Text = poo.Takip;
                txtTel.Text = poo.Tel;
                txtPostopGecKomp.Text = poo.PostopGecKomp;
                cbKompClavien.Text = poo.KompClavien;

                tblPatolojikVeriler pv = _db.tblPatolojikVerilers.First(x => x.HastaID == _patoID);
                cbFurhman.Text = pv.FurhmanGrade;
                cbPatolojikEvre.Text = pv.PatolojikEvre;
                cbCerrahiSinir.Text = pv.CerrahiSinir;
                cbAltGrup.Text = pv.AltGrup;
                cbPatoloji.Text = pv.Patoloji;

                tblTakipVerileri tv = _db.tblTakipVerileris.First(x => x.HastaID == _takipID);
                cb3AyNuks.Text = tv.Postop3AyLokalNuks;
                txt3AyKreatin.Text = tv.Postop3AyKreatin.ToString();
                cb6AyNuks.Text = tv.Postop6AyLokalNuks;
                txt6AyKreatin.Text = tv.Postop6AyKreatin.ToString();
                cb12AyNuks.Text = tv.Postop12AyLokalNuks;
                txt12AyKreatin.Text = tv.Postop12AyKreatin.ToString();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        void Listele()
        {          

            var oplst = from s in _db.tblOperasyonTurus
                        orderby s.OperasyonTuru ascending
                         select s;

            var kolst = from s in _db.tblKOMorbidites
                         orderby s.KO_Morbidite ascending
                         select s;

            var drlst = from s in _db.tblDrListesis
                        orderby s.DrAdi ascending
                        select s;


            foreach (tblOperasyonTuru p in oplst)
            {
                clbOpTur.Items.Add(p.OperasyonTuru);
            }

            foreach (tblKOMorbidite t in kolst)
            {
                clbMorbi.Items.Add(t.KO_Morbidite);
            }
            foreach (tblDrListesi r in drlst)
            {
                clbDrAdi.Items.Add(r.DrAdi);
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && _hastaID > 0 && _m.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (!edit)
            {
                Kaydet();
            }
        }

        void OpTurGir()
        {
            foreach (string item in clbOpTur.CheckedItems)
            {

                txtOperasyonTur.Text += item + "+";
            }
        }
        void KoMorbiditeGir()
        {
            foreach (string item in clbMorbi.CheckedItems)
            {
                txtKOMorb.Text += item + " + ";
            }
        }
        void DrAdiGir()
        {
            foreach (string item in clbDrAdi.CheckedItems)
            {
                txtDrAdi.Text += item + " + ";
            }
        }

        private void btnOpTurGir_Click(object sender, EventArgs e)
        {
            txtOperasyonTur.Text = "";
            OpTurGir();

        }

        private void btnKoMorbidite_Click(object sender, EventArgs e)
        {
            txtKOMorb.Text = "";
            KoMorbiditeGir();
        }

        private void btnDrAdi_Click(object sender, EventArgs e)
        {
            txtDrAdi.Text = "";
            DrAdiGir();
        }

        private void btnFormuKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
