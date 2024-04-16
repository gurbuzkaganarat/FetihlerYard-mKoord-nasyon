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
    public partial class formHastalikTanim : Form
    {
        public formHastalikTanim()
        {
            InitializeComponent();
        }
        FetihlerV2Entities1 db =  new FetihlerV2Entities1();

        public void listele()
        {
            var query = from item in db.tbl_Hastaliklar
                        where item.Aktiflik == true
                        select new
                        {
                            item.HastalikNo,
                            item.HastalikAdi

                        };
                        bunifuCustomDataGrid1.DataSource=query.ToList();
            bunifuCustomDataGrid1.Columns[0].Visible = false;

        }
        public void temizle()
        {
            txtHastalikAdi.Text = "";
            lblHastalikNo.Text = "";
            txtHastalikAdi.Focus();
        }
        private void formHastalikTanim_Load(object sender, EventArgs e)
        {
            listele();

        }


      

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblHastalikNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtHastalikAdi.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            }
            catch 
            {

                
            }
           
        }

       
        void mükerrer()
        {
            var query = from d1 in db.tbl_Hastaliklar
                        where d1.Aktiflik == true
                        where d1.HastalikAdi == txtHastalikAdi.Text
                        select new
                        {
                            d1.HastalikAdi
                        };
            var hastalikad = (from d1 in query select d1.HastalikAdi).FirstOrDefault();
            var hastalikad2 = txtHastalikAdi.Text;
            if (hastalikad == hastalikad2)
            {
                MessageBox.Show("Aynı Hastalık Adına Sahip Kayıt Bulunmaktadır!");
            }
            else
            {
                
                
                
                    if (lblHastalikNo.Text == "")
                    {
                        tbl_Hastaliklar hastalikTanim = new tbl_Hastaliklar();
                    if (string.IsNullOrEmpty(txtHastalikAdi.Text))
                    {
                        MessageBox.Show("Lütfen Eksik Alanları Doldurunuz.");
                    }
                    else
                    {
                        hastalikTanim.HastalikAdi = txtHastalikAdi.Text;
                        hastalikTanim.Aktiflik = true;
                        db.tbl_Hastaliklar.Add(hastalikTanim);
                        db.SaveChanges();
                        MessageBox.Show("Hastalık Başarıyla Kayıt Edildi");
                        listele();
                        temizle();
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
            if (lblHastalikNo.Text !="")
            {
                DialogResult onay;
                onay = MessageBox.Show("Kayıt silme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        int hastalikNo = Convert.ToInt32(lblHastalikNo.Text);
                        var x = db.tbl_Hastaliklar.Find(hastalikNo);
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

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                tbl_Hastaliklar hastalikTanim = new tbl_Hastaliklar();
                int hastalikNo = Convert.ToInt32(lblHastalikNo.Text);
                var g = db.tbl_Hastaliklar.Find(hastalikNo);
                g.HastalikAdi = txtHastalikAdi.Text;
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");

            }
            catch
            {
                MessageBox.Show("Güncellenicek Kayıt Seçilmedi");


            }
            listele();
            temizle();

        }
    }
}
