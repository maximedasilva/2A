namespace Exercice2
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
            this.beginBtn = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.clickBtn = new System.Windows.Forms.Button();
            this.cptLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beginBtn
            // 
            this.beginBtn.Location = new System.Drawing.Point(91, 39);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(104, 23);
            this.beginBtn.TabIndex = 0;
            this.beginBtn.Text = "Démarrer!";
            this.beginBtn.UseVisualStyleBackColor = true;
            this.beginBtn.Click += new System.EventHandler(this.beginBtn_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(80, 122);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(125, 20);
            this.mainTextBox.TabIndex = 1;
            // 
            // clickBtn
            // 
            this.clickBtn.Location = new System.Drawing.Point(91, 173);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(104, 23);
            this.clickBtn.TabIndex = 2;
            this.clickBtn.Text = "Cliquez moi!!";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            // 
            // cptLbl
            // 
            this.cptLbl.AutoSize = true;
            this.cptLbl.Location = new System.Drawing.Point(129, 227);
            this.cptLbl.Name = "cptLbl";
            this.cptLbl.Size = new System.Drawing.Size(13, 13);
            this.cptLbl.TabIndex = 3;
            this.cptLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cptLbl);
            this.Controls.Add(this.clickBtn);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.beginBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Label cptLbl;
    }
}

