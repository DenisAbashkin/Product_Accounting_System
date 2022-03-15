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
    public partial class AllPostavhikForm : Form
    {
        public AllPostavhikForm()
        {
            InitializeComponent();
            UpdateAllPostavhikView();
        }
        SQLiteConnection DB = new SQLiteConnection("Data source = DataBaseMDM.db");
        public void UpdateAllPostavhikView()
        {
            DB.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From Postavhiks", DB);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            AllPostavhiksView.DataSource = dset.Tables[0];
            (AllPostavhiksView.DataSource as DataTable).DefaultView.RowFilter = $"postavhik_Hidden LIKE '%{0}%'";
            AllPostavhiksView.RowHeadersVisible = false;
            AllPostavhiksView.Columns["postavhik_Company"].HeaderText = "Поставщик";
            AllPostavhiksView.Columns["postavhik_Phone"].HeaderText = "Телефон";
            AllPostavhiksView.Columns["postavhik_Email"].HeaderText = "Почта";
            AllPostavhiksView.Columns["postavhik_Address"].HeaderText = "Адрес";
            AllPostavhiksView.Columns["postavhik_INN"].HeaderText = "ИНН";
            AllPostavhiksView.Columns["postavhik_OGRN"].HeaderText = "ОГРН";
            AllPostavhiksView.Columns["postavhik_Id"].HeaderText = "id";
            AllPostavhiksView.Columns["postavhik_Hidden"].Visible = false;
            DB.Close();
        }

    }
    
}
