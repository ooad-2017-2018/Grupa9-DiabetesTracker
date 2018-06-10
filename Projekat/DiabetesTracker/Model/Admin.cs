using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Admin
    {
        
        private static Admin uniqueInstance = null;
      

        public Admin()
        {
           
        }

        public static Admin GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Admin();
            }
            return uniqueInstance;
        }
        //omogucava dodavanje nove namirnice pri cemu se navodi vrsta, kolicina secera, masti i ugljikohodrata same namirnice
        public void DodajNamirnicuAdmin(String vrsta, Double secer, Double ugljikohidrati, Double masti)
        {
            
        }
    }
}
