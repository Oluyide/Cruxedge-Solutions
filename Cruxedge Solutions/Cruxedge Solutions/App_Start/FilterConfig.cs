﻿using System.Web;
using System.Web.Mvc;

namespace Cruxedge_Solutions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
