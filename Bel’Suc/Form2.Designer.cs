namespace PPE_Vallade
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.textBox_Codepostal = new System.Windows.Forms.TextBox();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code postal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Télephone :";
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(204, 186);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(100, 20);
            this.textBox_telephone.TabIndex = 5;
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(204, 160);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ville.TabIndex = 6;
            // 
            // textBox_Codepostal
            // 
            this.textBox_Codepostal.Location = new System.Drawing.Point(204, 131);
            this.textBox_Codepostal.Name = "textBox_Codepostal";
            this.textBox_Codepostal.Size = new System.Drawing.Size(100, 20);
            this.textBox_Codepostal.TabIndex = 7;
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Location = new System.Drawing.Point(204, 101);
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adresse.TabIndex = 8;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(204, 74);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 9;
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(555, 74);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 10;
            this.button_Modifier.Text = "Enregistrer";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.textBox_Adresse);
            this.Controls.Add(this.textBox_Codepostal);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.textBox_telephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.TextBox textBox_Codepostal;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Button button_Modifier;
    }
}