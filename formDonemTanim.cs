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
    public partial class donemTanim : Form
    {
        public donemTanim()
        {
            InitializeComponent();
        }
        FetihlerV2Entities1 db = new FetihlerV2Entities1();

        public  void listele()
        {
            var query = from item in db.tbl_Donemler
                        where item.Aktiflik == true
                        select new
                        {
                            item.DonemNo,
                            item.DonemAdi,
                            item.PaketAgirligi,

                        };
            bunifuCustomDataGrid1.DataSource = query.ToList();
            bunifuCustomDataGrid1.Columns[0].Visible = false;

        }
        public void temizle()
        {
            lblDonemNo.Text = null;
            txtDonemAdi.Text = "";
            txtPaketAgirligi.Text = "";
            txtDonemAdi.Focus();

        }

       

        private void formDonemTanim_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void txtPaketAgirligi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblDonemNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtDonemAdi.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtPaketAgirligi.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            }
            catch 
            {

                
            }
         
        }

        void mükerrer()
        {
            var query = from d1 in db.tbl_Donemler
                        where d1.Aktiflik == true
                        where d1.DonemAdi == txtDonemAdi.Text
                        select new
                        {
                            d1.DonemAdi
                        };
            var donemAdi = (from d1 in query select d1.DonemAdi).FirstOrDefault();
            var donemAdi2 = txtDonemAdi.Text;
            if (donemAdi==donemAdi2)
            {
                MessageBox.Show("Aynı Dönem Adına Sahip Kayıt Bulunmaktadır");
            }
            else
            {
                if (lblDonemNo.Text == "")
                {
                    try
                    {
                        tbl_Donemler donemTanim = new tbl_Donemler();
                        if (string.IsNullOrEmpty(txtDonemAdi.Text) || string.IsNullOrEmpty(txtPaketAgirligi.Text))
                        {
                            MessageBox.Show("Lütfen Eksik Alanları Doldurunuz");
                        }
                        else
                        {
                            donemTanim.Aktiflik = true;
                            donemTanim.DonemAdi = txtDonemAdi.Text;
                            donemTanim.PaketAgirligi = Convert.ToInt32(txtPaketAgirligi.Text);
                            db.tbl_Donemler.Add(donemTanim);
                            db.SaveChanges();
                            MessageBox.Show("Dönem Başarıyla Kayıt Edildi.");
                            listele();
                            temizle();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Eksik Bilgileri Doldurunuz");

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblDonemNo.Text !="")
            {
                DialogResult onay;
                onay = MessageBox.Show("Kayıt silme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        int donemNo = Convert.ToInt32(lblDonemNo.Text);
                        var x = db.tbl_Donemler.Find(donemNo);
                        x.Aktiflik = false;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Başarıyla Silindi");
                        listele();
                        temizle();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int donemNo = Convert.ToInt32(lblDonemNo.Text);
                var g = db.tbl_Donemler.Find(donemNo);
                g.DonemAdi = txtDonemAdi.Text;
                g.PaketAgirligi = Convert.ToInt32(txtPaketAgirligi.Text);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Güncellenicek Kayıt Seçilmedi");

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            listele();
        }

        private void txtPaketAgirligi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
