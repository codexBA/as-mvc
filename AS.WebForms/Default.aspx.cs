using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AS.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// event koji se pokrece klikom na dugme, a koje se nalazi u Default.aspx fajlu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Unnamed_Click(object sender, EventArgs e)
        {
           lblTest.Text = "Dugme je kliknuto!";
        }       
    }
}