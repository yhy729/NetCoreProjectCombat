using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreProjectCombat.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreProjectCombat.Controllers
{
    /*
     * Controller要放在Controller目录下面 继承Controller类 后缀必须是Controller
     * 视图： Views/控制器名称目录/方法名称.cshtml
     */
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("您好！");
            int i = 1 + 2;
            var user = new UserModel
            {
                Name = "张三"
            };
            ViewBag.Sex = "男";
            return View(user);
        }

        public IActionResult Print()
        {
            return Content("打印东西");
        }
    }
}
