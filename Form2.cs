using System;
using System.Linq;
using System.Windows.Forms;

namespace UserHash
{
    public partial class AdminForm : Form
    {
        // Konstruktor pro AdminForm
        public AdminForm()
        {
            InitializeComponent();
            LoadUserList(); // Načte seznam uživatelů při startu
            StartPosition = FormStartPosition.CenterScreen; // Zarovná okno na střed obrazovky
        }

        // Načte seznam uživatelů do listBoxu
        private void LoadUserList()
        {
            listBox1.Items.Clear(); // Vymaže aktuální seznam
            foreach (var user in UserManager.Users)
            {
                listBox1.Items.Add(user.Username); // Přidá uživatelská jména do listBoxu
            }
        }

        // Tlačítko pro přidání nového uživatele
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            string newUsername = InputDialog.Show("Zadejte uživatelské jméno"); // Zobrazí dialog pro zadání jména
            if (!string.IsNullOrEmpty(newUsername))
            {
                UserManager.AddUser(newUsername); // Přidá nového uživatele
                LoadUserList(); // Obnoví seznam uživatelů
            }
        }

        // Tlačítko pro smazání vybraného uživatele
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedUsername = listBox1.SelectedItem.ToString(); // Získá vybraného uživatele
                UserManager.DeleteUser(selectedUsername); // Smaže uživatele
                LoadUserList(); // Obnoví seznam uživatelů
            }
        }

        // Tlačítko pro změnu hesla vybraného uživatele
        private void btn_ChangeUserPassword_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedUsername = listBox1.SelectedItem.ToString(); // Získá vybraného uživatele
                User selectedUser = UserManager.GetUser(selectedUsername); // Načte uživatele

                string newPassword = InputDialog.Show("Zadejte nové heslo"); // Zobrazí dialog pro zadání nového hesla
                if (!string.IsNullOrEmpty(newPassword))
                {
                    selectedUser.ChangePassword(newPassword); // Změní heslo uživatele
                    UserManager.SaveUsers(); // Uloží změny
                }
            }
        }

        // Tlačítko pro odhlášení
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide(); // Skryje aktuální formulář
            LoginForm loginForm = new LoginForm(); // Vytvoří nový LoginForm
            loginForm.Show(); // Zobrazí LoginForm
        }
    }
}