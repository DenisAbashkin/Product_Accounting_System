using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abashkin_Denis_MDM_171_333
{
    public partial class NewTowarForm : Form
    {
        ApplicationContext db;
        public NewTowarForm()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void AddTowarButton_Click(object sender, EventArgs e)
        {

            {
                string towar_Product = TowarNameBox.Text;
                string towar_Weight = WeightBox.Text;
                string towar_Wholesail = WholesailBox.Text;
                string towar_Retail = RetailBox.Text;
                string towar_ExtraInfo = ExtraInfoBox.Text;                

                if (towar_Product.Length < 2)
                {
                    MessageBox.Show("Поля заполнены не корректно!");
                    return;
                }               
                else
                {
                    MessageBox.Show("Добавлен");

                    Towar towar = new Towar(towar_Product, towar_Weight, towar_Wholesail, towar_Retail, towar_ExtraInfo);
                    db.Towars.Add(towar);
                    db.SaveChanges();
                }
            }
        }
    }
}
