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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginLabel.Text = Program.LoginTitle;

            LoaderTitle.Text = "Не проведенные заказы";
            this.PanelFormLoader.Controls.Clear();
            AllZakazForm FrmAllZakazForm_vrb = new AllZakazForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAllZakazForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmAllZakazForm_vrb);
            FrmAllZakazForm_vrb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNewZakaz_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Новый заказ";
            this.PanelFormLoader.Controls.Clear();
            NewZakazForm FrmDashboard_vrb = new NewZakazForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void ExitMainButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNewPostavhik_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Новый поставщик";
            this.PanelFormLoader.Controls.Clear();
            NewPostavhikForm FrmNewPostavhik_vrb = new NewPostavhikForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmNewPostavhik_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmNewPostavhik_vrb);
            FrmNewPostavhik_vrb.Show();
        }

        private void AddTowarMainButton_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Новый товар";
            this.PanelFormLoader.Controls.Clear();
            NewTowarForm FrmNewTowar_vrb = new NewTowarForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmNewTowar_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmNewTowar_vrb);
            FrmNewTowar_vrb.Show();
        }

        private void CloseMainButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().ShowDialog();
            return;
        }

        private void AllZakazButton_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Не проведенные заказы";
            this.PanelFormLoader.Controls.Clear();
            AllZakazForm FrmAllZakazForm_vrb = new AllZakazForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAllZakazForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmAllZakazForm_vrb);
            FrmAllZakazForm_vrb.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Информация";
            this.PanelFormLoader.Controls.Clear();
            InfoForm FrmInfoForm_vrb = new InfoForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmInfoForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmInfoForm_vrb);
            FrmInfoForm_vrb.Show();
        }

        private void AllPostavhikButton_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Поставщики";
            this.PanelFormLoader.Controls.Clear();
            AllPostavhikForm FrmAllPostavhikForm_vrb = new AllPostavhikForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAllPostavhikForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmAllPostavhikForm_vrb);
            FrmAllPostavhikForm_vrb.Show();
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Хранилище";
            this.PanelFormLoader.Controls.Clear();
            StorageForm FrmStorageForm_vrb = new StorageForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmStorageForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmStorageForm_vrb);
            FrmStorageForm_vrb.Show();
        }

        private void AllTowarsButton_Click(object sender, EventArgs e)
        {
            LoaderTitle.Text = "Товары";
            this.PanelFormLoader.Controls.Clear();
            AllTowarsFormcs FrmAllTowarsFormcs_vrb = new AllTowarsFormcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAllTowarsFormcs_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FrmAllTowarsFormcs_vrb);
            FrmAllTowarsFormcs_vrb.Show();
        }
    }
}
