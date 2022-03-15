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
    public partial class AdminForm : Form
    {

        ApplicationContext db;

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT= new DataTable();


        public AdminForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
            UpdateView();
        }

        SQLiteConnection DB = new SQLiteConnection("Data source = DataBaseMDM.db");

        private void AddPolzovatelButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            string post = PostBox.Text;
            string name = NameBox.Text;
            string secondName = SecondNameBox.Text;
            string patronymic = PatronymicBox.Text;
            string email = EmailBox.Text;
            string age = AgeBox.Text;
            string phone = PhoneBox.Text;

            if(login.Length < 5)
            {
                MessageBox.Show("Поля заполнены не корректно!");
                return;
            } else if(password.Length < 5)
            {
                MessageBox.Show("Поля заполнены не корректно!");
                return;
            } else if (email.Length < 5 || !email.Contains('@') || !email.Contains('.'))
            {
                MessageBox.Show("Поля заполнены не корректно!");
                return;
            } else
            {
                MessageBox.Show("Всё хорошо!");

                User user = new User(login, password, post, name, secondName, patronymic, email, age, phone);
                db.Users.Add(user);
                db.SaveChanges();
            }
                        
        }
        public void UpdateView()
        {
            DB.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From Users", DB);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");            
            AdminGridView.DataSource = dset.Tables[0];
            (AdminGridView.DataSource as DataTable).DefaultView.RowFilter = $"hidden LIKE '%{0}%'";
            AdminGridView.RowHeadersVisible = false;
            AdminGridView.Columns["name"].HeaderText = "Имя";
            AdminGridView.Columns["secondName"].HeaderText = "Фамилия";
            AdminGridView.Columns["patronymic"].HeaderText = "Отчество";
            AdminGridView.Columns["login"].Visible = false;
            AdminGridView.Columns["password"].Visible = false;
            AdminGridView.Columns["email"].Visible = false;
            AdminGridView.Columns["age"].Visible = false;
            AdminGridView.Columns["hidden"].Visible = false;
            AdminGridView.Columns["phone"].Visible = false;
            DB.Close();
        }

        private void AdminGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoginBox.Text = AdminGridView.CurrentRow.Cells["login"].Value.ToString();
            PasswordBox.Text = AdminGridView.CurrentRow.Cells["password"].Value.ToString();
            PostBox.Text = AdminGridView.CurrentRow.Cells["post"].Value.ToString();
            NameBox.Text = AdminGridView.CurrentRow.Cells["name"].Value.ToString();
            SecondNameBox.Text = AdminGridView.CurrentRow.Cells["secondName"].Value.ToString();
            PatronymicBox.Text = AdminGridView.CurrentRow.Cells["patronymic"].Value.ToString();
            EmailBox.Text = AdminGridView.CurrentRow.Cells["email"].Value.ToString();
            AgeBox.Text = AdminGridView.CurrentRow.Cells["age"].Value.ToString();
            PhoneBox.Text = AdminGridView.CurrentRow.Cells["phone"].Value.ToString();
            IDBox.Text = AdminGridView.CurrentRow.Cells["id"].Value.ToString();
        }

        private void ExecuteQuery(string txtQuery)
        {
            DB.Open();
            sql_cmd = DB.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            DB.Close();

        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Users set Name='"+NameBox.Text+ "',secondName='" + SecondNameBox.Text + "'," +
                "patronymic='" + PatronymicBox.Text + "',email='" + EmailBox.Text + "',login='" + LoginBox.Text + "'," +
                "password='" + PasswordBox.Text + "',age='" + AgeBox.Text + "',phone='" + PhoneBox.Text + "' where ID = '" + IDBox.Text+"'";
            ExecuteQuery(txtQuery);
            UpdateView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Users set hidden='"+1+"' where ID = '" + IDBox.Text + "'";
            ExecuteQuery(txtQuery);
            UpdateView();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().ShowDialog();
            return;
        }
    }
}
