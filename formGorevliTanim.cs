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
    public partial class formGorevliTanim : Form
    {
        public formGorevliTanim()
        {
            InitializeComponent();
        }

        FetihlerV2Entities1 db = new FetihlerV2Entities1();
       
        public void listele()
        { 
            var query = from d1 in db.tbl_Gorevliler
                                                                                                                                                                    
                        where d1.Aktiflik == true
                        select new
                        {
                           GorevliNo= d1.GorevliNo,
                           Ad = d1.GorevliAd,
                           SoyAd=d1.GorevliSoyAd,
                          
                           
                           Telefon=d1.GorevliTel,
                           Cinsiyet=d1.GorevliCinsiyet,
                           
                           
                                                                           
                            

                        };
            
            bunifuCustomDataGrid1.DataSource = query.ToList();
            bunifuCustomDataGrid1.Columns[0].Visible = false;
            


        }

        void mükerrer()
        {
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        where d1.GorevliAd == txtGorevliAd.Text
                        where d1.GorevliSoyAd == txtGorevliSoyAd.Text
                        select new
                        {
                            adsoyad = d1.GorevliAd + ""+d1.GorevliSoyAd

                        };

            var tamad = (from d1 in query select d1.adsoyad).FirstOrDefault();
            dene.Text = tamad;


            var ad = txtGorevliAd.Text;
            var soyad = txtGorevliSoyAd.Text;
            var adsoyad = ad + soyad;
            
            if (adsoyad==tamad)
            {
                MessageBox.Show("Aynı Ad Soyada Sahip Kayıt Bulunmaktadır!");
            }
            else
            {
                 if (lblGorevliNo.Text=="")
            {
                    tbl_Gorevliler gorevliTanim = new tbl_Gorevliler();
                
                if (string.IsNullOrEmpty(txtGorevliAd.Text) || string.IsNullOrEmpty(txtGorevliSoyAd.Text))
                {
                    MessageBox.Show("Lütfen Eksik Alanları Doldurunuz.");
                    

                }
                else
                {

                    gorevliTanim.GorevliAd = txtGorevliAd.Text;
                    gorevliTanim.GorevliSoyAd = txtGorevliSoyAd.Text;
                    
                    
                    gorevliTanim.GorevliTel = txtGorevliTel.Text;
                    gorevliTanim.Seç = false;



                    if (rdoErkek.Checked == true)
                    {
                        gorevliTanim.GorevliCinsiyet = rdoErkek.Text;


                    }
                    else
                    {
                        if (rdoKadın.Checked == true)
                        {
                            gorevliTanim.GorevliCinsiyet = rdoKadın.Text;
                        }
                    }

                    gorevliTanim.Aktiflik = true;
                    db.tbl_Gorevliler.Add(gorevliTanim);

                    db.SaveChanges();
                    MessageBox.Show("Görevli Başarıyla Kayıt Edildi");
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

       




              

        

        public void temizle()
        {
            lblGorevliNo.Text = "";
            txtGorevliAd.Text = "";
            txtGorevliSoyAd.Text = "";
            txtGorevliTel.Text = "";
            
            rdoErkek.Checked = false;
            rdoKadın.Checked = false;
            txtGorevliAd.Focus();

        }



        

        private void formGorevliTanim_Load(object sender, EventArgs e)
        {
            

            listele();           
            temizle();



        }

     

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                lblGorevliNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value?.ToString();

                txtGorevliAd.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtGorevliSoyAd.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value?.ToString();
               
                txtGorevliTel.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value?.ToString() == rdoErkek.Text)
                {
                    rdoErkek.Checked = true;


                }
                if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value?.ToString() == rdoKadın.Text)
                {
                    rdoKadın.Checked = true;

                }
                if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value?.ToString() == null)
                {
                    rdoKadın.Checked = false;
                    rdoErkek.Checked = false;
                }

            }
            catch 
            {
                MessageBox.Show("");

                
            }
            


        }

       

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {


            mükerrer();
            

            
           /* if (lblGorevliNo.Text=="")
            {
                tbl_Gorevliler gorevliTanim = new tbl_Gorevliler();
                
                if (string.IsNullOrEmpty(txtGorevliAd.Text) || string.IsNullOrEmpty(txtGorevliSoyAd.Text))
                {
                    MessageBox.Show("Lütfen Eksik Alanları Doldurunuz.");
                    

                }
                else
                {

                    gorevliTanim.GorevliAd = txtGorevliAd.Text;
                    gorevliTanim.GorevliSoyAd = txtGorevliSoyAd.Text;
                    
                    
                    gorevliTanim.GorevliTel = txtGorevliTel.Text;
                    gorevliTanim.Seç = false;



                    if (rdoErkek.Checked == true)
                    {
                        gorevliTanim.GorevliCinsiyet = rdoErkek.Text;


                    }
                    else
                    {
                        if (rdoKadın.Checked == true)
                        {
                            gorevliTanim.GorevliCinsiyet = rdoKadın.Text;
                        }
                    }

                    gorevliTanim.Aktiflik = true;
                    db.tbl_Gorevliler.Add(gorevliTanim);

                    db.SaveChanges();
                    MessageBox.Show("Görevli Başarıyla Kayıt Edildi");
                    listele();
                    temizle();
                }
                
               
                
               
            }
            else
            {
                MessageBox.Show("Kayıt Tekrarı Yapılamaz");
            }*/
           
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (lblGorevliNo.Text !="")
            {
                DialogResult onay;
                onay = MessageBox.Show("Kayıt silme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        int gorevliNo = Convert.ToInt32(lblGorevliNo.Text);
                        var x = db.tbl_Gorevliler.Find(gorevliNo);
                        x.Aktiflik = false;
                        db.SaveChanges();
                        temizle();
                        listele();
                        MessageBox.Show("Kayit Başarıyla Silindi");
                    }
                    catch
                    {

                        MessageBox.Show("Kayıt Silinemedi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek Kayit Seçilmedi");
            }
           
                

        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
             try
           {
               int gorevliNo = Convert.ToInt32(lblGorevliNo.Text);
               var g = db.tbl_Gorevliler.Find(gorevliNo);
               g.GorevliAd = txtGorevliAd.Text;
               g.GorevliSoyAd = txtGorevliSoyAd.Text;
               g.GorevliTel = txtGorevliTel.Text;
              
               
               
               

               if (rdoErkek.Checked == true)
               {
                   g.GorevliCinsiyet = rdoErkek.Text;


               }
               else
               {
                   if (rdoKadın.Checked == true)
                   {
                       g.GorevliCinsiyet = rdoKadın.Text;
                   }
               }
               db.SaveChanges();
               MessageBox.Show("Kayit Başarıyla Güncellendi");
               listele();
               temizle();

           }
           catch 
           {
               MessageBox.Show("Güncellenicek Kayit Seçilmedi");

           }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
            listele();
        }

        private void rdoErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoErkek.Checked==true)
            {
                rdoKadın.Checked = false;
            }
        }

        private void rdoKadın_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKadın.Checked == true)
            {
                rdoErkek.Checked = false;
            }
        }

        private void txtGorevliTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !=' ';
        }
    }
}
