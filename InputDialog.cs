using System;
using System.Windows.Forms;

namespace UserHash
{
    // Třída pro vlastní dialogové okno pro zadání textového vstupu
    public class InputDialog : Form
    {
        private TextBox txtInput; // TextBox pro zadání vstupu
        private Button btnOk; // Tlačítko pro potvrzení
        private Button btnCancel; // Tlačítko pro zrušení

        // Vlastnost pro získání textu zadaného do textového pole
        public string InputText { get; private set; }

        // Konstruktor třídy InputDialog
        public InputDialog(string prompt)
        {
            this.Text = prompt; // Nastavení textu okna podle promptu
            this.Size = new System.Drawing.Size(300, 150); // Nastavení velikosti okna

            // Vytvoření a nastavení TextBoxu pro zadání vstupu
            txtInput = new TextBox { Width = 250, Top = 20, Left = 20 };

            // Vytvoření a nastavení tlačítka pro potvrzení
            btnOk = new Button { Text = "OK", Top = 60, Left = 20 };

            // Vytvoření a nastavení tlačítka pro zrušení
            btnCancel = new Button { Text = "Cancel", Top = 60, Left = 120 };

            // Událost pro tlačítko OK - uloží zadaný text a zavře dialog
            btnOk.Click += (sender, e) => {
                InputText = txtInput.Text;
                this.DialogResult = DialogResult.OK;
            };

            // Událost pro tlačítko Cancel - zavře dialog bez zadání textu
            btnCancel.Click += (sender, e) => { this.DialogResult = DialogResult.Cancel; };

            // Přidání ovládacích prvků do formuláře
            this.Controls.Add(txtInput);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
        }

        // Statická metoda pro zobrazení InputDialogu a získání zadaného textu
        public static string Show(string prompt)
        {
            // Vytvoří a zobrazí InputDialog, pokud uživatel potvrdí, vrátí zadaný text
            using (InputDialog inputDialog = new InputDialog(prompt))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    return inputDialog.InputText;
                }
                return null; // Pokud uživatel zruší, vrátí null
            }
        }
    }
}
