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
            this.prospectLB = new System.Windows.Forms.ListBox();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.PrenomTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.contactDTP = new System.Windows.Forms.DateTimePicker();
            this.notesTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prospectLB
            // 
            this.prospectLB.FormattingEnabled = true;
            this.prospectLB.Location = new System.Drawing.Point(-2, -2);
            this.prospectLB.Name = "prospectLB";
            this.prospectLB.Size = new System.Drawing.Size(120, 394);
            this.prospectLB.TabIndex = 0;
            this.prospectLB.SelectedIndexChanged += new System.EventHandler(this.prospectLB_SelectedIndexChanged);
            // 
            // NomTB
            // 
            this.NomTB.Location = new System.Drawing.Point(259, 53);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(216, 20);
            this.NomTB.TabIndex = 1;
            // 
            // PrenomTB
            // 
            this.PrenomTB.Location = new System.Drawing.Point(259, 99);
            this.PrenomTB.Name = "PrenomTB";
            this.PrenomTB.Size = new System.Drawing.Size(216, 20);
            this.PrenomTB.TabIndex = 2;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(259, 145);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(216, 20);
            this.mailTB.TabIndex = 3;
            // 
            // contactDTP
            // 
            this.contactDTP.Location = new System.Drawing.Point(259, 196);
            this.contactDTP.Name = "contactDTP";
            this.contactDTP.Size = new System.Drawing.Size(216, 20);
            this.contactDTP.TabIndex = 4;
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(259, 245);
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(216, 103);
            this.notesTB.TabIndex = 5;
            this.notesTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Courriel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dernier Contact";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Notes";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(125, 354);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(26, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(391, 354);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 12;
            this.acceptBtn.Text = "`Valider";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 389);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.contactDTP);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.PrenomTB);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.prospectLB);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox prospectLB;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.TextBox PrenomTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.DateTimePicker contactDTP;
        private System.Windows.Forms.RichTextBox notesTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button acceptBtn;
    }
}

