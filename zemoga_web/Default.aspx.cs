using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facade;
using ComTrans;

namespace zemoga_web
{
    public partial class _Default : Page
    {

        Fcd facade = new Fcd();
        protected void Page_Load(object sender, EventArgs e)
        {

            getInfo();
        }



        public List<BlogClass> getInfo() {

           




            return (facade.getInfo());

        }


    }
}