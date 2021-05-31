using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ComTrans;

namespace Services
{
    public class AccessService
    {



        public string GetItems(string filter)
        {
            var url = $"https://localhost:44395/api/blogs?filter={filter}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                // Do something with responseBody
                                Console.WriteLine(responseBody);
                            }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }

            return ("REVISAR");
        }







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
