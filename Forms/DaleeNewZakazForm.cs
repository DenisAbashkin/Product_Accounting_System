using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Abashkin_Denis_MDM_171_333
{
    public partial class DaleeNewZakaz : Form
    {
        ApplicationContext db;
        public DaleeNewZakaz()
        {
            db = new ApplicationContext();
            InitializeComponent();
            UpdateNewZakazView();
        }

        SQLiteConnection DB = new SQLiteConnection("Data source = DataBaseMDM.db");
        public void UpdateNewZakazView()
        {
            DB.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From Towars", DB);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            DaleeZakazView.DataSource = dset.Tables[0];
            (DaleeZakazView.DataSource as DataTable).DefaultView.RowFilter = $"towar_Hidden LIKE '%{0}%'";
            DaleeZakazView.RowHeadersVisible = false;
            DaleeZakazView.Columns["towar_Product"].HeaderText = "Поставщик";
            DaleeZakazView.Columns["towar_Wholesail"].HeaderText = "Оптовая цена";
            DaleeZakazView.Columns["towar_Retail"].HeaderText = "Розничная цена";
            DaleeZakazView.Columns["towar_Packs"].Visible = false;
            DaleeZakazView.Columns["towar_Weight"].Visible = false;
            DaleeZakazView.Columns["towar_ExtraInfo"].Visible = false;
            DaleeZakazView.Columns["towar_Id"].Visible = false;
            DaleeZakazView.Columns["towar_Hidden"].Visible = false;


            DB.Close();

        }
        private void DaleeAddZakazButton_Click(object sender, EventArgs e)
        {
            string orpacks = OrpacksBox.Text;
            string zakaz_date = dateTimePickerDaleeZakaz.Value.ToString("dd/MM/yyyy");
            string zakaz_date2 = dateTimePickerDaleeZakaz.Value.ToString("yyyyMMdd");
            int zakaz_int_date = Convert.ToInt32(zakaz_date2);
            //DateTime zakaz_date = dateTimePickerDaleeZakaz.Value;
            string towars_product = TowarLbl.Text;


            Zakaz zakaz = new Zakaz(towars_product, orpacks, Program.PostavhikDalee, Program.PhoneDalee, Program.LoginTitle, zakaz_date, zakaz_int_date);
            db.Zakazs.Add(zakaz);
            db.SaveChanges();

            //Program.TowarDalee = DaleeZakazView.CurrentRow.Cells["towar_Product"].Value.ToString();
            Hide();
            new MainForm().ShowDialog();
            return;
        }

        private void DaleeZakazView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TowarLbl.Text = DaleeZakazView.CurrentRow.Cells["towar_Product"].Value.ToString();
            WeightLbl.Text = DaleeZakazView.CurrentRow.Cells["towar_Weight"].Value.ToString();
            WholesailLbl.Text = DaleeZakazView.CurrentRow.Cells["towar_Wholesail"].Value.ToString();
            RetailLbl.Text = DaleeZakazView.CurrentRow.Cells["towar_Retail"].Value.ToString();
        }
    }
}
