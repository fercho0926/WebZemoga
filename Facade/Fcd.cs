using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComTrans;
using Business;

namespace Facade
{
    public class Fcd
    {

        Bsn business = new Bsn();
        public bool SaveForm(BlogClass blog)
        {
            return (business.SaveForm(blog));
        }

        public List<BlogClass> getInfo()
        {
            return (business.getInfo());
        }
    }
}
