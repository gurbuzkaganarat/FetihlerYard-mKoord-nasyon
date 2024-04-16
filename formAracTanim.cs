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
    public partial class formAracTanim : Form
    {
        FetihlerV2Entities1 db = new FetihlerV2Entities1();
        public formAracTanim()
        {
            InitializeComponent();
        }
        public void listele()
        {
           
            var query = from d1 in db.tbl_Araclar
                        join d2 in db.tbl_Gorevliler
                        on d1.AracSahip equals d2.GorevliNo
                        where d1.Aktiflik == true 
                        select new
                        {
                            d1.AracNo,
                            d1.AracAdi,
                            d1.AracKapasite,
                            Sahibi=d2.GorevliAd+" "+d2.GorevliSoyAd,
                            


                        };
            bunifuCustomDataGrid1.DataSource = query.ToList();
            bunifuCustomDataGrid1.Columns[0].Visible = false;

        }
        public void cmbDataLoad()
        {

            var data = from item in db.tbl_Gorevliler
                        where item.Aktiflik == true
                        orderby item.GorevliAd + " " + item.GorevliSoyAd
                       select new 
                         {
                             item.GorevliNo,
                             AdSoyad=item.GorevliAd + " "+item.GorevliSoyAd,
                         };
            cmbAracSahip.DataSource =data.ToList();            
            cmbAracSahip.ValueMember = "GorevliNo";
            cmbAracSahip.DisplayMember = "AdSoyad";
            
           
        }

        public void temizle()
        {
            lblAracNo.Text = "";
            txtAracAdi.Text = "";
            txtAracKapasite.Text = "";
            cmbAracSahip.SelectedItem = null;
            cmbAracSahip.SelectedItem = null;


        }


        private void formAracTanim_Load(object sender, EventArgs e)
        {
            cmbDataLoad();
            temizle();
            listele();
            

        }

    
        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblAracNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtAracAdi.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtAracKapasite.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                cmbAracSahip.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value?.ToString();
            }
            catch
            {

                
            }
           
            
        }

        
        void mükerrer ()
        {
            var query = from d1 in db.tbl_Araclar
                        where d1.Aktiflik == true
                        where d1.AracAdi == txtAracAdi.Text
                        select new
                        {
                            d1.AracAdi
                        };
            var aracAdi = (from d1 in query select d1.AracAdi).FirstOrDefault();
            var aracAdi2 = txtAracAdi.Text;
            if (aracAdi==aracAdi2)
            {
                MessageBox.Show("Aynı Araç Adına Sahip Kayıt Bulunmaktadır");
            }
            else
            {
                if (lblAracNo.Text == "")
                {
                    try
                    {
                        tbl_Gorevliler gorevliTanim = new tbl_Gorevliler();

                        if (string.IsNullOrEmpty(txtAracAdi.Text) || string.IsNullOrEmpty(txtAracKapasite.Text))
                        {
                            MessageBox.Show("Lütfen Eksik Alanları Doldurunuz");
                        }
                        else
                        {
                            tbl_Araclar aracTanim = new tbl_Araclar();
                            aracTanim.AracAdi = txtAracAdi.Text;
                            aracTanim.AracKapasite = Convert.ToInt32(txtAracKapasite.Text);
                            var sahipNo = Convert.ToInt32(cmbAracSahip.SelectedValue);
                            var g = db.tbl_Gorevliler.Find(sahipNo);
                            aracTanim.AracSahip = sahipNo;
                            aracTanim.Aktiflik = true;
                            aracTanim.Seç = false;


                            db.tbl_Araclar.Add(aracTanim);

                            db.SaveChanges();
                            MessageBox.Show("Araç Başarıyla Kayıt Edildi");
                            listele();
                            temizle();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Eksik  Bilgileri Doldurunuz.");

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
            if (lblAracNo.Text !="")
            {
                DialogResult onay;
                onay = MessageBox.Show("Kayıt silme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        var sahipNo = Convert.ToInt32(cmbAracSahip.SelectedValue);
                        var g = db.tbl_Gorevliler.Find(sahipNo);
                        
                        int aracNo = Convert.ToInt32(lblAracNo.Text);
                        var x = db.tbl_Araclar.Find(aracNo);
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
                int aracNo = Convert.ToInt32(lblAracNo.Text);
                var g = db.tbl_Araclar.Find(aracNo);
                g.AracAdi = txtAracAdi.Text;
                g.AracKapasite = Convert.ToInt32(txtAracKapasite.Text);
                int sahipNo = Convert.ToInt32(cmbAracSahip.SelectedValue);
                g.AracSahip = sahipNo;
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

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
            listele();
        }

        private void txtAracKapasite_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbAracSahip_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {

                cmbAracSahip.SelectedItem = null;
                cmbAracSahip.SelectedItem = null;

            }
        }
    }
}
