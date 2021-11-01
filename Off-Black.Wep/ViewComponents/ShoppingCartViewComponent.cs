using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Off_Black.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Off_Black.Wep.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        #region SESSION
        public const string SessionKeyLastReviewed = "_SeesionKey";
        public int? SessionInfo_LastReviewed { get; private set; }
        #endregion

        public IViewComponentResult Invoke()
        {
            if (HttpContext.Session.GetString("_SeesionKey") != null)
            {
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
