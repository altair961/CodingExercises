﻿using NUnit.Framework;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Tests
{
    [TestFixture]
    public class HomeControllerIndexTests
    {
        [Test]
        public void Puts_Message_In_ViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result.ViewBag.Message);
        }
    }
}
