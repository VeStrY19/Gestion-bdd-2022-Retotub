
namespace galvex {
    partial class Insert_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Form));
            this.txt_OF = new System.Windows.Forms.TextBox();
            this.galvexconditionnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synopticDataSet = new galvex.synopticDataSet();
            this.numericbox_qte = new System.Windows.Forms.NumericUpDown();
            this.numericbox_pds_tot = new System.Windows.Forms.NumericUpDown();
            this.numericbox_pds_pan = new System.Windows.Forms.NumericUpDown();
            this.Combox_zone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.bton_cancel = new System.Windows.Forms.Button();
            this.galvex_conditionnementTableAdapter = new galvex.synopticDataSetTableAdapters.galvex_conditionnementTableAdapter();
            this.galvex_zoneTableAdapter = new galvex.synopticDataSetTableAdapters.galvex_zoneTableAdapter();
            this.txt_pan = new System.Windows.Forms.TextBox();
            this.check_galv_pan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_com = new System.Windows.Forms.TextBox();
            this.galvexzoneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_article = new System.Windows.Forms.TextBox();
            this.txt_Desigart = new System.Windows.Forms.TextBox();
            this.txt_code2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.galvexzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_pds_prod = new System.Windows.Forms.TextBox();
            this.lbl_pds_tot = new System.Windows.Forms.Label();
            this.txt_pds_u = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.galvexconditionnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synopticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_pds_tot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_pds_pan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galvexzoneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galvexzoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_OF
            // 
            this.txt_OF.BackColor = System.Drawing.Color.White;
            this.txt_OF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_OF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.galvexconditionnementBindingSource, "NOOF", true));
            this.txt_OF.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OF.Location = new System.Drawing.Point(311, 9);
            this.txt_OF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_OF.MaxLength = 8;
            this.txt_OF.Name = "txt_OF";
            this.txt_OF.Size = new System.Drawing.Size(262, 51);
            this.txt_OF.TabIndex = 1;
            this.txt_OF.Tag = "0";
            this.txt_OF.TextChanged += new System.EventHandler(this.read_article);
            this.txt_OF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OF_KeyDown);
            // 
            // galvexconditionnementBindingSource
            // 
            this.galvexconditionnementBindingSource.DataMember = "galvex_conditionnement";
            this.galvexconditionnementBindingSource.DataSource = this.synopticDataSet;
            // 
            // synopticDataSet
            // 
            this.synopticDataSet.DataSetName = "synopticDataSet";
            this.synopticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericbox_qte
            // 
            this.numericbox_qte.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.galvexconditionnementBindingSource, "QTE", true));
            this.numericbox_qte.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericbox_qte.Location = new System.Drawing.Point(313, 269);
            this.numericbox_qte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numericbox_qte.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericbox_qte.Name = "numericbox_qte";
            this.numericbox_qte.Size = new System.Drawing.Size(264, 51);
            this.numericbox_qte.TabIndex = 3;
            this.numericbox_qte.Tag = "1";
            this.numericbox_qte.ValueChanged += new System.EventHandler(this.numericbox_qte_ValueChanged);
            // 
            // numericbox_pds_tot
            // 
            this.numericbox_pds_tot.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.galvexconditionnementBindingSource, "POIDS", true));
            this.numericbox_pds_tot.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericbox_pds_tot.Location = new System.Drawing.Point(313, 333);
            this.numericbox_pds_tot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numericbox_pds_tot.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericbox_pds_tot.Name = "numericbox_pds_tot";
            this.numericbox_pds_tot.Size = new System.Drawing.Size(264, 51);
            this.numericbox_pds_tot.TabIndex = 4;
            this.numericbox_pds_tot.Tag = "2";
            this.numericbox_pds_tot.ValueChanged += new System.EventHandler(this.numericbox_pds_tot_ValueChanged);
            // 
            // numericbox_pds_pan
            // 
            this.numericbox_pds_pan.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.galvexconditionnementBindingSource, "POIDS_PANIER", true));
            this.numericbox_pds_pan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericbox_pds_pan.Location = new System.Drawing.Point(313, 458);
            this.numericbox_pds_pan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numericbox_pds_pan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericbox_pds_pan.Name = "numericbox_pds_pan";
            this.numericbox_pds_pan.Size = new System.Drawing.Size(264, 51);
            this.numericbox_pds_pan.TabIndex = 6;
            this.numericbox_pds_pan.Tag = "7";
            this.numericbox_pds_pan.ValueChanged += new System.EventHandler(this.numericbox_pds_pan_ValueChanged);
            // 
            // Combox_zone
            // 
            this.Combox_zone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_zone.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combox_zone.FormattingEnabled = true;
            this.Combox_zone.Items.AddRange(new object[] {
            "Zone 1",
            "Zone 2"});
            this.Combox_zone.Location = new System.Drawing.Point(311, 204);
            this.Combox_zone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Combox_zone.Name = "Combox_zone";
            this.Combox_zone.Size = new System.Drawing.Size(262, 53);
            this.Combox_zone.TabIndex = 2;
            this.Combox_zone.Tag = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "OF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Poids Produit (kg) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "Numéro Panier :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 45);
            this.label6.TabIndex = 17;
            this.label6.Text = "Poids Panier (kg) :";
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(712, 702);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(207, 118);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Tag = "";
            this.btn_ok.Text = "Valider";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // bton_cancel
            // 
            this.bton_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bton_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bton_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bton_cancel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_cancel.Location = new System.Drawing.Point(927, 702);
            this.bton_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bton_cancel.Name = "bton_cancel";
            this.bton_cancel.Size = new System.Drawing.Size(207, 118);
            this.bton_cancel.TabIndex = 10;
            this.bton_cancel.Tag = "6";
            this.bton_cancel.Text = "Annuler";
            this.bton_cancel.UseVisualStyleBackColor = false;
            // 
            // galvex_conditionnementTableAdapter
            // 
            this.galvex_conditionnementTableAdapter.ClearBeforeFill = true;
            // 
            // galvex_zoneTableAdapter
            // 
            this.galvex_zoneTableAdapter.ClearBeforeFill = true;
            // 
            // txt_pan
            // 
            this.txt_pan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pan.Location = new System.Drawing.Point(313, 395);
            this.txt_pan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_pan.Name = "txt_pan";
            this.txt_pan.Size = new System.Drawing.Size(262, 51);
            this.txt_pan.TabIndex = 5;
            // 
            // check_galv_pan
            // 
            this.check_galv_pan.AutoSize = true;
            this.check_galv_pan.BackColor = System.Drawing.Color.White;
            this.check_galv_pan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_galv_pan.Location = new System.Drawing.Point(313, 585);
            this.check_galv_pan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.check_galv_pan.Name = "check_galv_pan";
            this.check_galv_pan.Size = new System.Drawing.Size(221, 49);
            this.check_galv_pan.TabIndex = 7;
            this.check_galv_pan.Text = "Galva Panier";
            this.check_galv_pan.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 649);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 45);
            this.label7.TabIndex = 18;
            this.label7.Text = "Commentaire :";
            // 
            // txt_com
            // 
            this.txt_com.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_com.Location = new System.Drawing.Point(311, 646);
            this.txt_com.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_com.Name = "txt_com";
            this.txt_com.Size = new System.Drawing.Size(564, 51);
            this.txt_com.TabIndex = 8;
            // 
            // galvexzoneBindingSource1
            // 
            this.galvexzoneBindingSource1.DataMember = "galvex_zone";
            this.galvexzoneBindingSource1.DataSource = this.synopticDataSet;
            // 
            // txt_article
            // 
            this.txt_article.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_article.Location = new System.Drawing.Point(750, 69);
            this.txt_article.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_article.Name = "txt_article";
            this.txt_article.ReadOnly = true;
            this.txt_article.Size = new System.Drawing.Size(125, 51);
            this.txt_article.TabIndex = 23;
            // 
            // txt_Desigart
            // 
            this.txt_Desigart.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desigart.Location = new System.Drawing.Point(311, 122);
            this.txt_Desigart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_Desigart.Multiline = true;
            this.txt_Desigart.Name = "txt_Desigart";
            this.txt_Desigart.ReadOnly = true;
            this.txt_Desigart.Size = new System.Drawing.Size(564, 72);
            this.txt_Desigart.TabIndex = 24;
            // 
            // txt_code2
            // 
            this.txt_code2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code2.Location = new System.Drawing.Point(311, 69);
            this.txt_code2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_code2.Name = "txt_code2";
            this.txt_code2.ReadOnly = true;
            this.txt_code2.Size = new System.Drawing.Size(418, 51);
            this.txt_code2.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 45);
            this.label8.TabIndex = 12;
            this.label8.Text = "Article :";
            // 
            // galvexzoneBindingSource
            // 
            this.galvexzoneBindingSource.DataMember = "galvex_zone";
            this.galvexzoneBindingSource.DataSource = this.synopticDataSet;
            // 
            // txt_pds_prod
            // 
            this.txt_pds_prod.Enabled = false;
            this.txt_pds_prod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pds_prod.Location = new System.Drawing.Point(311, 521);
            this.txt_pds_prod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_pds_prod.Name = "txt_pds_prod";
            this.txt_pds_prod.ReadOnly = true;
            this.txt_pds_prod.Size = new System.Drawing.Size(262, 51);
            this.txt_pds_prod.TabIndex = 26;
            // 
            // lbl_pds_tot
            // 
            this.lbl_pds_tot.AutoSize = true;
            this.lbl_pds_tot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pds_tot.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pds_tot.Location = new System.Drawing.Point(113, 335);
            this.lbl_pds_tot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pds_tot.Name = "lbl_pds_tot";
            this.lbl_pds_tot.Size = new System.Drawing.Size(191, 45);
            this.lbl_pds_tot.TabIndex = 27;
            this.lbl_pds_tot.Text = "Poids Total :";
            // 
            // txt_pds_u
            // 
            this.txt_pds_u.Enabled = false;
            this.txt_pds_u.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pds_u.Location = new System.Drawing.Point(908, 512);
            this.txt_pds_u.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_pds_u.Name = "txt_pds_u";
            this.txt_pds_u.ReadOnly = true;
            this.txt_pds_u.Size = new System.Drawing.Size(166, 51);
            this.txt_pds_u.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 515);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 45);
            this.label9.TabIndex = 29;
            this.label9.Text = "Poids Théorique (kg):";
            // 
            // Insert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.bton_cancel;
            this.ClientSize = new System.Drawing.Size(1136, 824);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pds_u);
            this.Controls.Add(this.lbl_pds_tot);
            this.Controls.Add(this.txt_pds_prod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_code2);
            this.Controls.Add(this.txt_Desigart);
            this.Controls.Add(this.txt_article);
            this.Controls.Add(this.txt_com);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.check_galv_pan);
            this.Controls.Add(this.txt_pan);
            this.Controls.Add(this.bton_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combox_zone);
            this.Controls.Add(this.numericbox_pds_pan);
            this.Controls.Add(this.numericbox_pds_tot);
            this.Controls.Add(this.numericbox_qte);
            this.Controls.Add(this.txt_OF);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Insert_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisie";
            ((System.ComponentModel.ISupportInitialize)(this.galvexconditionnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synopticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_pds_tot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_pds_pan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galvexzoneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galvexzoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_OF;
        private System.Windows.Forms.NumericUpDown numericbox_qte;
        private System.Windows.Forms.NumericUpDown numericbox_pds_tot;
        private System.Windows.Forms.NumericUpDown numericbox_pds_pan;
        private System.Windows.Forms.ComboBox Combox_zone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button bton_cancel;
        private synopticDataSet synopticDataSet;
        private System.Windows.Forms.BindingSource galvexconditionnementBindingSource;
        private synopticDataSetTableAdapters.galvex_conditionnementTableAdapter galvex_conditionnementTableAdapter;
        private synopticDataSetTableAdapters.galvex_zoneTableAdapter galvex_zoneTableAdapter;
        private System.Windows.Forms.BindingSource galvexzoneBindingSource1;
        private System.Windows.Forms.TextBox txt_pan;
        private System.Windows.Forms.CheckBox check_galv_pan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_com;
        private System.Windows.Forms.TextBox txt_article;
        private System.Windows.Forms.TextBox txt_Desigart;
        private System.Windows.Forms.TextBox txt_code2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource galvexzoneBindingSource;
        private System.Windows.Forms.TextBox txt_pds_prod;
        private System.Windows.Forms.Label lbl_pds_tot;
        private System.Windows.Forms.TextBox txt_pds_u;
        private System.Windows.Forms.Label label9;
    }
}