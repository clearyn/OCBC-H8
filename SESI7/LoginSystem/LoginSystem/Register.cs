﻿using System;
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
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.ExecuteSql("INSERT INTO `user_info` (`id`, `names`, `username`, `password`, `alamat`, `handphone`) " +
                "VALUES (NULL, '"+txtNama.Text+ "', '" + txtUsername.Text + "', '" + txtPassword.Text + "' , '" + txtAlamat.Text + "' , '" + txtHandphone.Text + "')");
            MessageBox.Show("Data telah disimpan");
            this.Close();
        }

    }
}
