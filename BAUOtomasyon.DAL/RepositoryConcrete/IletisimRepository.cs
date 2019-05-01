using BAUOtomasyon.DAL.RepositoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAUOtomasyon.Entities.Models;
using BAUOtomasyon.DAL.BAUContext;

namespace BAUOtomasyon.DAL.RepositoryConcrete
{
    public class IletisimRepository : IIletisimRepository
    {
        BAUDbContext _db;
        public IletisimRepository()
        {
            _db = new BAUDbContext();
        }
        int _etkilenenSatir;
        public int AddItem(Iletisim item)
        {
            _db.Iletisim.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(Iletisim item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Iletisim> GetAllById(int? id = null)
        {
            throw new NotImplementedException();
        }

        public Iletisim GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateItem(Iletisim item)
        {
            throw new NotImplementedException();
        }
    }
}
