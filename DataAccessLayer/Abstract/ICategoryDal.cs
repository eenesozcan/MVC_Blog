using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
      
        // void Insert(Category p); ekleme yapılacak ancak bir parametreye ihtiyaç var bu nedenele category sınıfından gelen bir p parametresi olacak. bu p paramtresi sayesinde category sınıfındaki tüm prob'lara erişim sağlanabilecek





    }
}
