
namespace winform.forms
{
    partial class SupplierFormEdit
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
            this.Annuler = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Envoyer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Addresse = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Annuler
            // 
            this.Annuler.AutoSize = true;
            this.Annuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Annuler.Depth = 0;
            this.Annuler.Icon = null;
            this.Annuler.Location = new System.Drawing.Point(222, 311);
            this.Annuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.Annuler.Name = "Annuler";
            this.Annuler.Primary = true;
            this.Annuler.Size = new System.Drawing.Size(99, 36);
            this.Annuler.TabIndex = 11;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click_1);
            // 
            // Envoyer
            // 
            this.Envoyer.AutoSize = true;
            this.Envoyer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Envoyer.Depth = 0;
            this.Envoyer.Icon = null;
            this.Envoyer.Location = new System.Drawing.Point(484, 311);
            this.Envoyer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Envoyer.Name = "Envoyer";
            this.Envoyer.Primary = true;
            this.Envoyer.Size = new System.Drawing.Size(98, 36);
            this.Envoyer.TabIndex = 10;
            this.Envoyer.Text = "Envoyer";
            this.Envoyer.UseVisualStyleBackColor = true;
            this.Envoyer.Click += new System.EventHandler(this.Envoyer_Click);
            // 
            // Addresse
            // 
            this.Addresse.AutoSize = true;
            this.Addresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresse.Location = new System.Drawing.Point(218, 217);
            this.Addresse.Name = "Addresse";
            this.Addresse.Size = new System.Drawing.Size(91, 24);
            this.Addresse.TabIndex = 9;
            this.Addresse.Text = "Addresse";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(222, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 28);
            this.textBox2.TabIndex = 8;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(218, 104);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(51, 24);
            this.nom.TabIndex = 7;
            this.nom.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(222, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 28);
            this.textBox1.TabIndex = 6;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Envoyer);
            this.Controls.Add(this.Addresse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.textBox1);
            this.Name = "SupplierForm";
            this.Text = "Créer un fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton Annuler;
        private MaterialSkin.Controls.MaterialRaisedButton Envoyer;
        private System.Windows.Forms.Label Addresse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox textBox1;
    }
}