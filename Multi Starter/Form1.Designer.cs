namespace Multi_Starter
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mTboxP = new MetroFramework.Controls.MetroTextBox();
            this.mTBoxU = new MetroFramework.Controls.MetroTextBox();
            this.msmMainL = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mButtonMSM = new MetroFramework.Controls.MetroButton();
            this.mButtonSend = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMainL)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 254);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password:";
            // 
            // mTboxP
            // 
            this.mTboxP.Location = new System.Drawing.Point(33, 276);
            this.mTboxP.Name = "mTboxP";
            this.mTboxP.Size = new System.Drawing.Size(75, 23);
            this.mTboxP.TabIndex = 2;
            this.mTboxP.Text = "Password";
            // 
            // mTBoxU
            // 
            this.mTBoxU.Location = new System.Drawing.Point(30, 166);
            this.mTBoxU.Name = "mTBoxU";
            this.mTBoxU.Size = new System.Drawing.Size(75, 23);
            this.mTBoxU.TabIndex = 3;
            this.mTBoxU.Text = "Username";
            // 
            // msmMainL
            // 
            this.msmMainL.Owner = null;
            // 
            // mButtonMSM
            // 
            this.mButtonMSM.Location = new System.Drawing.Point(133, 63);
            this.mButtonMSM.Name = "mButtonMSM";
            this.mButtonMSM.Size = new System.Drawing.Size(39, 23);
            this.mButtonMSM.TabIndex = 4;
            this.mButtonMSM.Text = "Light";
            // 
            // mButtonSend
            // 
            this.mButtonSend.Location = new System.Drawing.Point(97, 343);
            this.mButtonSend.Name = "mButtonSend";
            this.mButtonSend.Size = new System.Drawing.Size(75, 23);
            this.mButtonSend.TabIndex = 5;
            this.mButtonSend.Text = "Send";
            this.mButtonSend.Click += new System.EventHandler(this.mButtonSend_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 479);
            this.Controls.Add(this.mButtonSend);
            this.Controls.Add(this.mButtonMSM);
            this.Controls.Add(this.mTBoxU);
            this.Controls.Add(this.mTboxP);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.msmMainL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mTboxP;
        private MetroFramework.Controls.MetroTextBox mTBoxU;
        private MetroFramework.Components.MetroStyleManager msmMainL;
        private MetroFramework.Controls.MetroButton mButtonMSM;
        private MetroFramework.Controls.MetroButton mButtonSend;
    }
}

