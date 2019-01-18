using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcBook.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBook.Logics.Tests
{
    [TestClass()]
    public class StringToIntLogicTests
    {
        [TestMethod()]
        public void StringToIntTest_AがNull()
        {
            string A = null;
            string B = "test";
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void StringToIntTest_BがNull()
        {
            string A = "test";
            string B = null;
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void StringToIntTest_A変換整形できない()
        {
            string A = "test";
            string B = "0";
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void StringToIntTest_B変換整形できない()
        {
            string A = "0";
            string B = "test";
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void StringToIntTest_AはBより大きい()
        {
            string A = "1";
            string B = "0";
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.AreEqual(result, 1);
        }

        [TestMethod()]
        public void StringToIntTest_AはBに等しい()
        {
            string A = "2";
            string B = "2";
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.AreEqual(result, 4);
        }

        [TestMethod()]
        public void StringToIntTest_AがBより小さい()
        {
            string A = "3";
            string B = "4";
            int? result = new MvcBook.Logics.StringToIntLogic().StringToInt(A, B);
            Assert.AreEqual(result, 7);
        }
    }
}