using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcibademProje.Model;


namespace AcibademProje.Model
{
    class Numaralar
    {
        AcibademDataContext _db = new AcibademDataContext();

        public string HastaNo()
        {
            try
            {
                int numara = (from s in _db.tblHastaBilgileris orderby s.ID descending select s).First().HastaNO.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }           
        }
    }
}
