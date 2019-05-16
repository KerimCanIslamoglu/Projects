using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcibademProje.Model;
using AcibademProje.Formlar;
using System.Windows.Forms;
using AcibademProje.Printing;


namespace AcibademProje.Model
{
    class Formlar
    {
        public void HastaGiris()
        {
            frmHastaGirisi frm = new frmHastaGirisi();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public int HastaList(bool secim = false)
        {
            frmHastaBul frm = new frmHastaBul();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.Aktarma;
        }
        //public int drkoopGiris(bool secim=false)
        //{
        //    dr_ko_op_giris frm = new dr_ko_op_giris();

        //    frm.ShowDialog();
        //    return frmAnaSayfa.opAktarma;
        //}
        public void drkoopGiris()
        {
            dr_ko_op_giris frm = new dr_ko_op_giris();

            frm.Show();
            //return frmAnaSayfa.opAktarma;
        }
        public int SorguList(bool secim = false)
        {
            frmSorgu frm = new frmSorgu();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.Aktarma;
        }
    }
}
