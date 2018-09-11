using System;
namespace FridgeStorageProcessor
{
    public interface IStorageProcessor
    {
        void ReadProducts();

        void InsertProduct();

        void UpdateProduct();

        void DeleteProduct();
    }
}
