using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Abashkin_Denis_MDM_171_333
{
    class Storage
    {
        [Key]
        public int storage_id { get; set; }
        public int storage_int_date { get; set; }

        private string storage_product, storage_pucks, storage_company, storage_phone, storage_user_name, storage_date;

        public string Storage_product
        {
            get { return storage_product; }
            set { storage_product = value; }
        }

        public string Storage_pucks
        {
            get { return storage_pucks; }
            set { storage_pucks = value; }
        }

        public string Storage_company
        {
            get { return storage_company; }
            set { storage_company = value; }
        }

        public string Storage_phone
        {
            get { return storage_phone; }
            set { storage_phone = value; }
        }

        public string Storage_user_name
        {
            get { return storage_user_name; }
            set { storage_user_name = value; }
        }
        public string Storage_date
        {
            get { return storage_date; }
            set { storage_date = value; }
        }

        public Storage() { }

        public Storage(string storage_product, string storage_pucks, string storage_company, string storage_phone, string storage_user_name, string storage_date, int storage_int_date)
        {
            this.storage_product = storage_product;
            this.storage_pucks = storage_pucks;
            this.storage_company = storage_company;
            this.storage_phone = storage_phone;
            this.storage_user_name = storage_user_name;
            this.storage_date = storage_date;
            this.storage_int_date = storage_int_date;
        }
    }
}
