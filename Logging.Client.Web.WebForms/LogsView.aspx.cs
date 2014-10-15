using Logging.Model;
using Logging.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Logging.Client.Web.WebForms
{
    public partial class LogsView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ILogsRepository repository = new LINQtoSQLRepository("prodConnection");

            IEnumerable<Log> logs = repository.GetAllLogs();

            grid.RowDataBound += grid_RowDataBound;

            grid.DataSource = logs;
            grid.DataBind();
        }

        void grid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Log log = (Log)e.Row.DataItem;

                e.Row.CssClass += "log-" + log.Level.ToString().ToLower();
            }
        }
    }
}