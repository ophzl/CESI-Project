
namespace winform.forms
{
    partial class PurchaseOrderForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Annuler = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Envoyer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Addresse = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Prix de vente";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(222, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 28);
            this.textBox3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Famille";
            // 
            // Annuler
            // 
            this.Annuler.AutoSize = true;
            this.Annuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Annuler.Depth = 0;
            this.Annuler.Icon = null;
            this.Annuler.Location = new System.Drawing.Point(222, 340);
            this.Annuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.Annuler.Name = "Annuler";
            this.Annuler.Primary = true;
            this.Annuler.Size = new System.Drawing.Size(99, 36);
            this.Annuler.TabIndex = 22;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            // 
            // Envoyer
            // 
            this.Envoyer.AutoSize = true;
            this.Envoyer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Envoyer.Depth = 0;
            this.Envoyer.Icon = null;
            this.Envoyer.Location = new System.Drawing.Point(484, 340);
            this.Envoyer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Envoyer.Name = "Envoyer";
            this.Envoyer.Primary = true;
            this.Envoyer.Size = new System.Drawing.Size(98, 36);
            this.Envoyer.TabIndex = 21;
            this.Envoyer.Text = "Envoyer";
            this.Envoyer.UseVisualStyleBackColor = true;
            // 
            // Addresse
            // 
            this.Addresse.AutoSize = true;
            this.Addresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresse.Location = new System.Drawing.Point(218, 164);
            this.Addresse.Name = "Addresse";
            this.Addresse.Size = new System.Drawing.Size(42, 24);
            this.Addresse.TabIndex = 20;
            this.Addresse.Text = "Prix";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(222, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 28);
            this.textBox2.TabIndex = 19;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(218, 77);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(51, 24);
            this.nom.TabIndex = 18;
            this.nom.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(222, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 28);
            this.textBox1.TabIndex = 17;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Envoyer);
            this.Controls.Add(this.Addresse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.textBox1);
            this.Name = "PurchaseOrderForm";
            this.Text = "Créer une commande au fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton Annuler;
        private MaterialSkin.Controls.MaterialRaisedButton Envoyer;
        private System.Windows.Forms.Label Addresse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox textBox1;
    }
}