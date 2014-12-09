using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeTofood.Controllers;
using System.Web.Mvc;

namespace OdeTofood.Test
{
     [TestClass]
    public class HomeControllerIndexTests
    {

        [TestMethod]
        public void Puts_Message_In_ViewBag() 
        {
            var controller = new HomeController();
            ViewResult result = controller.Index();
            Assert.IsNotNull(result.ViewBag.Message);

        }

    }
}
