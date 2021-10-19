﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Off_Black.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Off_Black.Wep.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        #region SESSION DEMO
        public const string SessionKeyLastReviewed = "_SeesionKey";
        public int? SessionInfo_LastReviewed { get; private set; }
        #endregion

        public IViewComponentResult Invoke()
        {
            if (HttpContext.Session.GetString("_SeesionKey") != null)
            {
                string meep = HttpContext.Session.GetString("_SeesionKey");
                List<OrderItemDTO> session = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
                return View(session);
            }
            else
            {
                List<OrderItemDTO> test = null;
                return View(test);
            }
        }

    }
}
