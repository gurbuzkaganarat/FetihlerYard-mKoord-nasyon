namespace FethlerV2
{
    partial class formKisiListesi
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKisiListesi));
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FethlerV2.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new FethlerV2.DataSet1TableAdapters.DataTable1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBolgeNo = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnKaydet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbKoy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbBolge = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FethlerV2.kisiListesi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(868, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblBolgeNo);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.cmbKoy);
            this.panel1.Controls.Add(this.bunifuCustomLabel14);
            this.panel1.Controls.Add(this.cmbBolge);
            this.panel1.Location = new System.Drawing.Point(56, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 565);
            this.panel1.TabIndex = 90;
            // 
            // lblBolgeNo
            // 
            this.lblBolgeNo.AutoSize = true;
            this.lblBolgeNo.Location = new System.Drawing.Point(122, 12);
            this.lblBolgeNo.Name = "lblBolgeNo";
            this.lblBolgeNo.Size = new System.Drawing.Size(13, 13);
            this.lblBolgeNo.TabIndex = 88;
            this.lblBolgeNo.Text = "0";
            this.lblBolgeNo.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(53, 21);
            this.bunifuCustomLabel1.TabIndex = 62;
            this.bunifuCustomLabel1.Text = "Bölge";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AnimationHoverSpeed = 0.07F;
            this.btnKaydet.AnimationSpeed = 0.03F;
            this.btnKaydet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.btnKaydet.BorderColor = System.Drawing.Color.Transparent;
            this.btnKaydet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnKaydet.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnKaydet.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnKaydet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.CheckedImage")));
            this.btnKaydet.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKaydet.FocusedColor = System.Drawing.Color.Transparent;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageSize = new System.Drawing.Size(35, 35);
            this.btnKaydet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKaydet.Location = new System.Drawing.Point(662, 36);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKaydet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKaydet.OnHoverImage = null;
            this.btnKaydet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnPressedColor = System.Drawing.Color.Black;
            this.btnKaydet.Size = new System.Drawing.Size(182, 36);
            this.btnKaydet.TabIndex = 87;
            this.btnKaydet.Text = "Önizle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(240, 12);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(37, 21);
            this.bunifuCustomLabel5.TabIndex = 60;
            this.bunifuCustomLabel5.Text = "Köy";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Animated = true;
            this.cmbKategori.BackColor = System.Drawing.Color.Transparent;
            this.cmbKategori.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.cmbKategori.BorderThickness = 2;
            this.cmbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKategori.DropDownHeight = 200;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbKategori.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKategori.FocusedState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKategori.FocusedState.Parent = this.cmbKategori;
            this.cmbKategori.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbKategori.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKategori.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKategori.HoverState.Parent = this.cmbKategori;
            this.cmbKategori.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKategori.IntegralHeight = false;
            this.cmbKategori.ItemHeight = 30;
            this.cmbKategori.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKategori.ItemsAppearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKategori.ItemsAppearance.Parent = this.cmbKategori;
            this.cmbKategori.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.cmbKategori.ItemsAppearance.SelectedFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKategori.Location = new System.Drawing.Point(464, 36);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.ShadowDecoration.Parent = this.cmbKategori;
            this.cmbKategori.Size = new System.Drawing.Size(182, 36);
            this.cmbKategori.TabIndex = 83;
            this.cmbKategori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKategori_KeyDown);
            // 
            // cmbKoy
            // 
            this.cmbKoy.Animated = true;
            this.cmbKoy.BackColor = System.Drawing.Color.Transparent;
            this.cmbKoy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.cmbKoy.BorderThickness = 2;
            this.cmbKoy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKoy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKoy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbKoy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbKoy.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKoy.FocusedState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKoy.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKoy.FocusedState.Parent = this.cmbKoy;
            this.cmbKoy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKoy.FormattingEnabled = true;
            this.cmbKoy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbKoy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKoy.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKoy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKoy.HoverState.Parent = this.cmbKoy;
            this.cmbKoy.ItemHeight = 30;
            this.cmbKoy.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbKoy.ItemsAppearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKoy.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKoy.ItemsAppearance.Parent = this.cmbKoy;
            this.cmbKoy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.cmbKoy.ItemsAppearance.SelectedFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKoy.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbKoy.Location = new System.Drawing.Point(244, 36);
            this.cmbKoy.Name = "cmbKoy";
            this.cmbKoy.ShadowDecoration.Parent = this.cmbKoy;
            this.cmbKoy.Size = new System.Drawing.Size(182, 36);
            this.cmbKoy.TabIndex = 61;
            this.cmbKoy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKoy_KeyDown);
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(460, 12);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(76, 21);
            this.bunifuCustomLabel14.TabIndex = 82;
            this.bunifuCustomLabel14.Text = "Kategori";
            // 
            // cmbBolge
            // 
            this.cmbBolge.Animated = true;
            this.cmbBolge.BackColor = System.Drawing.Color.Transparent;
            this.cmbBolge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.cmbBolge.BorderThickness = 2;
            this.cmbBolge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBolge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbBolge.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbBolge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbBolge.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbBolge.FocusedState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolge.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbBolge.FocusedState.Parent = this.cmbBolge;
            this.cmbBolge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.cmbBolge.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbBolge.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolge.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbBolge.HoverState.Parent = this.cmbBolge;
            this.cmbBolge.ItemHeight = 30;
            this.cmbBolge.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cmbBolge.ItemsAppearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolge.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbBolge.ItemsAppearance.Parent = this.cmbBolge;
            this.cmbBolge.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.cmbBolge.ItemsAppearance.SelectedFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolge.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.cmbBolge.Location = new System.Drawing.Point(24, 36);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.ShadowDecoration.Parent = this.cmbBolge;
            this.cmbBolge.Size = new System.Drawing.Size(182, 36);
            this.cmbBolge.TabIndex = 63;
            this.cmbBolge.SelectionChangeCommitted += new System.EventHandler(this.cmbBolge_SelectionChangeCommitted);
            this.cmbBolge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBolge_KeyDown);
            // 
            // formKisiListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1358, 797);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formKisiListesi";
            this.Text = "formKisiListesi";
            this.Load += new System.EventHandler(this.formKisiListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBolgeNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnKaydet;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKategori;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKoy;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBolge;
    }
}