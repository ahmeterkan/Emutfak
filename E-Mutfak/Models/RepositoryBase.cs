using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Mutfak.Models
{
    public class RepositoryBase
    {
        //singleton pattern

        protected static MyDatabaseContext context;
        private static object _lockSync = new object();

        protected RepositoryBase()
        {
            CreatContext();
        }
        private static void CreatContext()
        {
            if (context == null)
            {
                //birden fazla thread işlem yapmasını engellemek için lock methodu kullanılır.
                lock (_lockSync)
                {
                    if (context == null)
                    {
                        context = new MyDatabaseContext();
                    }
                }
            }
        }
    }
}
