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
    public partial class HalamanUtama : Form
    {
        Config db = new Config();
        public HalamanUtama(string username, string nama)
        {
            InitializeComponent();
            db.Connect("userdata");

            //Inisialisai Formulir
            txtUser.Text = username;
            txtUser.Enabled = false;
            txtName.Text = nama;
            txtName.Enabled = false;
            
        }

        private void readData()
        {
            db.ExecuteSelect("SELECT * FROM `user_info`");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as :" + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Tidak ada data");
            }
           
        }

    }
}
