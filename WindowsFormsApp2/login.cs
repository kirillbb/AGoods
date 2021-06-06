using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class login : Form
    {
        private readonly string LogIn = "root";
        private readonly string PassWord = "root";

        public string UserLogin { get; set; }
        public string UserPass { get; set; }
        public static bool CheckLogIn { get; set; } = false;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {


        }

        private  bool EntrySystem(string login, string passWord)
        {
            CheckLogIn = login == LogIn && passWord == PassWord ? true : false;

            return CheckLogIn;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (EntrySystem(UserLogin, UserPass))
            {
                this.Close();
                
            }
            else
            {
                UserLoginTextBox.Clear();
                UserPasswordTextBox.Clear();
            }
        }

        public void LoginTextBox(object sender, EventArgs e)
        {
            UserLogin = UserLoginTextBox.Text;
            UserLoginTextBox.MaxLength = 14;
        }

        public void PasswordTextBox(object sender, EventArgs e)
        { 
            UserPasswordTextBox.PasswordChar = '●';
            UserPasswordTextBox.MaxLength = 14;

            UserPass = UserPasswordTextBox.Text;
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                button_goLogin.PerformClick();
            }
        }
    }
}
