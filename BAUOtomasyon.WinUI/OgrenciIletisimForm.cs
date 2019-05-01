using BAUOtomasyon.BLL.BAUOtomasyonService;
using BAUOtomasyon.Entities.DTO;
using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAUOtomasyon.WinUI
{
    public partial class OgrenciIletisimForm : Form
    {
        OgrenciService _ogrenciService;
        IletisimService _iletisimService;

        Ogrenci _secilenOgrenci;
        public OgrenciIletisimForm()
        {
            InitializeComponent();
            _ogrenciService = new OgrenciService();
            _iletisimService = new IletisimService();
        }

        private void txtOgrenciAdi_TextChanged(object sender, EventArgs e)
        {
            dgrOgrenciListesi.DataSource = null;
            List<Ogrenci> ogrenciListesi = _ogrenciService.ArananOgrenciService(txtOgrenciAdi.Text);
            dgrOgrenciListesi.DataSource = ogrenciListesi;
        }

        public void OgrenciDoldur()
        {
            dgrOgrenciListesi.DataSource = null;
            List<Ogrenci> ogrenciListesi = _ogrenciService.TumOgrencileriGetir();
            dgrOgrenciListesi.DataSource = ogrenciListesi;
        }

        public void OgrenciIletisimDoldur()
        {
            dgvOgrenciIletisim.DataSource = null;
            List<OgrenciIletisimDTO> ogrenciListesi = _ogrenciService.OgrenciIletisimRaporu();
            dgvOgrenciIletisim.DataSource = ogrenciListesi;
        }

        private void btnIletisimKaydet_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Adres = txtAdres.Text;
            iletisim.Telefon = txtTelefon.Text;
            iletisim.EMail = txtEPosta.Text;
            //iletisim.OgrenciID = _secilenOgrenci.ID;
            iletisim.AktifMi = true;
            iletisim.OlusuturulmaTarihi = DateTime.Now;

            int etkilenen = _iletisimService.AddIletisimService(iletisim);
            if (etkilenen > 0)
            {
                MessageBox.Show("İletişim başarıyle eklenmiştir.");
            }
        }

        private void OgrenciIletisimForm_Load(object sender, EventArgs e)
        {
            OgrenciDoldur();
            OgrenciIletisimDoldur();
        }

        private void dgrOgrenciListesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int seciliOgrenciID = Convert.ToInt32(dgrOgrenciListesi.SelectedRows[0].Cells["ID"].Value);

            _secilenOgrenci = _ogrenciService.OgrenciGetirById(seciliOgrenciID);

            txtAd.Text = _secilenOgrenci.Adi;
            txtSoyad.Text = _secilenOgrenci.Soyadi;
        }

        private void btnIletisimKaydet2_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Adres = txtAdres.Text;
            iletisim.Telefon = txtTelefon.Text;
            iletisim.EMail = txtEPosta.Text;
            iletisim.AktifMi = true;
            iletisim.OlusuturulmaTarihi = DateTime.Now;

            Iletisim iletisim2 = new Iletisim();
            iletisim2.Adres = "Maltepe";
            iletisim2.Telefon = "515454";
            iletisim2.EMail = "dasfsdgsd@kf.com";
            iletisim2.AktifMi = true;
            iletisim2.OlusuturulmaTarihi = DateTime.Now;

            _secilenOgrenci.OgrenciIletisimleri.Add(iletisim);
            _secilenOgrenci.OgrenciIletisimleri.Add(iletisim2);

            _ogrenciService.OgrenciUpdate(_secilenOgrenci);
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            int etkilenen = _ogrenciService.OgrenciSil(_secilenOgrenci);
            if (etkilenen > 0)
            {
                MessageBox.Show("Öğrenci silindi");
                OgrenciDoldur();
            }
        }
    }
}
