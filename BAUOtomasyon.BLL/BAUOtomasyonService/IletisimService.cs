using BAUOtomasyon.DAL.RepositoryConcrete;
using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAUOtomasyon.BLL.BAUOtomasyonService
{
    public class IletisimService
    {
        IletisimRepository _iletisimRepository;
        public IletisimService()
        {
            _iletisimRepository = new IletisimRepository();
        }
        public int AddIletisimService(Iletisim iletisim)
        {
            try
            {
                return _iletisimRepository.AddItem(iletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
    }
}
