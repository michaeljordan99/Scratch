using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scratch.Models;

namespace Scratch.Tests
{
    [TestClass]
    public class FluentInterfaceTests
    {
        [TestMethod]
        public void Fluent_Interface_Add_Member_To_Roles_Test()
        {
            IMember member = new Member("Michael", "Jordan");
            member.AddToRole("User").AddToRole("Reader").AddToRole("Writer").Create();
            Assert.IsTrue(member.Roles.Count == 3);
        }
    }
}
