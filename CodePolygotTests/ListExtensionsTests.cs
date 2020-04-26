using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CodePolyglot.Extensions;
namespace CodePolygotTests
{
    [TestClass]
    public class ListExtensionsTests
    {
        [TestMethod]
        public void SingleItemToSinglePartion()
        {
            var list = new List<string>
            {
                "C#"
            };

            Assert.IsNotNull(list);
            Assert.AreEqual(1, list.Count);

            var partitioned = list.Partition(3);

            Assert.IsNotNull(partitioned);
            Assert.AreEqual(1, partitioned.Count());
            Assert.AreEqual(1, partitioned.ElementAt(0).Count());
        }

        [TestMethod]
        public void ThreeItemsToSinglePartion()
        {
            var list = new List<string>
            {
                "C#",
                "Java",
                "Node"
            };

            Assert.IsNotNull(list);
            Assert.AreEqual(3, list.Count);

            var partitioned = list.Partition(3);

            Assert.IsNotNull(partitioned);
            Assert.AreEqual(1, partitioned.Count());
            Assert.AreEqual(3, partitioned.ElementAt(0).Count());
        }

        [TestMethod]
        public void FourItemsToTwoPartion()
        {
            var list = new List<string>
            {
                "C#",
                "Java",
                "Node",
                "SQL"
            };

            Assert.IsNotNull(list);
            Assert.AreEqual(4, list.Count);

            var partitioned = list.Partition(3);

            Assert.IsNotNull(partitioned);
            Assert.AreEqual(2, partitioned.Count());
            Assert.AreEqual(3, partitioned.ElementAt(0).Count());
            Assert.AreEqual(1, partitioned.ElementAt(1).Count());
        }

        [TestMethod]
        public void EmptyListPartitionsToEmpty()
        {
            var list = new List<string>();

            var partitioned = list.Partition(3);

            Assert.AreEqual(0, partitioned.Count());
        }
    }
}
