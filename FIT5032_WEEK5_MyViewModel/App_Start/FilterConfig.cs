﻿using System.Web;
using System.Web.Mvc;

namespace FIT5032_WEEK5_MyViewModel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
