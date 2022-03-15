using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Abashkin_Denis_MDM_171_333
{
    class Zakaz
    {
        [Key]
        public int zakaz_id { get; set; }
        public int zakaz_int_date { get; set; }

        private string towars_product, orpacks, postavhik_company, postavhik_phone, user_name, zakaz_date;

        public string Towars_product
        {
            get { return towars_product; }
            set { towars_product = value; }
        }

        public string Orpacks
        {
            get { return orpacks; }
            set { orpacks = value; }
        }

        public string Postavhik_company
        {
            get { return postavhik_company; }
            set { postavhik_company = value; }
        }

        public string Postavhik_phone
        {
            get { return postavhik_phone; }
            set { postavhik_phone = value; }
        }

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string Zakaz_date
        {
            get { return zakaz_date; }
            set { zakaz_date = value; }
        }

        public Zakaz() { }

        public Zakaz(string towars_product, string orpacks, string postavhik_company, string postavhik_phone, string user_name, string zakaz_date, int zakaz_int_date)
        {
            this.towars_product = towars_product;
            this.orpacks = orpacks;
            this.postavhik_company = postavhik_company;
            this.postavhik_phone = postavhik_phone;
            this.user_name = user_name;
            this.zakaz_date = zakaz_date;
            this.zakaz_int_date = zakaz_int_date;
        }
    }
}
