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
    public partial class formDagitimListesi : Form
    {
        public formDagitimListesi()
        {
            InitializeComponent();
        }

        FetihlerV2Entities1 db = new FetihlerV2Entities1();
        public void cmbDataLoad()
        {
            cmbKategori.DataSource = db.tbl_Kategoriler.Where(x => x.Aktiflik == true).ToList();
            cmbKategori.ValueMember = "KategoriNo";
            cmbKategori.DisplayMember = "KategoriAdi";




            cmbBolge.DataSource = db.tbl_Bolgeler.Where(x => x.Aktiflik == true).ToList();
            cmbBolge.ValueMember = "BolgeNo";
            cmbBolge.DisplayMember = "BolgeAdi";


        }
        public void temizle()
        {
            cmbBolge.SelectedItem = null;
            cmbKategori.SelectedItem = null;
            cmbKoy.SelectedItem = null;
        }

        private void formDagitimListesi_Load(object sender, EventArgs e)
        {
            cmbDataLoad();
            temizle();
            /*// TODO: This line of code loads data into the 'dataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataSet1.EnforceConstraints = false;
            this.dataTable2TableAdapter.fillDagitimListesi(this.dataSet1.DataTable2);

            this.reportViewer1.RefreshReport();*/
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbKoy.SelectedItem != null)
            {
                this.dataSet1.EnforceConstraints = false;
                this.dataTable2TableAdapter.fillDagitimListesi(this.dataSet1.DataTable2, Convert.ToInt32(cmbBolge.SelectedValue), Convert.ToInt32(cmbKategori.SelectedValue), Convert.ToInt32(cmbKoy.SelectedValue));
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.dataSet1.EnforceConstraints = false;
                this.dataTable2TableAdapter.FillBy(this.dataSet1.DataTable2, Convert.ToInt32(cmbBolge.SelectedValue), Convert.ToInt32(cmbKategori.SelectedValue));
                this.reportViewer1.RefreshReport();
            }
        }

        private void cmbBolge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBolge.SelectedItem != null)
            {
                var bolgeNo = Convert.ToInt32(cmbBolge.SelectedValue);

                var query = (from item in db.tbl_Koyler
                             where item.Bolge == bolgeNo
                             where item.Aktiflik == true
                             where item.Sec == true
                             orderby item.KoyAdi
                             select new
                             {
                                 item.KoyNo,
                                 item.KoyAdi,
                             }).ToList();
                cmbKoy.DataSource = query;
                cmbKoy.ValueMember = "KoyNo";
                cmbKoy.DisplayMember = "KoyAdi";

            }
            else
            {


            }
            cmbKoy.SelectedItem = null;
        }

        private void cmbBolge_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                cmbBolge.SelectedItem = null;

                cmbKoy.SelectedItem = null;
                cmbBolge.SelectedItem = null;

                cmbKoy.SelectedItem = null;

            }
        }

        private void cmbKoy_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {


                cmbKoy.SelectedItem = null;


                cmbKoy.SelectedItem = null;

            }
        }

        private void cmbKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {


                cmbKategori.SelectedItem = null;
                cmbKategori.SelectedItem = null;
            }
        }
    }
}
