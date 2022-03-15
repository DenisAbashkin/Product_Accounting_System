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
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
            UpdateStorageView();
        }
        SQLiteConnection DB2 = new SQLiteConnection("Data source = DataBaseMDMStorage.db");
        public void UpdateStorageView()
        {
            DB2.Open();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter("Select * From Storages", DB2);
            DataSet dset2 = new DataSet();
            adapter2.Fill(dset2, "info");
            StorageView.DataSource = dset2.Tables[0];
            //(StorageView.DataSource as DataTable).DefaultView.RowFilter = $"zakaz_hidden LIKE '%{0}%'";
            StorageView.RowHeadersVisible = false;
            StorageView.Columns["storage_product"].HeaderText = "Товар";
            StorageView.Columns["storage_pucks"].HeaderText = "Кол-во";
            StorageView.Columns["storage_company"].HeaderText = "Поставщик";
            StorageView.Columns["storage_phone"].HeaderText = "Телефон";
            StorageView.Columns["storage_user_name"].HeaderText = "Провел заказ";
            StorageView.Columns["storage_date"].HeaderText = "Дата";
            StorageView.Columns["storage_id"].HeaderText = "id";            
            StorageView.Columns["storage_int_date"].Visible = false;            
            DB2.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string zakaz_start_date = dateTimePicker1.Value.ToString("yyyyMMdd");
            int zakaz_int_start_date = Convert.ToInt32(zakaz_start_date);
            string zakaz_end_date = dateTimePicker2.Value.ToString("yyyyMMdd");
            int zakaz_int_end_date = Convert.ToInt32(zakaz_end_date);
            (StorageView.DataSource as DataTable).DefaultView.RowFilter = $"storage_int_date >= '" + zakaz_int_start_date + "' and storage_int_date <= '" + zakaz_int_end_date + "'";
        }

        private void TowarNameBox_TextChanged(object sender, EventArgs e)
        {
            (StorageView.DataSource as DataTable).DefaultView.RowFilter = $"storage_product LIKE '%{TowarNameBox.Text}%'";
        }

        private void PostavhikNameBox_TextChanged(object sender, EventArgs e)
        {
            (StorageView.DataSource as DataTable).DefaultView.RowFilter = $"storage_company LIKE '%{PostavhikNameBox.Text}%'";
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            (StorageView.DataSource as DataTable).DefaultView.RowFilter = $"storage_user_name LIKE '%{UserBox.Text}%'";
        }
    }
}
