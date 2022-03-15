using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Abashkin_Denis_MDM_171_333
{
    class Towar
    {
        [Key]
        public int towar_Id { get; set; }

        private string towar_Product, towar_Weight, towar_Wholesail, towar_Retail, towar_ExtraInfo;

        public string Towar_Product
        {
            get { return towar_Product; }
            set { towar_Product = value; }
        }

        public string Towar_Weight
        {
            get { return towar_Weight; }
            set { towar_Weight = value; }
        }

        public string Towar_Wholesail
        {
            get { return towar_Wholesail; }
            set { towar_Wholesail = value; }
        }

        public string Towar_Retail
        {
            get { return towar_Retail; }
            set { towar_Retail = value; }
        }

        public string Towar_ExtraInfo
        {
            get { return towar_ExtraInfo; }
            set { towar_ExtraInfo = value; }
        }
              
        public Towar() { }

        public Towar(string towar_Product, string towar_Weight, string towar_Wholesail, string towar_Retail, string towar_ExtraInfo)
        {
            this.towar_Product = towar_Product;
            this.towar_Weight = towar_Weight;
            this.towar_Wholesail = towar_Wholesail;
            this.towar_Retail = towar_Retail;
            this.towar_ExtraInfo = towar_ExtraInfo;        

        }
    }
}
