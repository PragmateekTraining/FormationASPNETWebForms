using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicFormSample
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            decimal left = decimal.Parse(leftInput.Text, CultureInfo.InvariantCulture);
            decimal right = decimal.Parse(rightInput.Text, CultureInfo.InvariantCulture);

            decimal result = left + right;

            resultOutput.Text = result.ToString(CultureInfo.InvariantCulture);
        }
    }
}