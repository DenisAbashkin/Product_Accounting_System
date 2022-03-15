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
    public partial class LoginForm : Form
    {
        ApplicationContext db;
        public LoginForm()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var Login = LoginBox.Text;
            var Password = PassBox.Text;

            if (Login.Length > 4)
            {
                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == Login && b.Password == Password).FirstOrDefault();
                }
                if(authUser != null)
                {
                    Program.LoginTitle = Login;
                    Hide();
                    new MainForm().ShowDialog();
                    return;
                }else if (Login == "admin")
                {
                    if (Password == "admin")
                    {
                        Hide();
                        new AdminForm().ShowDialog();
                        return;
                    }
                    MessageBox.Show("Неверный логин или пароль.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void Avtorization_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Avtorization_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

       
    }
}
