﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc; //added for HtmlHelper

namespace PerfectPetalsSite_v1.Utilities
{
    public static class Utilities
    {
        public static string IsActive(this HtmlHelper html,
                              string control,
                              string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control == routeControl &&
                               action == routeAction;

            return returnActive ? "active" : "";
        }
    }
}