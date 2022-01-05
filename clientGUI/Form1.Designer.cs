namespace clientGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.receveurText = new System.Windows.Forms.ListBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddresse = new System.Windows.Forms.TextBox();
            this.btnInterfaceConnecter = new System.Windows.Forms.Button();
            this.listUser = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.emojis = new System.Windows.Forms.ListBox();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.interfaceConnection = new System.Windows.Forms.Panel();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.interfaceMessage = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.interfaceConnection.SuspendLayout();
            this.interfaceMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMessage.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtMessage.Location = new System.Drawing.Point(10, 415);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(239, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // receveurText
            // 
            this.receveurText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.receveurText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receveurText.ForeColor = System.Drawing.Color.SpringGreen;
            this.receveurText.FormattingEnabled = true;
            this.receveurText.Location = new System.Drawing.Point(10, 38);
            this.receveurText.Name = "receveurText";
            this.receveurText.Size = new System.Drawing.Size(584, 355);
            this.receveurText.TabIndex = 1;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(308, 417);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(110, 20);
            this.btnEnvoyer.TabIndex = 2;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, -33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(91, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(127, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Addresse IP";
            // 
            // txtAddresse
            // 
            this.txtAddresse.Location = new System.Drawing.Point(91, 96);
            this.txtAddresse.Name = "txtAddresse";
            this.txtAddresse.Size = new System.Drawing.Size(127, 20);
            this.txtAddresse.TabIndex = 6;
            this.txtAddresse.Enter += new System.EventHandler(this.txtAddresse_Enter);
            // 
            // btnInterfaceConnecter
            // 
            this.btnInterfaceConnecter.Location = new System.Drawing.Point(612, 407);
            this.btnInterfaceConnecter.Name = "btnInterfaceConnecter";
            this.btnInterfaceConnecter.Size = new System.Drawing.Size(120, 28);
            this.btnInterfaceConnecter.TabIndex = 8;
            this.btnInterfaceConnecter.Text = "Connecter";
            this.btnInterfaceConnecter.UseVisualStyleBackColor = true;
            this.btnInterfaceConnecter.Click += new System.EventHandler(this.btnInterfaceConnecter_Click);
            // 
            // listUser
            // 
            this.listUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listUser.ForeColor = System.Drawing.Color.SpringGreen;
            this.listUser.FormattingEnabled = true;
            this.listUser.Location = new System.Drawing.Point(612, 38);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(120, 355);
            this.listUser.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.checkBox1.Location = new System.Drawing.Point(436, 420);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Message privé";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // emojis
            // 
            this.emojis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.emojis.ColumnWidth = 35;
            this.emojis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojis.ForeColor = System.Drawing.SystemColors.Menu;
            this.emojis.FormattingEnabled = true;
            this.emojis.ItemHeight = 31;
            this.emojis.Location = new System.Drawing.Point(382, 252);
            this.emojis.MultiColumn = true;
            this.emojis.Name = "emojis";
            this.emojis.Size = new System.Drawing.Size(201, 128);
            this.emojis.TabIndex = 12;
            this.emojis.Visible = false;
            this.emojis.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.emojis_MouseDoubleClick);
            // 
            // btnEmoji
            // 
            this.btnEmoji.BackColor = System.Drawing.Color.Transparent;
            this.btnEmoji.BackgroundImage = global::clientGUI.Properties.Resources.emoji1;
            this.btnEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmoji.FlatAppearance.BorderSize = 0;
            this.btnEmoji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmoji.Location = new System.Drawing.Point(255, 410);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(33, 27);
            this.btnEmoji.TabIndex = 13;
            this.btnEmoji.TabStop = false;
            this.btnEmoji.UseVisualStyleBackColor = false;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // interfaceConnection
            // 
            this.interfaceConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.interfaceConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interfaceConnection.Controls.Add(this.btnConnecter);
            this.interfaceConnection.Controls.Add(this.label5);
            this.interfaceConnection.Controls.Add(this.label3);
            this.interfaceConnection.Controls.Add(this.txtUsername);
            this.interfaceConnection.Controls.Add(this.label2);
            this.interfaceConnection.Controls.Add(this.txtAddresse);
            this.interfaceConnection.Location = new System.Drawing.Point(128, 123);
            this.interfaceConnection.Name = "interfaceConnection";
            this.interfaceConnection.Size = new System.Drawing.Size(290, 188);
            this.interfaceConnection.TabIndex = 14;
            this.interfaceConnection.Visible = false;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(91, 141);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(120, 28);
            this.btnConnecter.TabIndex = 15;
            this.btnConnecter.Text = "Ok";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(170, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Connexion";
            // 
            // interfaceMessage
            // 
            this.interfaceMessage.Controls.Add(this.username);
            this.interfaceMessage.Controls.Add(this.label6);
            this.interfaceMessage.Controls.Add(this.interfaceConnection);
            this.interfaceMessage.Controls.Add(this.btnEmoji);
            this.interfaceMessage.Controls.Add(this.emojis);
            this.interfaceMessage.Controls.Add(this.btnInterfaceConnecter);
            this.interfaceMessage.Controls.Add(this.checkBox1);
            this.interfaceMessage.Controls.Add(this.listUser);
            this.interfaceMessage.Controls.Add(this.btnEnvoyer);
            this.interfaceMessage.Controls.Add(this.receveurText);
            this.interfaceMessage.Controls.Add(this.txtMessage);
            this.interfaceMessage.Location = new System.Drawing.Point(2, 1);
            this.interfaceMessage.Name = "interfaceMessage";
            this.interfaceMessage.Size = new System.Drawing.Size(761, 457);
            this.interfaceMessage.TabIndex = 15;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(118, 8);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 24);
            this.username.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.Controls.Add(this.interfaceMessage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chat client";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.interfaceConnection.ResumeLayout(false);
            this.interfaceConnection.PerformLayout();
            this.interfaceMessage.ResumeLayout(false);
            this.interfaceMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox receveurText;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddresse;
        private System.Windows.Forms.Button btnInterfaceConnecter;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox emojis;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.Panel interfaceConnection;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel interfaceMessage;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label6;
    }
}

