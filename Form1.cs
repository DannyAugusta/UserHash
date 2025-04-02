using System;
using System.Linq;
using System.Windows.Forms;

namespace UserHash
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Zarovná okno na střed obrazovky při spuštění
            StartPosition = FormStartPosition.CenterScreen;

            // Nastaví PasswordChar na *, aby se heslo zobrazovalo jako hvězdičky
            txtBox_Password.PasswordChar = '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Načte vstupy od uživatele
            string username = txtBox_Username.Text;
            string password = txtBox_Password.Text;

            // Pokusí se získat uživatele podle zadaného jména
            User user = UserManager.GetUser(username);

            // Ověří, zda uživatel existuje a zda zadané heslo odpovídá uloženému hashi
            if (user != null && user.VerifyPassword(password))
            {
                // Úspěšné přihlášení
                if (username == "admin")
                {
                    // Pokud je přihlášený admin, otevře se AdminForm
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    // Otevře se UserForm pro běžného uživatele
                    UserForm userForm = new UserForm(username);
                    userForm.Show();
                }

                // Skryje aktuální přihlašovací formulář
                this.Hide();
            }
            else
            {
                // Zobrazí chybovou hlášku při neplatném přihlášení
                MessageBox.Show("Špatné uživatelské jméno nebo heslo.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ukončí aplikaci při kliknutí na tlačítko pro odchod
            Application.Exit();
        }
    }
}
