namespace serverUI
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
            this.consoleServer = new System.Windows.Forms.ListBox();
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // consoleServer
            // 
            this.consoleServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.consoleServer.ForeColor = System.Drawing.Color.SpringGreen;
            this.consoleServer.FormattingEnabled = true;
            this.consoleServer.Location = new System.Drawing.Point(12, 12);
            this.consoleServer.Name = "consoleServer";
            this.consoleServer.Size = new System.Drawing.Size(445, 433);
            this.consoleServer.TabIndex = 0;
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Location = new System.Drawing.Point(38, 451);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(396, 34);
            this.btnDemarrer.TabIndex = 1;
            this.btnDemarrer.Text = "Start server";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(470, 514);
            this.Controls.Add(this.btnDemarrer);
            this.Controls.Add(this.consoleServer);
            this.Name = "Form1";
            this.Text = "Chat serveur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox consoleServer;
        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Timer timer;
    }
}

