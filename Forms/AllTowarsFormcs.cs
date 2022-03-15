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
    public partial class AllTowarsFormcs : Form
    {
        public AllTowarsFormcs()
        {
            InitializeComponent();
            UpdateAllPostavhikView();
        }
        SQLiteConnection DB = new SQLiteConnection("Data source = DataBaseMDM.db");
        public void UpdateAllPostavhikView()
        {
            DB.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From Towars", DB);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            AllTowarsView.DataSource = dset.Tables[0];
            (AllTowarsView.DataSource as DataTable).DefaultView.RowFilter = $"towar_Hidden LIKE '%{0}%'";
            AllTowarsView.RowHeadersVisible = false;
            AllTowarsView.Columns["towar_Product"].HeaderText = "Поставщик";
            AllTowarsView.Columns["towar_Wholesail"].HeaderText = "Оптовая цена";
            AllTowarsView.Columns["towar_Retail"].HeaderText = "Розничная цена";
            AllTowarsView.Columns["towar_Weight"].HeaderText = "Вес";
            AllTowarsView.Columns["towar_ExtraInfo"].HeaderText = "Доп. информация";
            AllTowarsView.Columns["towar_Packs"].Visible = false;           
            AllTowarsView.Columns["towar_Id"].Visible = false;
            AllTowarsView.Columns["towar_Hidden"].Visible = false;
        }

    }

}
