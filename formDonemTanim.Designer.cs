namespace FethlerV2
{
    partial class donemTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donemTanim));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemizle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGuncelle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnKaydet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtPaketAgirligi = new Guna.UI.WinForms.GunaTextBox();
            this.txtDonemAdi = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDonemNo = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtPaketAgirligi);
            this.panel1.Controls.Add(this.txtDonemAdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDonemNo);
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(202, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 306);
            this.panel1.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.AnimationHoverSpeed = 0.07F;
            this.btnTemizle.AnimationSpeed = 0.03F;
            this.btnTemizle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.btnTemizle.BorderColor = System.Drawing.Color.Transparent;
            this.btnTemizle.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTemizle.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnTemizle.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.CheckedImage")));
            this.btnTemizle.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTemizle.FocusedColor = System.Drawing.Color.Transparent;
            this.btnTemizle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTemizle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.Location = new System.Drawing.Point(160, 223);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.OnHoverImage")));
            this.btnTemizle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnTemizle.OnPressedColor = System.Drawing.Color.Black;
            this.btnTemizle.Size = new System.Drawing.Size(119, 36);
            this.btnTemizle.TabIndex = 105;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.AnimationHoverSpeed = 0.07F;
            this.btnSil.AnimationSpeed = 0.03F;
            this.btnSil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.btnSil.BorderColor = System.Drawing.Color.Transparent;
            this.btnSil.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSil.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSil.CheckedForeColor = System.Drawing.Color.Transparent;
            this.btnSil.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSil.CheckedImage")));
            this.btnSil.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSil.FocusedColor = System.Drawing.Color.Transparent;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSil.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.Location = new System.Drawing.Point(160, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSil.OnHoverImage")));
            this.btnSil.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnSil.OnPressedColor = System.Drawing.Color.Black;
            this.btnSil.Size = new System.Drawing.Size(119, 36);
            this.btnSil.TabIndex = 104;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AnimationHoverSpeed = 0.07F;
            this.btnGuncelle.AnimationSpeed = 0.03F;
            this.btnGuncelle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.btnGuncelle.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnGuncelle.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGuncelle.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnGuncelle.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.CheckedImage")));
            this.btnGuncelle.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuncelle.FocusedColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageSize = new System.Drawing.Size(35, 35);
            this.btnGuncelle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGuncelle.Location = new System.Drawing.Point(20, 223);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnGuncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuncelle.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.OnHoverImage")));
            this.btnGuncelle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnGuncelle.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuncelle.Size = new System.Drawing.Size(119, 36);
            this.btnGuncelle.TabIndex = 103;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnKaydet.Location = new System.Drawing.Point(20, 162);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKaydet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKaydet.OnHoverImage = null;
            this.btnKaydet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.btnKaydet.Size = new System.Drawing.Size(119, 36);
            this.btnKaydet.TabIndex = 102;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // txtPaketAgirligi
            // 
            this.txtPaketAgirligi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtPaketAgirligi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.txtPaketAgirligi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaketAgirligi.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtPaketAgirligi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.txtPaketAgirligi.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtPaketAgirligi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPaketAgirligi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtPaketAgirligi.Location = new System.Drawing.Point(20, 117);
            this.txtPaketAgirligi.MaxLength = 4;
            this.txtPaketAgirligi.Name = "txtPaketAgirligi";
            this.txtPaketAgirligi.PasswordChar = '\0';
            this.txtPaketAgirligi.SelectedText = "";
            this.txtPaketAgirligi.Size = new System.Drawing.Size(67, 30);
            this.txtPaketAgirligi.TabIndex = 53;
            this.txtPaketAgirligi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaketAgirligi_KeyPress_1);
            // 
            // txtDonemAdi
            // 
            this.txtDonemAdi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtDonemAdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.txtDonemAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonemAdi.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtDonemAdi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.txtDonemAdi.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtDonemAdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDonemAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtDonemAdi.Location = new System.Drawing.Point(20, 50);
            this.txtDonemAdi.Name = "txtDonemAdi";
            this.txtDonemAdi.PasswordChar = '\0';
            this.txtDonemAdi.SelectedText = "";
            this.txtDonemAdi.Size = new System.Drawing.Size(259, 30);
            this.txtDonemAdi.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(93, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "KG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paket Ağırlığı";
            // 
            // lblDonemNo
            // 
            this.lblDonemNo.AutoSize = true;
            this.lblDonemNo.Location = new System.Drawing.Point(20, 4);
            this.lblDonemNo.Name = "lblDonemNo";
            this.lblDonemNo.Size = new System.Drawing.Size(0, 13);
            this.lblDonemNo.TabIndex = 15;
            this.lblDonemNo.Visible = false;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(314, 26);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(376, 250);
            this.bunifuCustomDataGrid1.TabIndex = 10;
            this.bunifuCustomDataGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuCustomDataGrid1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dönem Adı";
            // 
            // donemTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1326, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "donemTanim";
            this.Text = "formDonemTanim";
            this.Load += new System.EventHandler(this.formDonemTanim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDonemNo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtDonemAdi;
        private Guna.UI.WinForms.GunaTextBox txtPaketAgirligi;
        private Guna.UI.WinForms.GunaAdvenceButton btnTemizle;
        private Guna.UI.WinForms.GunaAdvenceButton btnSil;
        private Guna.UI.WinForms.GunaAdvenceButton btnGuncelle;
        private Guna.UI.WinForms.GunaAdvenceButton btnKaydet;
    }
}