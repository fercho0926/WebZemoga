using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComTrans;

namespace Services
{
    public class AccessService
    {


        public bool SaveForm(BlogClass blog)
        {
            try
            {
            //    blog blogInsert = new blog
            //    {

            //        authorName = form.authorName,
            //        tittle = form.tittle,
            //        content = form.content,

            //        date = form.date,
            //        status = form.status
            //    };

            //    bd.blog.Add(blogInsert);
            //    bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
