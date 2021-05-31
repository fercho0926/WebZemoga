using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComTrans;

namespace Data
{

    public class Ad
    {


        zemogaBDEntities bd = new zemogaBDEntities();

        public bool SaveForm(BlogClass form)
        {
            try
            {
                blog blogInsert = new blog
                {
                    authorName = form.authorName,
                    tittle = form.tittle,
                    content = form.content,
                    date = form.date,
                    status = form.status,
                };

                bd.blog.Add(blogInsert);
                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<BlogClass> getInfo()
        {


            List<BlogClass> listform = new List<BlogClass>();
            var data = bd.blog.ToArray();
            BlogClass blogGetInfo = new BlogClass
            {
                authorName = data[0].authorName,
                tittle = data[0].tittle,
                content = data[0].content,
                //date = data[0].date,
                status = data[0].status
            };
            listform.Add(blogGetInfo);
            return (listform);
        }
    }
}
