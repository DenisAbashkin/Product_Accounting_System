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
    public partial class NewZakazForm : Form
    {
        public NewZakazForm()
        {
            InitializeComponent();
            UpdateNewZakazView();
        }

        SQLiteConnection DB = new SQLiteConnection("Data source = DataBaseMDM.db");
        public void UpdateNewZakazView()
        {
            DB.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From Postavhiks", DB);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            NewZakazView.DataSource = dset.Tables[0];
            (NewZakazView.DataSource as DataTable).DefaultView.RowFilter = $"postavhik_Hidden LIKE '%{0}%'";
            NewZakazView.RowHeadersVisible = false;
            NewZakazView.Columns["postavhik_Company"].HeaderText = "Поставщик";
            NewZakazView.Columns["postavhik_Phone"].HeaderText = "Телефон";
            NewZakazView.Columns["postavhik_Email"].HeaderText = "Почта";
            NewZakazView.Columns["postavhik_Address"].HeaderText = "Адрес";
            NewZakazView.Columns["postavhik_INN"].Visible = false;
            NewZakazView.Columns["postavhik_OGRN"].Visible = false;
            NewZakazView.Columns["postavhik_Id"].Visible = false;
            NewZakazView.Columns["postavhik_Hidden"].Visible = false;
            DB.Close();           
        }
        private void daleeButton_Click(object sender, EventArgs e)
        {
            Program.PostavhikDalee = NewZakazView.CurrentRow.Cells["postavhik_Company"].Value.ToString();
            Program.PhoneDalee = NewZakazView.CurrentRow.Cells["postavhik_Phone"].Value.ToString();
            Hide();
            new DaleeNewZakaz().ShowDialog();
            return;
        }

        private void NewZakazView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyLbl.Text = NewZakazView.CurrentRow.Cells["postavhik_Company"].Value.ToString();
            PhoneLbl.Text = NewZakazView.CurrentRow.Cells["postavhik_Phone"].Value.ToString();
            Emaillbl.Text = NewZakazView.CurrentRow.Cells["postavhik_Email"].Value.ToString();
            AdresLbl.Text = NewZakazView.CurrentRow.Cells["postavhik_Address"].Value.ToString();
            InnLbl.Text = NewZakazView.CurrentRow.Cells["postavhik_INN"].Value.ToString();
            OGRNLbl.Text = NewZakazView.CurrentRow.Cells["postavhik_OGRN"].Value.ToString();

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            (NewZakazView.DataSource as DataTable).DefaultView.RowFilter = $"postavhik_Company LIKE '%{SearchBox.Text}%'";
        }
    }
}
