namespace PPE_Vallade
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
            this.label_param1 = new System.Windows.Forms.Label();
            this.label_param_2 = new System.Windows.Forms.Label();
            this.textBox_param1 = new System.Windows.Forms.TextBox();
            this.textBox_param2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_param1
            // 
            this.label_param1.AutoSize = true;
            this.label_param1.Location = new System.Drawing.Point(409, 28);
            this.label_param1.Name = "label_param1";
            this.label_param1.Size = new System.Drawing.Size(52, 13);
            this.label_param1.TabIndex = 0;
            this.label_param1.Text = "Param 1 :";
            // 
            // label_param_2
            // 
            this.label_param_2.AutoSize = true;
            this.label_param_2.Location = new System.Drawing.Point(409, 63);
            this.label_param_2.Name = "label_param_2";
            this.label_param_2.Size = new System.Drawing.Size(52, 13);
            this.label_param_2.TabIndex = 1;
            this.label_param_2.Text = "Param 2 :";
            // 
            // textBox_param1
            // 
            this.textBox_param1.Location = new System.Drawing.Point(498, 25);
            this.textBox_param1.Name = "textBox_param1";
            this.textBox_param1.Size = new System.Drawing.Size(100, 20);
            this.textBox_param1.TabIndex = 2;
            // 
            // textBox_param2
            // 
            this.textBox_param2.Location = new System.Drawing.Point(498, 60);
            this.textBox_param2.Name = "textBox_param2";
            this.textBox_param2.Size = new System.Drawing.Size(100, 20);
            this.textBox_param2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clients",
            "Produits",
            "Commandes",
            "Vendeurs",
            "Contenu des commandes"});
            this.comboBox1.Location = new System.Drawing.Point(98, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(498, 123);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_rechercher.TabIndex = 5;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 237);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_param2);
            this.Controls.Add(this.textBox_param1);
            this.Controls.Add(this.label_param_2);
            this.Controls.Add(this.label_param1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.Label label_param_2;
        private System.Windows.Forms.TextBox textBox_param1;
        private System.Windows.Forms.TextBox textBox_param2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

