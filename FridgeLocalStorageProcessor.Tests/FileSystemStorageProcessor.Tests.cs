using System;
using FridgeStorageProcessor;

namespace FridgeLocalStorageProcessor.Tests
{


    // TODO научиться запускать тесты на Mac

    public class FileSystemStorageProcessorTests
    {
        public void TestRead() 
        {
            var processor = new FileSystemStorageProcessor();
            /*var products =*/ processor.ReadProducts();
        }
    }
}
