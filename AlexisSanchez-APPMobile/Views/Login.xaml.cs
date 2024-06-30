using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AlexisSanchez_APPMobile.Views
{
    public partial class Login : ContentPage
    {
        // Simulated database
        private static List<User> users = new List<User>();

        public Login()
        {
            InitializeComponent();
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            string email = txtRegisterEmail.Text;
            string password = txtRegisterPassword.Text;

            if (IsValidEmail(email) && IsValidPassword(password))
            {
                users.Add(new User { Email = email, Password = password });
                lblRegisterMessage.TextColor = Colors.Green;
                lblRegisterMessage.Text = "Registro exitoso. Por favor, inicie sesión.";
                ShowLoginForm(sender, e);
                ClearRegisterForm();
            }
            else
            {
                lblRegisterMessage.TextColor = Colors.Red;
                lblRegisterMessage.Text = "El correo o la contraseña no son válidos.)";
            }
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;

            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                lblLoginMessage.IsVisible = false;
                loginForm.IsVisible = false;
                lblSuccessMessage.Text = "Inicio de sesión exitoso.";
                lblSuccessMessage.IsVisible = true;
            }
            else
            {
                lblLoginMessage.TextColor = Colors.Red;
                lblLoginMessage.Text = "Correo o contraseña incorrectos.";
                lblLoginMessage.IsVisible = true;
            }
        }

        private void ShowLoginForm(object sender, EventArgs e)
        {
            registerForm.IsVisible = false;
            loginForm.IsVisible = true;
            lblSuccessMessage.IsVisible = false;
        }

        private void ShowRegisterForm(object sender, EventArgs e)
        {
            registerForm.IsVisible = true;
            loginForm.IsVisible = false;
            lblSuccessMessage.IsVisible = false;
        }

        private void ClearRegisterForm()
        {
            txtRegisterEmail.Text = string.Empty;
            txtRegisterPassword.Text = string.Empty;
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length > 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }

        private void OnEmailTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is Entry entry)
            {
                entry.Text = entry.Text.ToLower();
            }
        }

        private class User
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        private void txtRegisterPassword_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}