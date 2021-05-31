using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        IAboutDal _abouteDal;

        public AboutManager(IAboutDal abouteDal)
        {
            _abouteDal = abouteDal;
        }

        public void AboutDelete(About about)
        {
            _abouteDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _abouteDal.Update(about);
        }

        public void AboutAdd(About about)
        {
            _abouteDal.Insert(about);

        }

        public About GetByID(int id)
        {
            return _abouteDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _abouteDal.List();
        }
    }
}
