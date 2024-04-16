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
    public partial class formAracSec : Form
    {
        public formAracSec()
        {
            InitializeComponent();
        }
        FetihlerV2Entities1 db = new FetihlerV2Entities1();

        public void gorevliAra1(DataGridView data3)
        {

            string aracAd = txtAracAd.Text;
            string aracSahibi = txtAracSahip.Text;
            if (String.IsNullOrEmpty(aracAd))
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == false
                            where (d2.GorevliAd + " " + d2.GorevliSoyAd).Contains(aracSahibi)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data3.DataSource = query.ToList();
                data3.Columns[1].Visible = false;
            }
            else
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == false
                            where (d2.GorevliAd + " " + d2.GorevliSoyAd).Contains(aracSahibi) && d1.AracAdi.Contains(aracAd)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data3.DataSource = query.ToList();
                data3.Columns[1].Visible = false;
            }
        }

        public void aracAra1(DataGridView data4)
        {
            string aracAd = txtAracAd.Text;
            string aracSahibi = txtAracSahip.Text;

            if (String.IsNullOrEmpty(aracSahibi))
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == false
                            where d1.AracAdi.Contains(aracAd)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data4.DataSource = query.ToList();
                data4.Columns[1].Visible = false;
            }
            else
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == false
                            where d1.AracAdi.Contains(aracAd) && (d2.GorevliAd + " " + d2.GorevliSoyAd).Contains(aracSahibi) 
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data4.DataSource = query.ToList();
                data4.Columns[1].Visible = false;
            }

        }

        public void gorevliAra2(DataGridView data3)
        {

            string aracAd = txtAracAd.Text;
            string aracSahibi = txtAracSahip.Text;
            if (String.IsNullOrEmpty(aracAd))
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == true
                            where (d2.GorevliAd + " " + d2.GorevliSoyAd).Contains(aracSahibi)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data3.DataSource = query.ToList();
                data3.Columns[1].Visible = false;
            }
            else
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == true
                            where (d2.GorevliAd + " " + d2.GorevliSoyAd).Contains(aracSahibi) && d1.AracAdi.Contains(aracAd)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data3.DataSource = query.ToList();
                data3.Columns[1].Visible = false;
            }
        }

        public void aracAra2(DataGridView data4)
        {
            string aracAd = txtAracAd.Text;
            string aracSahibi = txtAracSahip.Text;

            if (String.IsNullOrEmpty(aracSahibi))
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == true
                            where d1.AracAdi.Contains(aracAd)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data4.DataSource = query.ToList();
                data4.Columns[1].Visible = false;
            }
            else
            {
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == true
                            where d1.AracAdi.Contains(aracAd) && (d2.GorevliAd + " " + d2.GorevliSoyAd).Contains(aracSahibi)
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
                data4.DataSource = query.ToList();
                data4.Columns[1].Visible = false;
            }

        }
        public void List1(DataGridView data)
        {
            
            
                var query = from d1 in db.tbl_Araclar
                            join d2 in db.tbl_Gorevliler
                            on d1.AracSahip equals d2.GorevliNo
                            where d1.Aktiflik == true
                            where d1.Seç == false                           
                            select new
                            {
                                d1.AracNo,
                                d1.AracAdi,
                                Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                            };
            data.DataSource = query.OrderBy(x => x.AracAdi).ToList();
            data.Columns[1].Visible = false;




        }
        public void List2(DataGridView data2)
        {
            var query = from d1 in db.tbl_Araclar
                        join d2 in db.tbl_Gorevliler
                        on d1.AracSahip equals d2.GorevliNo
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        select new
                        {
                            d1.AracNo,
                            d1.AracAdi,
                            Sahibi = d2.GorevliAd + " " + d2.GorevliSoyAd,



                        };
            data2.DataSource = query.OrderBy(x => x.AracAdi).ToList();
            data2.Columns[1].Visible = false;
        }

        public void toplamArac()
        {
            //var query = db.tbl_Araclar.Select(x=> x.Aktiflik == true && x.Seç == true).Count();

            var query = from d1 in db.tbl_Araclar
                        where d1.Aktiflik == true
                        
                        select new
                        {
                            ToplamArac =db.tbl_Araclar.Count(x=> x.Aktiflik == true )
                        };
            var toplam = (from d1 in query select (int?)d1.ToplamArac).Count();
            lblToplamArac.Text = toplam.ToString();

                                                    

        }

        public void secilenArac()
        {
            var query = from d1 in db.tbl_Araclar
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        select new
                        {
                            ToplamArac = db.tbl_Araclar.Count(x => x.Aktiflik == true && x.Seç ==true)
                        };
            var toplam = (from d1 in query select (int?)d1.ToplamArac).Count();
            lblSecilenArac.Text = toplam.ToString();

        }

        private void formAracSec_Load(object sender, EventArgs e)
        {
            toplamArac();
            secilenArac();
            List1(bunifuCustomDataGrid1);
            List2(bunifuCustomDataGrid2);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblAracNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                int aracNo = Convert.ToInt32(lblAracNo.Text);
                var g = db.tbl_Araclar.Find(aracNo);
                g.Seç = true;
                db.SaveChanges();
                
                List1(bunifuCustomDataGrid1);
                List2(bunifuCustomDataGrid2);
                toplamArac();
                secilenArac();
            }
            catch 
            {

                
            }
          



        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                lblAracNo.Text = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value?.ToString();
                int aracNo = Convert.ToInt32(lblAracNo.Text);
                var g = db.tbl_Araclar.Find(aracNo);
                g.Seç = false;
                db.SaveChanges();
                
                List1(bunifuCustomDataGrid1);
                List2(bunifuCustomDataGrid2);
                toplamArac();
                secilenArac();
            }
            catch
            {


            }
        }

        private void txtAracAd_TextChanged(object sender, EventArgs e)
        {
                                                 
            
                aracAra1(bunifuCustomDataGrid1);
                aracAra2(bunifuCustomDataGrid2);
                       
            
        }

        private void txtAracSahip_TextChanged(object sender, EventArgs e)
        {
                     
                gorevliAra1(bunifuCustomDataGrid1);
                gorevliAra2(bunifuCustomDataGrid2);
                       

        }
    }
}
