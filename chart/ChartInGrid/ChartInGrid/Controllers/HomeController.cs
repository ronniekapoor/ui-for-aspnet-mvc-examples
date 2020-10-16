﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChartInGrid.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ChartInGrid.Controllers
{
    public class HomeController : Controller
    {
        static List<ViewModel> data = new List<ViewModel>()
            {
                 new ViewModel
                 {
                      ID = 1,
                      ChartData = new List<ChartItem>() 
                        {
                            new ChartItem
                            {
                                 Category = "Category1",
                                  Value = 1,
                                  Value1 = 2
                            },
                            new ChartItem
                            {
                                 Category = "Category2",
                                  Value = 3,
                                  Value1 = 1
                            },
                            new ChartItem
                            {
                                 Category = "Category3",
                                 Value = 2,
                                 Value1 = 5
                            }
                        }
                 },
                 new ViewModel
                 {
                      ID = 2,
                      ChartData = new List<ChartItem>() 
                        {
                            new ChartItem
                            {
                                Category = "Category1",
                                Value = 4,
                                Value1 = 2
                            },
                            new ChartItem
                            {
                                Category = "Category2",
                                Value = 1,
                                Value1 = 2
                            },
                            new ChartItem
                            {
                                Category = "Category3",
                                Value = 3,
                                Value1 = 3
                            }
                        }
                 }
            };

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(data);
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {

            return Json(data.ToDataSourceResult(request));
        }

        public ActionResult ReadChartData(int id)
        {
            return Json(data.First(v => v.ID == id).ChartData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        //Test 
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
