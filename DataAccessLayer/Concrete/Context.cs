using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // burada tanımlanacak prob'lar sql'de tablo adı olarak karşılık bulacak
    public class Context: DbContext  //: bir başka sınıftan bişeyelerin kalıtsal yolla alınması anlamına geliyor.
    {
        // bir başka katmanın prob'larını kullanmak istersen öncelikle o katmanları referans olarak eklemek gerekir. Bunun için Başvuruların (referances) üzerine sağ tıkla ve yeni başvuru ekle
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
