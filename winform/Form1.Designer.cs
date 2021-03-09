
namespace winform
{
    partial class WineNot
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.wines = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.clients = new System.Windows.Forms.TabPage();
            this.Wine_Family = new System.Windows.Forms.TabPage();
            this.suppliers = new System.Windows.Forms.TabPage();
            this.suppliers_orders = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.wines.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(6, 387);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(123, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Actualiser";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 349);
            this.dataGridView1.TabIndex = 2;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.wines);
            this.materialTabControl1.Controls.Add(this.clients);
            this.materialTabControl1.Controls.Add(this.Wine_Family);
            this.materialTabControl1.Controls.Add(this.suppliers);
            this.materialTabControl1.Controls.Add(this.suppliers_orders);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 99);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1094, 467);
            this.materialTabControl1.TabIndex = 3;
            // 
            // wines
            // 
            this.wines.Controls.Add(this.materialFlatButton2);
            this.wines.Controls.Add(this.dataGridView1);
            this.wines.Controls.Add(this.materialFlatButton1);
            this.wines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wines.Location = new System.Drawing.Point(4, 25);
            this.wines.Name = "wines";
            this.wines.Padding = new System.Windows.Forms.Padding(3);
            this.wines.Size = new System.Drawing.Size(1086, 438);
            this.wines.TabIndex = 0;
            this.wines.Text = "Vins";
            this.wines.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(1002, 387);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton2.TabIndex = 4;
            this.materialFlatButton2.Text = "Créer";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            // 
            // clients
            // 
            this.clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clients.Location = new System.Drawing.Point(4, 25);
            this.clients.Name = "clients";
            this.clients.Padding = new System.Windows.Forms.Padding(3);
            this.clients.Size = new System.Drawing.Size(1086, 438);
            this.clients.TabIndex = 1;
            this.clients.Text = "Clients";
            this.clients.UseVisualStyleBackColor = true;
            // 
            // Wine_Family
            // 
            this.Wine_Family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wine_Family.Location = new System.Drawing.Point(4, 25);
            this.Wine_Family.Name = "Wine_Family";
            this.Wine_Family.Padding = new System.Windows.Forms.Padding(3);
            this.Wine_Family.Size = new System.Drawing.Size(1086, 438);
            this.Wine_Family.TabIndex = 2;
            this.Wine_Family.Text = "Familles de vin";
            this.Wine_Family.UseVisualStyleBackColor = true;
            // 
            // suppliers
            // 
            this.suppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliers.Location = new System.Drawing.Point(4, 25);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(1086, 438);
            this.suppliers.TabIndex = 3;
            this.suppliers.Text = "Fournisseurs";
            this.suppliers.UseVisualStyleBackColor = true;
            // 
            // suppliers_orders
            // 
            this.suppliers_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliers_orders.Location = new System.Drawing.Point(4, 25);
            this.suppliers_orders.Name = "suppliers_orders";
            this.suppliers_orders.Size = new System.Drawing.Size(1086, 438);
            this.suppliers_orders.TabIndex = 4;
            this.suppliers_orders.Text = "Commandes fournisseurs";
            this.suppliers_orders.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Padding = new System.Windows.Forms.Padding(20);
            this.materialTabSelector1.Size = new System.Drawing.Size(1094, 29);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // WineNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 577);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "WineNot";
            this.Text = "WineNot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.wines.ResumeLayout(false);
            this.wines.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage wines;
        private System.Windows.Forms.TabPage clients;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TabPage Wine_Family;
        private System.Windows.Forms.TabPage suppliers;
        private System.Windows.Forms.TabPage suppliers_orders;
    }
}

