﻿using System.Web;
using System.Web.Mvc;

namespace comp229_mvc_lesson_9 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
