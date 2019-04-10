namespace Lab4_TB
{
    partial class Form1
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
            this.textBoxPrvi = new System.Windows.Forms.TextBox();
            this.textBoxDrugi = new System.Windows.Forms.TextBox();
            this.textBoxTreci = new System.Windows.Forms.TextBox();
            this.textBoxCetvrti = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPrvi
            // 
            this.textBoxPrvi.Location = new System.Drawing.Point(71, 35);
            this.textBoxPrvi.Name = "textBoxPrvi";
            this.textBoxPrvi.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrvi.TabIndex = 0;
            // 
            // textBoxDrugi
            // 
            this.textBoxDrugi.Location = new System.Drawing.Point(71, 83);
            this.textBoxDrugi.Name = "textBoxDrugi";
            this.textBoxDrugi.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrugi.TabIndex = 1;
            // 
            // textBoxTreci
            // 
            this.textBoxTreci.Location = new System.Drawing.Point(71, 148);
            this.textBoxTreci.Name = "textBoxTreci";
            this.textBoxTreci.Size = new System.Drawing.Size(100, 20);
            this.textBoxTreci.TabIndex = 2;
            // 
            // textBoxCetvrti
            // 
            this.textBoxCetvrti.Location = new System.Drawing.Point(71, 212);
            this.textBoxCetvrti.Name = "textBoxCetvrti";
            this.textBoxCetvrti.Size = new System.Drawing.Size(100, 20);
            this.textBoxCetvrti.TabIndex = 3;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(309, 126);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 4;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(561, 35);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(129, 197);
            this.textBoxRezultat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBoxCetvrti);
            this.Controls.Add(this.textBoxTreci);
            this.Controls.Add(this.textBoxDrugi);
            this.Controls.Add(this.textBoxPrvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrvi;
        private System.Windows.Forms.TextBox textBoxDrugi;
        private System.Windows.Forms.TextBox textBoxTreci;
        private System.Windows.Forms.TextBox textBoxCetvrti;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}

