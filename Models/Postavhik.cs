using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Abashkin_Denis_MDM_171_333
{
    
    class Postavhik
    {
        [Key]
        public int postavhik_Id { get; set; }

        private string postavhik_Company, postavhik_Phone, postavhik_Email, postavhik_Address, postavhik_INN, postavhik_OGRN;

        public string Postavhik_Company
        {
            get { return postavhik_Company; }
            set { postavhik_Company = value; }
        }

        public string Postavhik_Phone
        {
            get { return postavhik_Phone; }
            set { postavhik_Phone = value; }
        }

        public string Postavhik_Email
        {
            get { return postavhik_Email; }
            set { postavhik_Email = value; }
        }

        public string Postavhik_Address
        {
            get { return postavhik_Address; }
            set { postavhik_Address = value; }
        }

        public string Postavhik_INN
        {
            get { return postavhik_INN; }
            set { postavhik_INN = value; }
        }

        public string Postavhik_OGRN
        {
            get { return postavhik_OGRN; }
            set { postavhik_OGRN = value; }
        }

       
        

        public Postavhik() { }

        public Postavhik(string postavhik_Company, string postavhik_Phone, string postavhik_Email, string postavhik_Address, string postavhik_INN, string postavhik_OGRN)
        {
            this.postavhik_Company = postavhik_Company;
            this.postavhik_Phone = postavhik_Phone;
            this.postavhik_Email = postavhik_Email;
            this.postavhik_Address = postavhik_Address;
            this.postavhik_INN = postavhik_INN;
            this.postavhik_OGRN = postavhik_OGRN;
                     
        }
    }
}
