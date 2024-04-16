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
    public partial class formGorevliSec : Form
    {
        public formGorevliSec()
        {
            InitializeComponent();
        }

        FetihlerV2Entities1 db = new FetihlerV2Entities1();


        public void ara1 (DataGridView data3)
        {

            string gorevliAra = txtGorevliAd.Text;

            if (!String.IsNullOrEmpty(gorevliAra))
            {
                var query = from d1 in db.tbl_Gorevliler
                            where d1.Aktiflik == true
                            where d1.Seç == false
                            where (d1.GorevliAd + " " + d1.GorevliSoyAd).Contains(gorevliAra)
                            select new
                            {
                                No = d1.GorevliNo,
                                AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                                Cinsiyet = d1.GorevliCinsiyet,
                            };
                data3.DataSource = query.ToList();
                data3.Columns[1].Visible = false;
            }
            else
            {
                List1(bunifuCustomDataGrid1);
                List2(bunifuCustomDataGrid2);

            }                       

        }

        public void ara2(DataGridView data4)
        {
            string gorevliAra = txtGorevliAd.Text;

            if (!String.IsNullOrEmpty(gorevliAra))
            {
                var query = from d1 in db.tbl_Gorevliler
                            where d1.Aktiflik == true
                            where d1.Seç == true
                            where (d1.GorevliAd + " " + d1.GorevliSoyAd).Contains(gorevliAra)
                            select new
                            {
                                No = d1.GorevliNo,
                                AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                                Cinsiyet = d1.GorevliCinsiyet,
                            };
                data4.DataSource = query.ToList();
                data4.Columns[1].Visible = false;
            }
            else
            {
                List1(bunifuCustomDataGrid1);
                List2(bunifuCustomDataGrid2);

            }

        }
        public void List1(DataGridView data)
        {
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        where d1.Seç == false
                        
                        select new
                        {
                            No = d1.GorevliNo,
                            AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                            Cinsiyet = d1.GorevliCinsiyet,
                        };
            data.DataSource = query.OrderBy(x => x.AdSoyad).ToList();
            data.Columns[1].Visible = false;

        }

        public void List2(DataGridView data2)
        {
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        where d1.Seç == true
                        select new
                        {
                            No = d1.GorevliNo,
                            AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                            Cinsiyet = d1.GorevliCinsiyet,
                        };
            data2.DataSource = query.OrderBy(x => x.AdSoyad).ToList();
            data2.Columns[1].Visible = false;

        }


        public void toplamGorevli()
        {
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        
                        select new
                        {
                            No = d1.GorevliNo,
                            AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                            Cinsiyet = d1.GorevliCinsiyet,
                            toplam=db.tbl_Gorevliler.Count(x=> x.Aktiflik ==true)
                        };

            var toplam = (from d1 in query select (int?) d1.toplam).Count();
            lblToplamGorevli.Text = toplam.ToString();
            
        }

        public void secilenGorevli()
        {
            var query = from d1 in db.tbl_Gorevliler
                        where d1.Aktiflik == true
                        where d1.Seç==true

                        select new
                        {
                            No = d1.GorevliNo,
                            AdSoyad = d1.GorevliAd + " " + d1.GorevliSoyAd,
                            Cinsiyet = d1.GorevliCinsiyet,
                            toplam = db.tbl_Gorevliler.Count(x => x.Aktiflik == true && x.Seç==true)
                        };

            var toplam = (from d1 in query select (int?)d1.toplam).Count();
            lblSecilenGörevli.Text = toplam.ToString();
        }


        private void formGorevliSec_Load(object sender, EventArgs e)
        {
            toplamGorevli();
            secilenGorevli();
            ara1(bunifuCustomDataGrid1);
            ara2(bunifuCustomDataGrid2);

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblGorevliNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                int gorevliNo = Convert.ToInt32(lblGorevliNo.Text);
                var g = db.tbl_Gorevliler.Find(gorevliNo);
                g.Seç = true;
                db.SaveChanges();

                ara1(bunifuCustomDataGrid1);
                ara2(bunifuCustomDataGrid2);
                toplamGorevli();
                secilenGorevli();
            }
            catch
            {


            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblGorevliNo.Text = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value?.ToString();
                int gorevliNo = Convert.ToInt32(lblGorevliNo.Text);
                var g = db.tbl_Gorevliler.Find(gorevliNo);
                g.Seç = false;

                db.SaveChanges();
                ara1(bunifuCustomDataGrid1);
                ara2(bunifuCustomDataGrid2);

                toplamGorevli();
                secilenGorevli();
            }
            catch
            {


            }
        }

        private void txtGorevliAd_TextChanged(object sender, EventArgs e)
        {
            ara1(bunifuCustomDataGrid1);
            ara2(bunifuCustomDataGrid2);
        }
    }
}
