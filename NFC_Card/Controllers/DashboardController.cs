using GemBox.Spreadsheet;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TTGarmentAdmin.Models;
using TTGarmentAdmin.Properties;

namespace TTGarmentAdmin.Controllers
{
    public class DashboardController : Controller
    {
        private Repository repository;

        private DashboardModel model;

        // GET: Dashboard
        public async Task<ActionResult> Index()
        {
            this.repository = new Repository();
            this.model = new DashboardModel();
            this.model.DashboardCountsDetail = await this.repository.GetDashboardCount();
            if (this.model.DashboardCountsDetail == null)
            {
                this.model.DashboardCountsDetail = new DashboardCounts();
            }

            return View(this.model);
        }        

        public ActionResult LogOut()
        {
            Session["LoginUserName"] = null;
            return RedirectToAction("Index", "Login");
        }

        
    }
}