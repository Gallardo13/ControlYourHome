using System;
namespace ControlYourFridge.Api.Database
{
    public interface ISqlStrings
    {
        string GetAllUsers { get; }

        string GetAllFridges { get; }

        string GetAllProductTypes { get; }

        string GetAllProducts { get; }

        string GetAllFridgeProducts { get; }

        string GetAllRecipes { get; }

        string GetAllUserRecipes { get; }
    }
}
