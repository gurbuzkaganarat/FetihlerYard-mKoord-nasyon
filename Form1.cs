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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            IsMdiContainer = true;
            customizeDesing();

            
        }
        private void customizeDesing()
        {
            panelTanımlarSubMenu.Visible = false;
            panelListelerSubMenu.Visible = false;
            panelRaporlarSubMenu.Visible = false;


        }
        private void hideSubMenu()
        {
            if (panelTanımlarSubMenu.Visible == true)
                panelTanımlarSubMenu.Visible = false;
            if (panelListelerSubMenu.Visible == true)
                panelListelerSubMenu.Visible = false;
            if (panelRaporlarSubMenu.Visible ==true)
                panelRaporlarSubMenu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
            
        }

        


        private void openForm ( Form openForm)
        {
            centerPanel.Controls.Clear();
            openForm.MdiParent = this;
            openForm.Dock= DockStyle.Fill;
            centerPanel.Controls.Add(openForm);
            openForm.Show();

        }

        

        private void Tanımlar_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(label4);
            centerPanel.Controls.Add(label2);
            centerPanel.Controls.Add(label3);
            centerPanel.Controls.Add(pictureBox2);
            showSubMenu(panelTanımlarSubMenu);
            lblformAdi.Text = "";

                       
        }

    

        private void btnGorevliTanim_Click(object sender, EventArgs e)
        {
            formGorevliTanim formGorevliTanim = new formGorevliTanim();
            openForm(formGorevliTanim);
            lblformAdi.Text = "Görevli Tanım Formu";
        }
               

      

       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKoyListesi_Click(object sender, EventArgs e)
        {
            formKoySec formKoySec = new formKoySec();
            openForm(formKoySec);
            lblformAdi.Text = "Köy Listesi Formu";
        }

        private void btnAracListesi_Click(object sender, EventArgs e)
        {
            formAracSec formAracSec = new formAracSec();
            openForm(formAracSec);
            lblformAdi.Text = "Arac Listesi Formu";
        }

        private void btnGorevliListesi_Click(object sender, EventArgs e)
        {
            formGorevliSec formGorevliSec = new formGorevliSec();
            openForm(formGorevliSec);
            lblformAdi.Text = "Görevli Listesi Formu";
        }

        private void btnParaTutanak_Click(object sender, EventArgs e)
        {
            formparaTutanak formparaTutanak = new formparaTutanak();
            openForm(formparaTutanak);
            lblformAdi.Text = "Para Tutanağı Raporu";
        }

        private void btnDagitimListesi_Click(object sender, EventArgs e)
        {
            formDagitimListesi formDagitimListesi = new formDagitimListesi();
            openForm(formDagitimListesi);
            lblformAdi.Text = "Dağıtım Listesi Raporu";
        }

        private void btnKisiListesi_Click(object sender, EventArgs e)
        {
            formKisiListesi formKisiListesi = new formKisiListesi();
            openForm(formKisiListesi);
            lblformAdi.Text = "Kisi Listesi Raporu";
        }

        private void btnRaporlar_Click_1(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(label4);
            centerPanel.Controls.Add(label2);
            centerPanel.Controls.Add(label3);
            centerPanel.Controls.Add(pictureBox2);
            showSubMenu(panelListelerSubMenu);
            lblformAdi.Text = "";
        }

        private void btnListeler_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(label4);
            centerPanel.Controls.Add(label2);
            centerPanel.Controls.Add(label3);
            centerPanel.Controls.Add(pictureBox2);
            showSubMenu(panelRaporlarSubMenu);
            lblformAdi.Text = "";
        }

        private void btnBolgeTanim_Click(object sender, EventArgs e)
        {
            formBolgeTanimcs formBolgeTanimcs = new formBolgeTanimcs();
            openForm(formBolgeTanimcs);
            lblformAdi.Text = "Bölge Tanım Formu";
        }

        private void btnKoyTanim_Click(object sender, EventArgs e)
        {
            formKoyTanim formKoyTanim = new formKoyTanim();
            openForm(formKoyTanim);
            lblformAdi.Text = "Köy Tanım Formu";
        }

        private void btnHastalik_Click(object sender, EventArgs e)
        {
            formHastalikTanim formHastalikTanim = new formHastalikTanim();
            openForm(formHastalikTanim);
            lblformAdi.Text = "Hastalik Tanım Formu";
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            formKategoriTanim2 formKategoriTanim2 = new formKategoriTanim2();
            openForm(formKategoriTanim2);
            lblformAdi.Text = "Kategori Tanım Formu";
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            formMaasTanim formMaasTanim = new formMaasTanim();
            openForm(formMaasTanim);
            lblformAdi.Text = "Maaş Tanım Formu";
        }

        private void btnAracTanim_Click(object sender, EventArgs e)
        {
            formAracTanim formAracTanim = new formAracTanim();
            openForm(formAracTanim);
            lblformAdi.Text = "Araç Tanım Formu";
        }

        private void btnDonemTanim_Click(object sender, EventArgs e)
        {
            donemTanim formDonemTanım = new donemTanim();
            openForm(formDonemTanım);
            lblformAdi.Text = "Dönem Tanım Formu";
        }

        private void btnKisiTanim_Click(object sender, EventArgs e)
        {
            formKisiTanim formKisiTanim = new formKisiTanim();
            openForm(formKisiTanim);
            lblformAdi.Text = "Kisi Tanım Formu";
        }

        private void btnSeferListesi_Click(object sender, EventArgs e)
        {
            formKoyGorevlileri formKoyGorevlileri = new formKoyGorevlileri();
            openForm(formKoyGorevlileri);
            lblformAdi.Text = "Sefer Listesi Formu";
        }
    }
}
