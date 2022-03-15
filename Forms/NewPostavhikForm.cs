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
    public partial class NewPostavhikForm : Form
    {
        ApplicationContext db;
        public NewPostavhikForm()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void AddPostavhikButton_Click(object sender, EventArgs e)
        {
            string postavhik_Company = CompanyBox.Text;
            string postavhik_Phone = PhoneBox.Text;
            string postavhik_Email = EmailBox.Text;
            string postavhik_Address = AdresBox.Text;
            string postavhik_INN = INNBox.Text;
            string postavhik_OGRN = OGRNBox.Text;            

            if (postavhik_Company.Length < 5)
            {
                MessageBox.Show("Поля заполнены не корректно!");
                return;
            }
            else if (postavhik_Phone.Length < 5)
            {
                MessageBox.Show("Поля заполнены не корректно!");
                return;
            }
            else if (postavhik_Email.Length < 5 || !postavhik_Email.Contains('@') || !postavhik_Email.Contains('.'))
            {
                MessageBox.Show("Поля заполнены не корректно!");
                return;
            }
            else
            {
                MessageBox.Show("Добавлен");

                Postavhik postavhik = new Postavhik(postavhik_Company, postavhik_Phone, postavhik_Email, postavhik_Address, postavhik_INN, postavhik_OGRN);
                db.Postavhiks.Add(postavhik);
                db.SaveChanges();
            }
        }
    }
}
