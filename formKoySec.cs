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
    public partial class formKoySec : Form
    {
        public formKoySec()
        {
            InitializeComponent();
        }
        FetihlerV2Entities1 db = new FetihlerV2Entities1();

        private void cmbDataLoad()
        {
            cmbBolgeAd.DataSource = db.tbl_Bolgeler.Where(x => x.Aktiflik == true).ToList();
            cmbBolgeAd.ValueMember = "BolgeNo";
            cmbBolgeAd.DisplayMember = "BolgeAdi";

        }

        public void List1 (DataGridView data)
        {
            string koyAra = txtKoyAra.Text;

            var query = from d1 in db.tbl_Koyler
                        join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                        from d2 in d2list.DefaultIfEmpty()  
                        join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list
                       
                        where d1.Aktiflik == true  
                        where d1.Sec==true
                        where d1.KoyAdi.Contains(koyAra)


                        select new
                        {
                            KöyNo = d1.KoyNo,
                            Bolge = d2.BolgeAdi,
                            KöyAdi = d1.KoyAdi,
                            KisiSayisi= d3list.Count(x=>x.Aktiflik==true)
                           

                        };
            data.DataSource = query.OrderBy(x => x.KöyAdi).ToList();
            data.Columns[1].Visible = false;
        }

        public void List2 (DataGridView data2)
        {
            string koyAra = txtKoyAra.Text;
            var query = from d1 in db.tbl_Koyler
                        join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                        from d2 in d2list.DefaultIfEmpty()
                        join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list
                        
                        where d1.Aktiflik == true
                        where d1.Sec == false
                        where d1.KoyAdi.Contains(koyAra)


                        select new
                        {
                            KöyNo = d1.KoyNo,
                            Bolge = d2.BolgeAdi,
                            KöyAdi = d1.KoyAdi,
                            KisiSayisi = d3list.Count(x => x.Aktiflik == true)


                        };
            data2.DataSource = query.OrderBy(x => x.KöyAdi).ToList();
            data2.Columns[1].Visible = false;
        }

        public void toplamKisi()
        {
            var query = from d1 in db.tbl_Koyler
                        join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                        from d2 in d2list.DefaultIfEmpty()
                        join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list
                        
                        where d1.Aktiflik == true
                        
                        

                        select new
                        {
                            KöyNo = d1.KoyNo,
                            Bolge = d2.BolgeAdi,
                            KöyAdi = d1.KoyAdi,
                            KisiSayisi = d3list.Count(x => x.Aktiflik == true)


                        };
            var toplam = (from x in query select (int?)x.KisiSayisi).Sum();
            lblToplamFakir.Text = toplam.ToString();
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
            lblDagitimFakir.Text = toplam.ToString();

        }

        public void bolgeSec1(DataGridView data)
        {

            if (cmbBolgeAd.SelectedItem != null)
            {
                var bolgeNo = Convert.ToInt32(cmbBolgeAd.SelectedValue);
                string koyAra = txtKoyAra.Text;
                var query = 
                             from d1 in db.tbl_Koyler
                             join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                             from d2 in d2list.DefaultIfEmpty()
                             join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list
                             where d1.Bolge == bolgeNo
                             where d1.Aktiflik == true
                             where d1.Sec == true
                             where d1.KoyAdi.Contains(koyAra)


                select new
                {
                    KöyNo = d1.KoyNo,
                    Bolge = d2.BolgeAdi,
                    KöyAdi = d1.KoyAdi,
                    KisiSayisi = d3list.Count(x => x.Aktiflik == true)


                };
                data.DataSource = query.ToList();
                data.Columns[1].Visible = false;

            }
            else
            {
                List1(bunifuCustomDataGrid1);
                List2(bunifuCustomDataGrid2);

            }
        }

        public void bolgeSec2(DataGridView data2)
        {
            if (cmbBolgeAd.SelectedItem != null)
            {
                var bolgeNo = Convert.ToInt32(cmbBolgeAd.SelectedValue);
                string koyAra = txtKoyAra.Text;

                var query =
                             from d1 in db.tbl_Koyler
                             join d2 in db.tbl_Bolgeler on d1.Bolge equals d2.BolgeNo into d2list
                             from d2 in d2list.DefaultIfEmpty()
                             join d3 in db.tbl_Kisiler on d1.KoyNo equals d3.Koy into d3list
                             where d1.Bolge == bolgeNo
                             where d1.Aktiflik == true
                             where d1.Sec == false
                             where d1.KoyAdi.Contains(koyAra)


                             select new
                             {
                                 KöyNo = d1.KoyNo,
                                 Bolge = d2.BolgeAdi,
                                 KöyAdi = d1.KoyAdi,
                                 KisiSayisi = d3list.Count(x => x.Aktiflik == true)


                             };
                data2.DataSource = query.ToList();
                data2.Columns[1].Visible = false;

            }
            else
            {
                List1(bunifuCustomDataGrid1);
                List2(bunifuCustomDataGrid2);

            }

        }


        public void toplamKoy()
        {

            var query = from d1 in db.tbl_Koyler
                        where d1.Aktiflik == true
                        select new
                        {
                            toplamKoySayisi = db.tbl_Koyler.Count(x=> x.Aktiflik == true)
                        };

            var toplamKoy = (from d1 in query select (int?)d1.toplamKoySayisi).Count();

            lblToplamKoy.Text = toplamKoy.ToString();                             

        }

        public void secilenKoy()
        {
            var query = from d1 in db.tbl_Koyler
                        where d1.Aktiflik == true
                        where d1.Sec==true

                        select new
                        {
                            secilenKoySayisi = db.tbl_Koyler.Count(x => x.Aktiflik == true && x.Sec == true)
                        };

            var secilenKoy = (from d1 in query select (int?)d1.secilenKoySayisi).Count();

            lblSecilenKoy.Text = secilenKoy.ToString();
        }
       

        private void deneme_Load(object sender, EventArgs e)
        {
            List1(bunifuCustomDataGrid1);
            List2(bunifuCustomDataGrid2);
            toplamKisi();
            secilenKisi();
            cmbDataLoad();
            cmbBolgeAd.SelectedItem = null;
            toplamKoy();
            secilenKoy();


        }

        private void cmbBolgeAd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bolgeSec1(bunifuCustomDataGrid1);
            bolgeSec2(bunifuCustomDataGrid2);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblKoyNo.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                int koyNo = Convert.ToInt32(lblKoyNo.Text);
                var g = db.tbl_Koyler.Find(koyNo);
                g.Sec = false;
                db.SaveChanges();
                bolgeSec1(bunifuCustomDataGrid1);
                bolgeSec2(bunifuCustomDataGrid2);
                toplamKisi();
                secilenKisi();
                toplamKoy();
                secilenKoy();
            }
            catch 
            {

                
            }
            
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblKoyNo.Text = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value?.ToString();
                int koyNo = Convert.ToInt32(lblKoyNo.Text);
                var g = db.tbl_Koyler.Find(koyNo);
                g.Sec = true;
                db.SaveChanges();
                bolgeSec1(bunifuCustomDataGrid1);
                bolgeSec2(bunifuCustomDataGrid2);
                toplamKisi();
                secilenKisi();
                toplamKoy();
                secilenKoy();
            }
            catch 
            {

                
            }
            
        }

        private void cmbBolgeAd_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                cmbBolgeAd.SelectedItem = null;
                bolgeSec1(bunifuCustomDataGrid1);
                bolgeSec2(bunifuCustomDataGrid2);
                
                toplamKisi();
                secilenKisi();
                toplamKoy();
                secilenKoy();                                                                                                                                          

            }
        }

        private void txtKoyAra_TextChanged(object sender, EventArgs e)
        {
           
            
                bolgeSec1(bunifuCustomDataGrid1);
                bolgeSec2(bunifuCustomDataGrid2);
            
           
            
        }
    }

}


