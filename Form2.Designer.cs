namespace UserHash
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangeUserPassword = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(263, 173);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(98, 34);
            this.btn_AddUser.TabIndex = 1;
            this.btn_AddUser.Text = "Přidat uživatele";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(263, 213);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(98, 34);
            this.btn_DeleteUser.TabIndex = 2;
            this.btn_DeleteUser.Text = "Odebrat uživatele";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Přihlášený jako Admin";
            // 
            // btn_ChangeUserPassword
            // 
            this.btn_ChangeUserPassword.Location = new System.Drawing.Point(263, 253);
            this.btn_ChangeUserPassword.Name = "btn_ChangeUserPassword";
            this.btn_ChangeUserPassword.Size = new System.Drawing.Size(98, 34);
            this.btn_ChangeUserPassword.TabIndex = 6;
            this.btn_ChangeUserPassword.Text = "Změnit heslo";
            this.btn_ChangeUserPassword.UseVisualStyleBackColor = true;
            this.btn_ChangeUserPassword.Click += new System.EventHandler(this.btn_ChangeUserPassword_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 277);
            this.listBox1.TabIndex = 7;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(264, 293);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(98, 34);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Odhlásit";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 343);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ChangeUserPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_AddUser);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangeUserPassword;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Logout;
    }
}