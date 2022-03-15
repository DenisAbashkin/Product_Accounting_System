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
    public partial class AllZakazForm : Form
    {
        ApplicationContext2 db2;
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public AllZakazForm()
        {
            db2 = new ApplicationContext2();
            InitializeComponent();
            UpdateAllZakazView();
        }
        SQLiteConnection DB = new SQLiteConnection("Data source = DataBaseMDM.db");
        public void UpdateAllZakazView()
        {
            DB.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From Zakazs", DB);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            AllZakazView.DataSource = dset.Tables[0];
            (AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"zakaz_hidden LIKE '%{0}%'";
            AllZakazView.RowHeadersVisible = false;
            AllZakazView.Columns["towars_product"].HeaderText = "Товар";
            AllZakazView.Columns["orpacks"].HeaderText = "Кол-во";
            AllZakazView.Columns["postavhik_company"].HeaderText = "Поставщик";
            AllZakazView.Columns["postavhik_phone"].HeaderText = "Телефон";
            AllZakazView.Columns["user_name"].HeaderText = "Провел заказ";
            AllZakazView.Columns["zakaz_date"].HeaderText = "Дата";
            AllZakazView.Columns["zakaz_id"].HeaderText = "id";
            AllZakazView.Columns["zakaz_hidden"].Visible = false;
            AllZakazView.Columns["zakaz_int_date"].Visible = false;            
            DB.Close();
        }

        //private void SearchZakazBox_TextChanged(object sender, EventArgs e)
        //{
        //    (AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"towars_product LIKE '%{SearchZakazBox.Text}%'";
        //}

        private void ExecuteQuery(string txtQuery)
        {
            DB.Open();
            sql_cmd = DB.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            DB.Close();

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string zakaz_start_date = dateTimePicker1.Value.ToString("yyyyMMdd");            
            int zakaz_int_start_date = Convert.ToInt32(zakaz_start_date);
            string zakaz_end_date = dateTimePicker2.Value.ToString("yyyyMMdd");
            int zakaz_int_end_date = Convert.ToInt32(zakaz_end_date);
            (AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"zakaz_int_date >= '"+zakaz_int_start_date+ "' and zakaz_int_date <= '" + zakaz_int_end_date + "'";
            ////string date_zakaz_start = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ////string date_zakaz_end = dateTimePicker2.Value.ToString("MM/dd/yyyy");


            ////string txtQuery = "update Zakazs set hidden='" + 1 + "' where ID = '" + IDBox.Text + "'";
            ////ExecuteQuery(txtQuery);
            ////UpdateAllZakazView();


            //string zakaz_date_end = dateTimePicker2.Value.ToString("yyyyMMdd");
            ////(AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"zakaz_date <= '%{zakaz_date_end}%'";
            //(AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"select * from zakaz_date where date berween '"+dateTimePicker1.Value.ToString()+"' and '" + dateTimePicker2.Value.ToString() + "'";
        }

        private void SearchZakazBox_TextChanged_1(object sender, EventArgs e)
        {
            (AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"towars_product LIKE '%{SearchZakazBox.Text}%'";
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            (AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"user_name LIKE '%{SearchName.Text}%'";
        }

        private void ChangeZakazButton_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Zakazs set towars_product='" + TowarNameBox.Text + "',orpacks='" + orPacksBox.Text + "'," +
                "postavhik_company='" + PostavhikNameBox.Text + "' where zakaz_id = '" + IDBox.Text + "'";
            ExecuteQuery(txtQuery);
            UpdateAllZakazView();
        }        
        private void AllZakazView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TowarNameBox.Text = AllZakazView.CurrentRow.Cells["towars_product"].Value.ToString();
            orPacksBox.Text = AllZakazView.CurrentRow.Cells["orpacks"].Value.ToString();
            PostavhikNameBox.Text = AllZakazView.CurrentRow.Cells["postavhik_company"].Value.ToString();
            PhoneBox.Text = AllZakazView.CurrentRow.Cells["postavhik_phone"].Value.ToString();
            UserBox.Text = AllZakazView.CurrentRow.Cells["user_name"].Value.ToString();
            dataBox.Text = AllZakazView.CurrentRow.Cells["zakaz_date"].Value.ToString();
            IDBox.Text = AllZakazView.CurrentRow.Cells["zakaz_id"].Value.ToString();
            DateHideBox.Text = AllZakazView.CurrentRow.Cells["zakaz_int_date"].Value.ToString();
        }

        private void AddStorageButton_Click(object sender, EventArgs e)
        {
            string storage_product = TowarNameBox.Text;
            string storage_pucks = orPacksBox.Text;
            string storage_company = PostavhikNameBox.Text;
            string storage_phone = PhoneBox.Text;
            string storage_user_name = UserBox.Text;
            string storage_date = dataBox.Text;
            string storage_int_hide_date = DateHideBox.Text;
            int storage_int_date = Convert.ToInt32(storage_int_hide_date);

            Storage storage = new Storage(storage_product, storage_pucks, storage_company, storage_phone, storage_user_name, storage_date,storage_int_date);
                db2.Storages.Add(storage);
                db2.SaveChanges();

            string txtQuery = "update Zakazs set zakaz_hidden='" + 1 + "' where zakaz_id = '" + IDBox.Text + "'";
            ExecuteQuery(txtQuery);
            UpdateAllZakazView();
        }
        //private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        //{
        //    (AllZakazView.DataSource as DataTable).DefaultView.RowFilter = $"zakaz_date <= '%{dateTimePicker2.Value.ToString("yyyy-MM-dd")}%'";
        //}
    }
}
