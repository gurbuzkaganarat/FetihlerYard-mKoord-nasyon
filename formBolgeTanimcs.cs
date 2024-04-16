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
    public partial class formBolgeTanimcs : Form
    {
        public formBolgeTanimcs()
        {
            InitializeComponent();
        }

        FetihlerV2Entities1 db = new FetihlerV2Entities1();

        public void listele()
        {
            var query = from d1 in db.tbl_Bolgeler
                       

                        where d1.Aktiflik == true
                        select new
                        {
                            d1.BolgeNo,
                            d1.BolgeAdi,
                            d1.BolgeSorumlusu,
                            d1.BolgeYardımcısı,
                            
                            BölgeDetay =d1.BolgeAciklama,



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
                           AdSoyad = item.GorevliAd + " " + item.GorevliSoyAd,
                       };

           

            cmbSorumlu.DataSource = data.ToList();
            cmbSorumlu.ValueMember = "GorevliNo";
            cmbSorumlu.DisplayMember = "AdSoyad";

            cmbYardimci.DataSource = data.ToList();
            cmbYardimci.ValueMember = "GorevliNo";
            cmbYardimci.DisplayMember = "AdSoyad";
        }
        private void temizle()
        {
            txtBolgeAd.Text = "";
            lblBolgeNo.Text = "";
            rchBolgeDetay.Text = "";
            lblBolgeNo.Text = null;
            txtBolgeAd.Focus();
            cmbSorumlu.SelectedItem = null;
            cmbYardimci.SelectedItem = null;
            cmbSorumlu.SelectedItem = null;
            cmbYardimci.SelectedItem = null;
        }

        private void formBolgeTanimcs_Load(object sender, EventArgs e)
        {
            cmbDataLoad();
            listele();
            temizle();

        }

        public void mükerrer()
        {
            var query = from d1 in db.tbl_Bolgeler
                        where d1.Aktiflik == true
                        where d1.BolgeAdi == txtBolgeAd.Text
                        select new
                        {
                            d1.BolgeAdi
                        };

            var bolgead = (from d1 in query select d1.BolgeAdi).FirstOrDefault();
            var bolgeadi = txtBolgeAd.Text;
            if (bolgead==bolgeadi)
            {
                MessageBox.Show("Aynı Bölge Adına Sahip Kayıt Bulunmaktadır.");

            }
            else
            {
                if (lblBolgeNo.Text == "")
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txtBolgeAd.Text) || cmbSorumlu.SelectedItem == null || cmbYardimci.SelectedItem == null)
                        {
                            MessageBox.Show("Lütfen Eksik Alanları Doldurunuz.");
                        }
                        else
                        {
                            tbl_Bolgeler bolgeTanim = new tbl_Bolgeler();
                            bolgeTanim.BolgeAdi = txtBolgeAd.Text;
                            bolgeTanim.BolgeAciklama = rchBolgeDetay.Text;
                            //var sorumluNo = Convert.ToInt32(cmbSorumlu.SelectedValue);
                            bolgeTanim.BolgeSorumlusu = cmbSorumlu.Text;
                            //var yardimciNo = Convert.ToInt32(cmbYardimci.SelectedValue);
                            bolgeTanim.BolgeYardımcısı = cmbYardimci.Text;

                            bolgeTanim.Aktiflik = true;
                            db.tbl_Bolgeler.Add(bolgeTanim);
                            db.SaveChanges();

                            MessageBox.Show("Bölge Başarıyla Kayıt Edildi.");
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
                    MessageBox.Show("Kayıt Tekrarı Yapamazsınız.");

                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            mükerrer();                                                         

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblBolgeNo.Text != "")
            {
                DialogResult onay;
                onay = MessageBox.Show("Kayıt silme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        int BolgeNo = Convert.ToInt32(lblBolgeNo.Text);
                        var x = db.tbl_Bolgeler.Find(BolgeNo);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Bolgeler bolgeTanim = new tbl_Bolgeler();
                int BolgeNo = Convert.ToInt32(lblBolgeNo.Text);
                var g = db.tbl_Bolgeler.Find(BolgeNo);
                g.BolgeAdi = txtBolgeAd.Text;
                g.BolgeAciklama = rchBolgeDetay.Text;

                g.BolgeSorumlusu = cmbSorumlu.Text;
                
               g.BolgeYardımcısı = cmbYardimci.Text;
                db.SaveChanges();

                MessageBox.Show("Kayıt Basariyla Güncellendi");

            }
            catch
            {
                MessageBox.Show("Güncellenicek Kayıt Seçilmedi");


            }
            temizle();
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                temizle();

                lblBolgeNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtBolgeAd.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                cmbSorumlu.Text= bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                cmbYardimci.Text= bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                rchBolgeDetay.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value?.ToString();

            }

            catch
            {


            }
        }

        private void cmbSorumlu_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {

                cmbSorumlu.SelectedItem = null;
                cmbSorumlu.SelectedItem = null;

            }
        }

        private void cmbYardimci_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {

                cmbYardimci.SelectedItem = null;
                cmbYardimci.SelectedItem = null;

            }
        }
    }
}
