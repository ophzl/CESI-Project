
namespace winform
{
    partial class Wine
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
            this.materialFlatButton12 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton11 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Wine_Family = new System.Windows.Forms.TabPage();
            this.materialFlatButton16 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton15 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.suppliers = new System.Windows.Forms.TabPage();
            this.materialFlatButton14 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton13 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.suppliers_orders = new System.Windows.Forms.TabPage();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.materialFlatButton10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialFlatButton17 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton18 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.wines.SuspendLayout();
            this.clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Wine_Family.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.suppliers_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(7, 501);
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
            this.dataGridView1.Size = new System.Drawing.Size(1071, 472);
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
            this.materialTabControl1.Size = new System.Drawing.Size(1094, 572);
            this.materialTabControl1.TabIndex = 3;
            // 
            // wines
            // 
            this.wines.Controls.Add(this.materialFlatButton18);
            this.wines.Controls.Add(this.materialFlatButton17);
            this.wines.Controls.Add(this.materialFlatButton2);
            this.wines.Controls.Add(this.dataGridView1);
            this.wines.Controls.Add(this.materialFlatButton1);
            this.wines.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wines.Location = new System.Drawing.Point(4, 25);
            this.wines.Name = "wines";
            this.wines.Padding = new System.Windows.Forms.Padding(3);
            this.wines.Size = new System.Drawing.Size(1086, 543);
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
            this.materialFlatButton2.Location = new System.Drawing.Point(718, 501);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton2.TabIndex = 4;
            this.materialFlatButton2.Text = "Créer";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // clients
            // 
            this.clients.Controls.Add(this.materialFlatButton12);
            this.clients.Controls.Add(this.materialFlatButton11);
            this.clients.Controls.Add(this.materialFlatButton4);
            this.clients.Controls.Add(this.dataGridView2);
            this.clients.Controls.Add(this.materialFlatButton3);
            this.clients.Cursor = System.Windows.Forms.Cursors.Default;
            this.clients.Location = new System.Drawing.Point(4, 25);
            this.clients.Name = "clients";
            this.clients.Padding = new System.Windows.Forms.Padding(3);
            this.clients.Size = new System.Drawing.Size(1086, 543);
            this.clients.TabIndex = 1;
            this.clients.Text = "Clients";
            this.clients.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton12
            // 
            this.materialFlatButton12.AutoSize = true;
            this.materialFlatButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton12.Depth = 0;
            this.materialFlatButton12.Icon = null;
            this.materialFlatButton12.Location = new System.Drawing.Point(803, 494);
            this.materialFlatButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton12.Name = "materialFlatButton12";
            this.materialFlatButton12.Primary = false;
            this.materialFlatButton12.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton12.TabIndex = 7;
            this.materialFlatButton12.Text = "Mettre à jour";
            this.materialFlatButton12.UseVisualStyleBackColor = false;
            this.materialFlatButton12.Click += new System.EventHandler(this.materialFlatButton12_Click);
            // 
            // materialFlatButton11
            // 
            this.materialFlatButton11.AutoSize = true;
            this.materialFlatButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton11.Depth = 0;
            this.materialFlatButton11.Icon = null;
            this.materialFlatButton11.Location = new System.Drawing.Point(962, 494);
            this.materialFlatButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton11.Name = "materialFlatButton11";
            this.materialFlatButton11.Primary = false;
            this.materialFlatButton11.Size = new System.Drawing.Size(117, 36);
            this.materialFlatButton11.TabIndex = 6;
            this.materialFlatButton11.Text = "Supprimer";
            this.materialFlatButton11.UseVisualStyleBackColor = false;
            this.materialFlatButton11.Click += new System.EventHandler(this.materialFlatButton11_Click);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(721, 494);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton4.TabIndex = 5;
            this.materialFlatButton4.Text = "Créer";
            this.materialFlatButton4.UseVisualStyleBackColor = false;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 472);
            this.dataGridView2.TabIndex = 4;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(9, 494);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(123, 36);
            this.materialFlatButton3.TabIndex = 3;
            this.materialFlatButton3.Text = "Actualiser";
            this.materialFlatButton3.UseVisualStyleBackColor = false;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // Wine_Family
            // 
            this.Wine_Family.Controls.Add(this.materialFlatButton16);
            this.Wine_Family.Controls.Add(this.materialFlatButton15);
            this.Wine_Family.Controls.Add(this.materialFlatButton5);
            this.Wine_Family.Controls.Add(this.dataGridView3);
            this.Wine_Family.Controls.Add(this.materialFlatButton6);
            this.Wine_Family.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wine_Family.Location = new System.Drawing.Point(4, 25);
            this.Wine_Family.Name = "Wine_Family";
            this.Wine_Family.Padding = new System.Windows.Forms.Padding(3);
            this.Wine_Family.Size = new System.Drawing.Size(1086, 543);
            this.Wine_Family.TabIndex = 2;
            this.Wine_Family.Text = "Familles de vin";
            this.Wine_Family.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton16
            // 
            this.materialFlatButton16.AutoSize = true;
            this.materialFlatButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton16.Depth = 0;
            this.materialFlatButton16.Icon = null;
            this.materialFlatButton16.Location = new System.Drawing.Point(803, 494);
            this.materialFlatButton16.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton16.Name = "materialFlatButton16";
            this.materialFlatButton16.Primary = false;
            this.materialFlatButton16.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton16.TabIndex = 10;
            this.materialFlatButton16.Text = "Mettre à jour ";
            this.materialFlatButton16.UseVisualStyleBackColor = true;
            this.materialFlatButton16.Click += new System.EventHandler(this.materialFlatButton16_Click);
            // 
            // materialFlatButton15
            // 
            this.materialFlatButton15.AutoSize = true;
            this.materialFlatButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton15.Depth = 0;
            this.materialFlatButton15.Icon = null;
            this.materialFlatButton15.Location = new System.Drawing.Point(962, 494);
            this.materialFlatButton15.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton15.Name = "materialFlatButton15";
            this.materialFlatButton15.Primary = false;
            this.materialFlatButton15.Size = new System.Drawing.Size(117, 36);
            this.materialFlatButton15.TabIndex = 9;
            this.materialFlatButton15.Text = "Supprimer";
            this.materialFlatButton15.UseVisualStyleBackColor = true;
            this.materialFlatButton15.Click += new System.EventHandler(this.materialFlatButton15_Click);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(721, 494);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton5.TabIndex = 8;
            this.materialFlatButton5.Text = "Créer";
            this.materialFlatButton5.UseVisualStyleBackColor = false;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1071, 472);
            this.dataGridView3.TabIndex = 7;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(9, 494);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(123, 36);
            this.materialFlatButton6.TabIndex = 6;
            this.materialFlatButton6.Text = "Actualiser";
            this.materialFlatButton6.UseVisualStyleBackColor = false;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click);
            // 
            // suppliers
            // 
            this.suppliers.Controls.Add(this.materialFlatButton14);
            this.suppliers.Controls.Add(this.materialFlatButton13);
            this.suppliers.Controls.Add(this.materialFlatButton7);
            this.suppliers.Controls.Add(this.dataGridView4);
            this.suppliers.Controls.Add(this.materialFlatButton8);
            this.suppliers.Cursor = System.Windows.Forms.Cursors.Default;
            this.suppliers.Location = new System.Drawing.Point(4, 25);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(1086, 543);
            this.suppliers.TabIndex = 3;
            this.suppliers.Text = "Fournisseurs";
            this.suppliers.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton14
            // 
            this.materialFlatButton14.AutoSize = true;
            this.materialFlatButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton14.Depth = 0;
            this.materialFlatButton14.Icon = null;
            this.materialFlatButton14.Location = new System.Drawing.Point(804, 494);
            this.materialFlatButton14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton14.Name = "materialFlatButton14";
            this.materialFlatButton14.Primary = false;
            this.materialFlatButton14.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton14.TabIndex = 15;
            this.materialFlatButton14.Text = "Mettre à jour";
            this.materialFlatButton14.UseVisualStyleBackColor = true;
            this.materialFlatButton14.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialFlatButton13
            // 
            this.materialFlatButton13.AutoSize = true;
            this.materialFlatButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton13.Depth = 0;
            this.materialFlatButton13.Icon = null;
            this.materialFlatButton13.Location = new System.Drawing.Point(962, 494);
            this.materialFlatButton13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton13.Name = "materialFlatButton13";
            this.materialFlatButton13.Primary = false;
            this.materialFlatButton13.Size = new System.Drawing.Size(117, 36);
            this.materialFlatButton13.TabIndex = 14;
            this.materialFlatButton13.Text = "Supprimer";
            this.materialFlatButton13.UseVisualStyleBackColor = true;
            this.materialFlatButton13.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(722, 494);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton7.TabIndex = 11;
            this.materialFlatButton7.Text = "Créer";
            this.materialFlatButton7.UseVisualStyleBackColor = false;
            this.materialFlatButton7.Click += new System.EventHandler(this.materialFlatButton7_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(8, 13);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1071, 472);
            this.dataGridView4.TabIndex = 10;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Icon = null;
            this.materialFlatButton8.Location = new System.Drawing.Point(9, 494);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(123, 36);
            this.materialFlatButton8.TabIndex = 9;
            this.materialFlatButton8.Text = "Actualiser";
            this.materialFlatButton8.UseVisualStyleBackColor = false;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click);
            // 
            // suppliers_orders
            // 
            this.suppliers_orders.Controls.Add(this.materialFlatButton9);
            this.suppliers_orders.Controls.Add(this.dataGridView5);
            this.suppliers_orders.Controls.Add(this.materialFlatButton10);
            this.suppliers_orders.Cursor = System.Windows.Forms.Cursors.Default;
            this.suppliers_orders.Location = new System.Drawing.Point(4, 25);
            this.suppliers_orders.Name = "suppliers_orders";
            this.suppliers_orders.Size = new System.Drawing.Size(1086, 543);
            this.suppliers_orders.TabIndex = 4;
            this.suppliers_orders.Text = "Commandes fournisseurs";
            this.suppliers_orders.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Icon = null;
            this.materialFlatButton9.Location = new System.Drawing.Point(1005, 494);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton9.TabIndex = 14;
            this.materialFlatButton9.Text = "Créer";
            this.materialFlatButton9.UseVisualStyleBackColor = false;
            this.materialFlatButton9.Click += new System.EventHandler(this.materialFlatButton9_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(8, 13);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(1071, 472);
            this.dataGridView5.TabIndex = 13;
            // 
            // materialFlatButton10
            // 
            this.materialFlatButton10.AutoSize = true;
            this.materialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButton10.Depth = 0;
            this.materialFlatButton10.Icon = null;
            this.materialFlatButton10.Location = new System.Drawing.Point(9, 494);
            this.materialFlatButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton10.Name = "materialFlatButton10";
            this.materialFlatButton10.Primary = false;
            this.materialFlatButton10.Size = new System.Drawing.Size(123, 36);
            this.materialFlatButton10.TabIndex = 12;
            this.materialFlatButton10.Text = "Actualiser";
            this.materialFlatButton10.UseVisualStyleBackColor = false;
            this.materialFlatButton10.Click += new System.EventHandler(this.materialFlatButton10_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Padding = new System.Windows.Forms.Padding(20);
            this.materialTabSelector1.Size = new System.Drawing.Size(1094, 29);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialFlatButton17
            // 
            this.materialFlatButton17.AutoSize = true;
            this.materialFlatButton17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton17.Depth = 0;
            this.materialFlatButton17.Icon = null;
            this.materialFlatButton17.Location = new System.Drawing.Point(800, 501);
            this.materialFlatButton17.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton17.Name = "materialFlatButton17";
            this.materialFlatButton17.Primary = false;
            this.materialFlatButton17.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton17.TabIndex = 5;
            this.materialFlatButton17.Text = "Mettre à jour";
            this.materialFlatButton17.UseVisualStyleBackColor = true;
            this.materialFlatButton17.Click += new System.EventHandler(this.materialFlatButton17_Click);
            // 
            // materialFlatButton18
            // 
            this.materialFlatButton18.AutoSize = true;
            this.materialFlatButton18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton18.Depth = 0;
            this.materialFlatButton18.Icon = null;
            this.materialFlatButton18.Location = new System.Drawing.Point(959, 501);
            this.materialFlatButton18.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton18.Name = "materialFlatButton18";
            this.materialFlatButton18.Primary = false;
            this.materialFlatButton18.Size = new System.Drawing.Size(117, 36);
            this.materialFlatButton18.TabIndex = 6;
            this.materialFlatButton18.Text = "Supprimer";
            this.materialFlatButton18.UseVisualStyleBackColor = true;
            this.materialFlatButton18.Click += new System.EventHandler(this.materialFlatButton18_Click);
            // 
            // Wine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Wine";
            this.Text = "WineNot";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.wines.ResumeLayout(false);
            this.wines.PerformLayout();
            this.clients.ResumeLayout(false);
            this.clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Wine_Family.ResumeLayout(false);
            this.Wine_Family.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.suppliers.ResumeLayout(false);
            this.suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.suppliers_orders.ResumeLayout(false);
            this.suppliers_orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
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
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private System.Windows.Forms.DataGridView dataGridView5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton10;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton11;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton12;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton14;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton13;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton15;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton16;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton18;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton17;
    }
}

