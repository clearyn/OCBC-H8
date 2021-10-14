using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `user_info` WHERE username='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as :" + db.Results(0, "names"));
                HalamanUtama halamanUtama = new HalamanUtama(db.Results(0, "names"), db.Results(0, "username"));
                halamanUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
