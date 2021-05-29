using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComTrans;
using Services;
using Data;

namespace Business
{
    public class Bsn
    {

        AccessService AC = new AccessService();
     
        Ad accesodatos = new Ad();
        
        public bool SaveForm(BlogClass blog)
        {

            //return (AC.SaveForm(blog));
            return (accesodatos.SaveForm(blog));
        }

        public List<BlogClass> getInfo()
        {
            return (accesodatos.getInfo());

        }


    }
}
