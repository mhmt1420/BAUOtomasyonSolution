﻿using BAUOtomasyon.DAL.RepositoryConcrete;
using BAUOtomasyon.Entities.DTO;
using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAUOtomasyon.BLL.BAUOtomasyonService
{
    public class OgrenciService
    {
        OgrenciRepository _ogrenciRepository;
        public OgrenciService()
        {
            _ogrenciRepository = new OgrenciRepository();
        }

        public int AddOgrenciService(Ogrenci ogrenci)
        {
            try
            {
                return _ogrenciRepository.AddItem(ogrenci);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : "+e.Message);
                return 0;
            }
        }

        public bool OgrenciLoginKontrolService(string kullaniciAdi, string sifre)
        {
            return _ogrenciRepository.OgrenciLoginKontrol(kullaniciAdi, sifre);
        }

        public List<Ogrenci> ArananOgrenciService(string isim)
        {
            return _ogrenciRepository.ArananOgrenci(isim).ToList();
        }

        public List<Ogrenci> TumOgrencileriGetir()
        {
            return _ogrenciRepository.GetAllById().ToList();
        }

        public Ogrenci OgrenciGetirById(int ID)
        {
            return _ogrenciRepository.GetById(ID);
        }

        public int OgrenciUpdate(Ogrenci ogrenci)
        {
            return _ogrenciRepository.UpdateItem(ogrenci);
        }

        public int OgrenciSil(Ogrenci ogrenci)
        {
            return _ogrenciRepository.DeleteItem(ogrenci);
        }

        public List<OgrenciIletisimDTO> OgrenciIletisimRaporu()
        {
            return _ogrenciRepository.OgrenciIletisim().ToList();
        }
    }
}
