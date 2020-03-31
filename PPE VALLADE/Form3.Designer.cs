namespace PPE_Vallade
{
    partial class Form3
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
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.textBox_Codepostal = new System.Windows.Forms.TextBox();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(245, 107);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 19;
            this.textBox_Nom.TextChanged += new System.EventHandler(this.textBox_Nom_TextChanged);
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Location = new System.Drawing.Point(245, 134);
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adresse.TabIndex = 18;
            this.textBox_Adresse.TextChanged += new System.EventHandler(this.textBox_Adresse_TextChanged);
            // 
            // textBox_Codepostal
            // 
            this.textBox_Codepostal.Location = new System.Drawing.Point(245, 164);
            this.textBox_Codepostal.Name = "textBox_Codepostal";
            this.textBox_Codepostal.Size = new System.Drawing.Size(100, 20);
            this.textBox_Codepostal.TabIndex = 17;
            this.textBox_Codepostal.TextChanged += new System.EventHandler(this.textBox_Codepostal_TextChanged);
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(245, 193);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ville.TabIndex = 16;
            this.textBox_Ville.TextChanged += new System.EventHandler(this.textBox_Ville_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Designation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantite :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prix unitaire ht :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Stock :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.textBox_Adresse);
            this.Controls.Add(this.textBox_Codepostal);
            this.Controls.Add(this.textBox_Ville);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.TextBox textBox_Codepostal;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}