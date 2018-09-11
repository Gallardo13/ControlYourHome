using Microsoft.VisualStudio.TestTools.UnitTesting;
using FridgeStorageProcessor;

namespace FridgeStorageProcessor.Tests
{
    [TestClass]
    public class LocalStorageProcessorTests
    {
        [TestMethod]
        public void ReadAllProductsTest()
        {
            var processor = new LocalStorageProcessor();
            processor.ReadProducts();
        }
    }
}
