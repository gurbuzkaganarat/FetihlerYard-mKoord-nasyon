using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FethlerV2
{
    public partial class formMaasTanim : Form
    {
        public formMaasTanim()
        {
            InitializeComponent();
        }
        FetihlerV2Entities1 db = new FetihlerV2Entities1();

        public void listele()
        {
            var query = from item in db.tbl_Maaslar
                        where item.Aktiflik == true
                        select new 
                        { 
                            item.MaasNo,
                            item.MaasAdi,
                            item.MaasDegeri,
                            
                        
                        
                        };
            bunifuCustomDataGrid1.DataSource = query.ToList();
            bunifuCustomDataGrid1.Columns[0].Visible = false;
        }
        public void temizle()
        {
            txtMaasAdi.Text = "";
            txtMaasDegeri.Text = "";
            lblMaasNo.Text = null;
        }

        private void formMaasTanim_Load(object sender, EventArgs e)
        {
            temizle();
            listele();

        }

       

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblMaasNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtMaasAdi.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtMaasDegeri.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value?.ToString();

            }
            catch 
            {

               
            }
            

        }

        void mükerrer()
        {
            var query = from d1 in db.tbl_Maaslar
                        where d1.Aktiflik == true
                        where d1.MaasAdi == txtMaasAdi.Text
                        select new
                        {
                            d1.MaasAdi
                        };
            var maasAdi = (from d1 in query select d1.MaasAdi).FirstOrDefault();
            var maasAdi2 = txtMaasAdi.Text;

            if (maasAdi==maasAdi2)
            {
                MessageBox.Show("Aynı Maaş Adına Sahip Kayıt Bulunmaktadır!");
            }
            else
            {
                if (lblMaasNo.Text == "")
                {
                    try
                    {
                        tbl_Maaslar maasTanim = new tbl_Maaslar();
                        if (string.IsNullOrEmpty(txtMaasAdi.Text) || string.IsNullOrEmpty(txtMaasDegeri.Text))
                        {
                            MessageBox.Show("Lütfen Eksik Alanları Doldurunuz");
                        }
                        else
                        {
                            maasTanim.MaasAdi = txtMaasAdi.Text;
                            var maasdegeri = Convert.ToInt32(txtMaasDegeri.Text);
                            maasTanim.MaasDegeri = maasdegeri;
                            maasTanim.Aktiflik = true;
                            db.tbl_Maaslar.Add(maasTanim);
                            db.SaveChanges();
                            MessageBox.Show("Maas Tanımı Basarıyla Kayıt Edildi");
                            listele();
                            temizle();
                        }

                    }
                    catch
                    {

                        MessageBox.Show("Lütfen Eksik Bilgileri Giriniz");
                    }

                }
                else
                {
                    MessageBox.Show("Kayıt Tekrarı Yapılamaz");
                }
            }
        }


       

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            mükerrer();
          
           
            
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (lblMaasNo.Text !="")
            {
                DialogResult onay;
                onay = MessageBox.Show("Kayıt silme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        int maasNo = Convert.ToInt32(lblMaasNo.Text);
                        var x = db.tbl_Maaslar.Find(maasNo);
                        x.Aktiflik = false;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Başarıyla Silindi");
                        temizle();
                        listele();
                    }
                    catch
                    {
                        MessageBox.Show("Kayıt Silinemedi");


                    }

                }
            }
            else
            {
                MessageBox.Show("Silinecek Kayıt Seçilmedi");
            }
           
            
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                int maasNo = Convert.ToInt32(lblMaasNo.Text);
                var g = db.tbl_Maaslar.Find(maasNo);
                g.MaasAdi = txtMaasAdi.Text;
                g.MaasDegeri = Convert.ToInt32(txtMaasDegeri.Text);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");
                temizle();
                listele();
            }
            catch
            {
                MessageBox.Show("Güncellenicek Kayıt Seçilmedi");

            }

        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
            listele();
        }

        private void txtMaasDegeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
