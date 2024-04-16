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
    public partial class formKoyGorevlileri : Form
    {
        public formKoyGorevlileri()
        {
            InitializeComponent();
        }

        FetihlerV2Entities1 db = new FetihlerV2Entities1();

        private void cmbDataLoad()
        {
            cmbBolgeAd.DataSource = db.tbl_Bolgeler.Where(x => x.Aktiflik == true).OrderBy(x => x.BolgeAdi).ToList();
            cmbBolgeAd.ValueMember = "BolgeNo";
            cmbBolgeAd.DisplayMember = "BolgeAdi";

            cmbDagitimDonemi.DataSource = db.tbl_Donemler.Where(x => x.Aktiflik == true).OrderBy(x => x.DonemAdi).ToList();
            cmbDagitimDonemi.ValueMember = "DonemNo";
            cmbDagitimDonemi.DisplayMember = "DonemAdi";

        }

        public void gorevliListesi(DataGridView data3)
        {

            string gorevliAd = txtGorevliAd.Text;
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        where (d1.GorevliAd + " " + d1.GorevliSoyAd).Contains(gorevliAd)
                        orderby d1.GorevliAd + " " + d1.GorevliSoyAd

                        select new
                        {
                            Gorevli = d1.GorevliAd + " " + d1.GorevliSoyAd,
                        };
            data3.DataSource = query.ToList();

        }

        public void aracListesi(DataGridView data2)
        {
            var donemNo = Convert.ToInt32(cmbDagitimDonemi.SelectedValue);


            var query = from d1 in db.tbl_Araclar
                        from d2 in db.tbl_Donemler
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        where d2.DonemNo == donemNo
                       // orderby d1.AracAdi
                        select new
                        {

                            Araç = d1.AracAdi,
                            Kapasite = d1.AracKapasite / d2.PaketAgirligi


                        };
            data2.DataSource = query.OrderBy(x => x.Kapasite).ToList();



      



        }

        public void koyListesi(DataGridView data)
        {
            var bolgeNo = Convert.ToInt32(cmbBolgeAd.SelectedValue);
            
            var query =
                         from d1 in db.tbl_Koyler
                         join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                         from d2 in d2list.DefaultIfEmpty()
                         join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list
                         where d1.Bolge == bolgeNo
                         where d1.Aktiflik == true
                         where d1.Sec == true   
                         orderby d1.KoyAdi
                         select new
                         {
                                                       
                             KöyAdi = d1.KoyAdi,
                             KisiSayisi = d3list.Count(x => x.Aktiflik == true)


                         };
            data.DataSource = query.ToList();
        }
        public void secilenKoy()
        {
            var query = from d1 in db.tbl_Koyler
                        where d1.Aktiflik == true
                        where d1.Sec == true

                        select new
                        {
                            secilenKoySayisi = db.tbl_Koyler.Count(x => x.Aktiflik == true && x.Sec == true)
                        };

            var secilenKoy = (from d1 in query select (int?)d1.secilenKoySayisi).Count();

            lblKoySayisi.Text = secilenKoy.ToString();
        }

        public void secilenKisi()
        {
            var query = from d1 in db.tbl_Koyler
                        join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                        from d2 in d2list.DefaultIfEmpty()
                        join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list

                        where d1.Aktiflik == true
                        where d1.Sec == true


                        select new
                        {
                            KöyNo = d1.KoyNo,
                            Bolge = d2.BolgeAdi,
                            KöyAdi = d1.KoyAdi,
                            KisiSayisi = d3list.Count(x => x.Aktiflik == true)


                        };
            var toplam = (from x in query select (int?)x.KisiSayisi).Sum() ?? 0;
            // (int?) null yapılabilen deger  ?? 0 ise baslangıctada null deger dondurebilir
            lblFakirSayisi.Text = toplam.ToString();

        }

        public void secilenArac()
        {
            var query = from d1 in db.tbl_Araclar
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        select new
                        {
                            ToplamArac = db.tbl_Araclar.Count(x => x.Aktiflik == true && x.Seç == true)
                        };
            var toplam = (from d1 in query select (int?)d1.ToplamArac).Count();
            lblAracSayisi.Text = toplam.ToString();

        }

        public void aracKapasite()
        {
            var donemNo = Convert.ToInt32(cmbDagitimDonemi.SelectedValue);
            var query = from d1 in db.tbl_Araclar
                        from d2 in db.tbl_Donemler
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        where d2.DonemNo == donemNo
                        select new
                        {
                            Kapasite = d1.AracKapasite / d2.PaketAgirligi
                        };
            var toplam = (from d1 in query select (int?)d1.Kapasite).Sum();
            lblKapasite.Text = toplam.ToString();

        }
        public void secilenGorevli()
        {
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        where d1.Seç == true

                        select new
                        {
                            No = d1.GorevliNo,
                            AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                            Cinsiyet = d1.GorevliCinsiyet,
                            toplam = db.tbl_Gorevliler.Count(x => x.Aktiflik == true && x.Seç == true)
                        };

            var toplam = (from d1 in query select (int?)d1.toplam).Count();
            lblGorevliSayisi.Text = toplam.ToString();
        }

        private void formKoyGorevlileri_Load(object sender, EventArgs e)
        {
            cmbDataLoad();
            gorevliListesi(bunifuCustomDataGrid3);
            secilenKoy();
            secilenKisi();
            secilenArac();
            
            secilenGorevli();
            cmbDagitimDonemi.SelectedItem = null;
            cmbBolgeAd.SelectedItem = null;

        }

        private void cmbBolgeAd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            koyListesi(bunifuCustomDataGrid1);
        }

        private void cmbDagitimDonemi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            aracListesi(bunifuCustomDataGrid2);
            aracKapasite();
        }

        private void txtGorevliAd_TextChanged(object sender, EventArgs e)
        {
            gorevliListesi(bunifuCustomDataGrid3);
        }

        private void cmbDagitimDonemi_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {


               cmbDagitimDonemi.SelectedItem = null;
               cmbDagitimDonemi.SelectedItem = null;
                
            }
        }

        private void cmbBolgeAd_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {


                cmbBolgeAd.SelectedItem = null;
                cmbBolgeAd.SelectedItem = null;


            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < bunifuCustomDataGrid1.Columns.Count + 1; i++)
                    {
                        xcelApp.Cells[1, i] = bunifuCustomDataGrid1.Columns[i - 1].HeaderText;

                    }
                    for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
                    {
                        for (int j = 0; j < bunifuCustomDataGrid1.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j + 1] = bunifuCustomDataGrid1.Rows[i].Cells[j].Value?.ToString();
                        }

                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;

                }
            }
            catch 
            {

                
            }
           





        }
    }
}
