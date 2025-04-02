using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace UserHash
{
    public static class UserManager
    {
        private static readonly string FilePath = "users.xml"; // Cesta k souboru, kde jsou uloženi uživatelé
        public static List<User> Users { get; private set; } = new List<User>(); // Seznam všech uživatelů

        // Statický konstruktor, který se spustí při načítání třídy UserManager
        static UserManager()
        {
            LoadUsers(); // Načte uživatele při spuštění aplikace
        }

        // Načte uživatele ze souboru, pokud soubor existuje
        public static void LoadUsers()
        {
            if (File.Exists(FilePath)) // Pokud soubor existuje
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>)); // Serializer pro seznam uživatelů
                    using (FileStream fs = new FileStream(FilePath, FileMode.Open)) // Otevře soubor pro čtení
                    {
                        Users = (List<User>)serializer.Deserialize(fs); // Deserializuje seznam uživatelů
                    }
                }
                catch (Exception ex) // Pokud dojde k chybě při načítání
                {
                    Console.WriteLine("Chyba při načítání uživatelů: " + ex.Message); // Vypíše chybu
                    Users = new List<User>(); // Vytvoří prázdný seznam, pokud dojde k chybě
                }
            }
            else // Pokud soubor neexistuje
            {
                Users.Add(new Admin()); // Přidá administrátora jako výchozího uživatele
                SaveUsers(); // Uloží uživatele do souboru
            }
        }

        // Uloží uživatele zpět do souboru
        public static void SaveUsers()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>)); // Serializer pro seznam uživatelů
                using (FileStream fs = new FileStream(FilePath, FileMode.Create)) // Otevře soubor pro zápis
                {
                    serializer.Serialize(fs, Users); // Serializuje seznam uživatelů a uloží do souboru
                }
            }
            catch (Exception ex) // Pokud dojde k chybě při ukládání
            {
                Console.WriteLine("Chyba při ukládání uživatelů: " + ex.Message); // Vypíše chybu
            }
        }

        // Přidá nového uživatele s daným uživatelským jménem
        public static void AddUser(string username)
        {
            User newUser = new User(username); // Vytvoří nového uživatele
            newUser.ChangePassword(""); // Nastaví prázdné heslo pro nového uživatele (lze upravit)
            Users.Add(newUser); // Přidá uživatele do seznamu
            SaveUsers(); // Uloží seznam uživatelů do souboru
        }

        // Smaže uživatele na základě uživatelského jména
        public static void DeleteUser(string username)
        {
            User user = Users.FirstOrDefault(u => u.Username == username); // Najde uživatele podle uživatelského jména
            if (user != null) // Pokud uživatel existuje
            {
                Users.Remove(user); // Odstraní uživatele ze seznamu
                SaveUsers(); // Uloží seznam uživatelů do souboru
            }
        }

        // Vrátí uživatele na základě uživatelského jména
        public static User GetUser(string username)
        {
            return Users.FirstOrDefault(u => u.Username == username); // Najde a vrátí uživatele podle jména
        }
    }
}
