namespace Exercice1
{
    partial class mainForm
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
            this.domainCB = new System.Windows.Forms.ComboBox();
            this.formationLB = new System.Windows.Forms.ListBox();
            this.lieuGP = new System.Windows.Forms.GroupBox();
            this.OptionCLB = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.lieuGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainCB
            // 
            this.domainCB.FormattingEnabled = true;
            this.domainCB.Location = new System.Drawing.Point(12, 38);
            this.domainCB.Name = "domainCB";
            this.domainCB.Size = new System.Drawing.Size(121, 21);
            this.domainCB.TabIndex = 0;
            this.domainCB.SelectedIndexChanged += new System.EventHandler(this.domainCB_SelectedIndexChanged);
            // 
            // formationLB
            // 
            this.formationLB.FormattingEnabled = true;
            this.formationLB.Location = new System.Drawing.Point(13, 85);
            this.formationLB.Name = "formationLB";
            this.formationLB.Size = new System.Drawing.Size(160, 82);
            this.formationLB.TabIndex = 1;
            this.formationLB.SelectedIndexChanged += new System.EventHandler(this.formationLB_SelectedIndexChanged);
            // 
            // lieuGP
            // 
            this.lieuGP.Controls.Add(this.radioButton2);
            this.lieuGP.Controls.Add(this.radioButton1);
            this.lieuGP.Location = new System.Drawing.Point(13, 184);
            this.lieuGP.Name = "lieuGP";
            this.lieuGP.Size = new System.Drawing.Size(160, 74);
            this.lieuGP.TabIndex = 3;
            this.lieuGP.TabStop = false;
            this.lieuGP.Text = "lieu";
            // 
            // OptionCLB
            // 
            this.OptionCLB.FormattingEnabled = true;
            this.OptionCLB.Location = new System.Drawing.Point(216, 85);
            this.OptionCLB.Name = "OptionCLB";
            this.OptionCLB.Size = new System.Drawing.Size(152, 79);
            this.OptionCLB.TabIndex = 4;
        //    this.OptionCLB.SelectedIndexChanged += new System.EventHandler(this.OptionCLB_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inter Entreprises";
            this.radioButton1.UseVisualStyleBackColor = true;
      //      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Intra Entreprises";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(43, 307);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(90, 23);
            this.ValidateBtn.TabIndex = 5;
            this.ValidateBtn.Text = "Valider";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(162, 307);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "Annuler";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Quitbtn
            // 
            this.Quitbtn.Location = new System.Drawing.Point(274, 307);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(75, 23);
            this.Quitbtn.TabIndex = 7;
            this.Quitbtn.Text = "Quitter";
            this.Quitbtn.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 362);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.OptionCLB);
            this.Controls.Add(this.lieuGP);
            this.Controls.Add(this.formationLB);
            this.Controls.Add(this.domainCB);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.lieuGP.ResumeLayout(false);
            this.lieuGP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox domainCB;
        private System.Windows.Forms.ListBox formationLB;
        private System.Windows.Forms.GroupBox lieuGP;
        private System.Windows.Forms.CheckedListBox OptionCLB;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Quitbtn;
    }
}

