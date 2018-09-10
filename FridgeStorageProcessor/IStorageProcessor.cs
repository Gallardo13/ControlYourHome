using System;
namespace FridgeStorageProcessor
{
    public interface IStorageProcessor
    {
        void Read();

        void Insert();

        void Update();

        void Delete();
    }
}
