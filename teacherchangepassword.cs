﻿using EdTeach_Management.Controllers;
using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdTeach_Management.Views
{
    public partial class teacherchangepassword : Form
    {
        Login user;
        public teacherchangepassword(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (newpasswordtextbox.Text != "")
            {
                LoginController.UpdatePassword(user.Id, newpasswordtextbox.Text);
                newpasswordtextbox.Clear();

                MessageBox.Show("password Change", "Change Password", MessageBoxButtons.OK);
                this.Hide();
                LoginView a = new LoginView();
                a.Show();


            }
            else
            {
                MessageBox.Show("please give new password", "Change Password", MessageBoxButtons.OK);

            }
        }

        private void teacherchangepassword_Load(object sender, EventArgs e)
        {
            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacherhome a = new Teacherhome(user);
            a.Show();
        }
    }
}
