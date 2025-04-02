using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace UserHash
{
    // XmlInclude je nutné pro správnou serializaci objektu typu Admin (dítě třídy User)
    [XmlInclude(typeof(Admin))]
    public class User
    {
        public string Username { get; set; } // Uživatelské jméno
        public string HashedPassword { get; set; } // Uložené zašifrované heslo

        // Prázdný konstruktor
        public User() { }

        // Konstruktor pro inicializaci uživatele s uživatelským jménem
        public User(string username)
        {
            Username = username;
            HashedPassword = string.Empty; // Nový uživatel nemá heslo, tedy prázdné
        }

        // Metoda pro změnu hesla
        public void ChangePassword(string newPassword)
        {
            HashedPassword = HashPassword(newPassword); // Heslo je uloženo zašifrované
        }

        // Metoda pro ověření hesla
        public bool VerifyPassword(string password)
        {
            return HashedPassword == HashPassword(password); // Porovná zašifrované heslo
        }

        // Metoda pro vytvoření hash (zašifrování) hesla pomocí SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create()) // Vytvoření SHA-256 objektu pro hashování
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // Vytvoření hash
                return Convert.ToBase64String(bytes); // Vrací zašifrované heslo jako Base64 řetězec
            }
        }
    }

    // Třída Admin, která dědí od User
    public class Admin : User
    {
        public Admin() : base("admin") // Nastaví výchozí uživatelské jméno pro Admina
        {
            ChangePassword("admin"); // Nastaví výchozí heslo pro Admina (také zašifrované)
        }
    }
}
