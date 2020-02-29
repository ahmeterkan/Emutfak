using E_Mutfak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Mutfak.BusinessLayer
{
    public class UserManager : ManagerBase<User>
    {
        public new int Update(User obj)
        {
            User db = Find(x => x.Id == obj.Id);

            db.TCKN = obj.TCKN;
            db.Sifre = obj.Sifre;
            db.paraBirimi = obj.paraBirimi;
            db.Fiyat = obj.Fiyat;
            db.AdSoyad = obj.AdSoyad;

            return base.Update(db);
        }

    }
}
