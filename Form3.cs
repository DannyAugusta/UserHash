using System;
using System.Windows.Forms;

namespace UserHash
{
    public partial class UserForm : Form
    {
        private string currentUsername; // Uchovává uživatelské jméno aktuálně přihlášeného uživatele

        // Konstruktor pro UserForm, který přijímá uživatelské jméno
        public UserForm(string username)
        {
            InitializeComponent();
            currentUsername = username; // Uloží uživatelské jméno do proměnné
            lbl_Username.Text = "Profil: " + currentUsername; // Zobrazuje uživatelské jméno v labelu
            txtBox_NewPassword.PasswordChar = '*'; // Nastaví maskování pro textové pole s heslem
            StartPosition = FormStartPosition.CenterScreen; // Zarovná okno na střed obrazovky
        }

        // Tlačítko pro potvrzení změny hesla
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string newPassword = txtBox_NewPassword.Text; // Získá nové heslo z textového pole
            if (!string.IsNullOrEmpty(newPassword))
            {
                User user = UserManager.GetUser(currentUsername); // Získá aktuálního uživatele
                user.ChangePassword(newPassword); // Změní heslo uživatele
                UserManager.SaveUsers(); // Uloží změny uživatelů
                MessageBox.Show("Heslo bylo změněno."); // Zobrazí potvrzení změny hesla
            }
            else
            {
                MessageBox.Show("Heslo nelze změnit. Zadejte nové heslo."); // Pokud je nové heslo prázdné
            }
        }

        // Tlačítko pro odhlášení uživatele
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Skryje aktuální formulář
            LoginForm loginForm = new LoginForm(); // Vytvoří nový LoginForm
            loginForm.Show(); // Zobrazí LoginForm
        }
    }
}
