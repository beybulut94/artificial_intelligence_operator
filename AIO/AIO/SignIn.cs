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
            this.Close();
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
            this.Close();
        }

        private void openingForgotPassword()
        {
            //Application.Run(new ForgotPassword());
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string authority = AppAuthority.Authority;

            string nick = nickTextBox.Text;
            string password = passwordTextBox.Text;
            AccountWebService.accountPortTypeClient soap = new AccountWebService.accountPortTypeClient();


            string loginAction = soap.loginAccount(nick,password,authority);

            if (loginAction == "0")
            {
                MessageBox.Show("Sign In Failed!");
            }
            else
            {
                var loginReturn = loginAction.Split('_');

                
                Customer.Token = loginReturn[0];
                Customer.Nick = loginReturn[1];
                Customer.Money = loginReturn[2];


                MessageBox.Show("Signed In.Please waiting…");
                th = new Thread(openingUserProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                th = new Thread(openingUserSessionScreen);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            
        }

        private void openingUserSessionScreen()
        {
            Application.Run(new UserSessionScreen());
        }

        private void openingUserProfile()
        {
            Application.Run(new UserProfile());
        }

        private void nickTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
