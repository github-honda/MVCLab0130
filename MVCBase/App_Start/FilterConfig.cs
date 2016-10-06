﻿using System.Web;
using System.Web.Mvc;

namespace MVCBase
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // global filter for ExceptionFilter. Same as [HandlerError] in each Controller level or action.
            filters.Add(new HandleErrorAttribute()); // 預設的exception處理程序
        }
    }
}
