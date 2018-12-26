using CoolCoffeeStore.Model;
using System.Collections.Generic;

namespace CoolCoffeeStore.App.Services
{
    public interface ICoffeeDataService
    {
        List<Coffee> GetAllCoffees();
    }
}
