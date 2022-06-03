using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp3
{
    class KayitCONTEXT:DbContext
    {
        public KayitCONTEXT()
        {

        }
        public DbSet<KAYIT> kayitlar { get; set; }
    }
}
