using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abashkin_Denis_MDM_171_333
{
    class User
    {
        public int id { get; set; }

        private string login, password, post, name, secondName, patronymic, email, age, phone;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public User() { }

        public User(string login, string password, string post, string name, string secondName, string patronymic, string email, string age, string phone)
        {
            this.login = login;
            this.password = password;
            this.post = post;
            this.name = name;
            this.secondName = secondName;
            this.patronymic = patronymic;
            this.email = email;
            this.age = age;
            this.phone = phone;
        }
    }
}
