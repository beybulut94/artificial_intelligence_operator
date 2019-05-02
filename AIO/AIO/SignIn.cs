﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AIO
{
    public partial class SignIn : Form
    {
        Thread th;
        public SignIn()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(openingIndex);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openingIndex()
        {
            Application.Run(new Index());
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(openingSignUp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }

        private void openingSignUp()
        {
            Application.Run(new SignUp());
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openingForgotPassword);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }

        private void openingForgotPassword()
        {
            //Application.Run(new ForgotPassword());
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            var authorityApp = new AppAuthority();
            string authority = authorityApp.Authority;

            string nick = nickTextBox.Text;
            string password = passwordTextBox.Text;
            WebServis1.accountPortTypeClient soap = new WebServis1.accountPortTypeClient();


            string loginAction = soap.loginAccount(nick,password,authority);

            if (loginAction == "0")
            {
                MessageBox.Show("Sign In Failed!");
            }
            else
            {
                var loginReturn = loginAction.Split('_');

                var newUser = new Customer();
                newUser.Token = loginReturn[0];
                newUser.Nick = loginReturn[1];
                newUser.Money = loginReturn[2];

                MessageBox.Show(loginAction+"Signed In.Please waiting…");
                th = new Thread(openingUserProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Close();
            }
            
        }

        private void openingUserProfile()
        {
            Application.Run(new UserProfile());
        }

        private void nickTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
