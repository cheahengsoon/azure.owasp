﻿using System.Web;
using System.Web.Mvc;

namespace azure.owasp.web.adgroups
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
