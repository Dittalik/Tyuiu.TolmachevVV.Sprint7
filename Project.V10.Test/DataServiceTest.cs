using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V10.Lib;
using System.Collections.Generic;

namespace Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void KeyIndexTest()
        {
            List<TableElement> tableElements = new List<TableElement>
            {
                new TableElement { Key = 0 },
                new TableElement { Key = 1 },
                new TableElement { Key = 2 },
                new TableElement { Key = 3 }
            };
            for (int i = 0; i < tableElements.Count; i++)
            {
                TableElement element = tableElements[i];
                Assert.AreEqual(i, tableElements.KeyIndex(element.Key));
            }
        }
        [TestMethod]
        public void GetElementByKeyTest()
        {
            List<TableElement> tableElements = new List<TableElement>
            {
                new TableElement { Key = 0 },
                new TableElement { Key = 1 },
                new TableElement { Key = 2 },
                new TableElement { Key = 3 }
            };
            for (int i = 0; i < tableElements.Count; i++)
            {
                TableElement element = tableElements[i];
                Assert.AreEqual(element, tableElements.GetElementByKey(element.Key));
            }
        }
        [TestMethod]
        public void Keys()
        {
            List<TableElement> tableElements = new List<TableElement>
            {
                new TableElement { Key = 0 },
                new TableElement { Key = 1 },
                new TableElement { Key = 2 },
                new TableElement { Key = 3 }
            };
            CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3 }, tableElements.Keys());
        }
        [TestMethod]
        public void CompareStringLengthTest()
        {
            Assert.IsTrue(DataService.CompareStringLength("123456", 5, '>'));
            Assert.IsFalse(DataService.CompareStringLength("123456", 5, '<'));
            Assert.IsTrue(DataService.CompareStringLength("123456", 7, '<'));
            Assert.IsFalse(DataService.CompareStringLength("123456", 7, '>'));
            Assert.IsFalse(DataService.CompareStringLength("123456", 6, '>'));
            Assert.IsFalse(DataService.CompareStringLength(2, 1, '>'));
        }
        [TestMethod]
        public void CompareNumberValueTest()
        {
            Assert.IsTrue(DataService.CompareNumberValue(6, 5, '>'));
            Assert.IsFalse(DataService.CompareNumberValue(6, 5, '<'));
            Assert.IsTrue(DataService.CompareNumberValue(6, 7, '<'));
            Assert.IsFalse(DataService.CompareNumberValue(6, 7, '>'));
            Assert.IsFalse(DataService.CompareNumberValue(6, 6, '>'));
            Assert.IsFalse(DataService.CompareNumberValue("6", 1, '>'));
        }
        [TestMethod]
        public void CompareDoubleValueTest()
        {
            Assert.IsTrue(DataService.CompareDoubleValue(6.0, 5, '>'));
            Assert.IsFalse(DataService.CompareDoubleValue(6.0, 5, '<'));
            Assert.IsTrue(DataService.CompareDoubleValue(6.0, 7, '<'));
            Assert.IsFalse(DataService.CompareDoubleValue(6.0, 7, '>'));
            Assert.IsFalse(DataService.CompareDoubleValue(6.0, 6, '>'));
            Assert.IsFalse(DataService.CompareDoubleValue(6, 1, '>'));
        }
    }
}
