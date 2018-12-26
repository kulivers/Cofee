using CoolCoffeeStore.Model;
using System;
using System.Collections.Generic;
namespace CoolCoffeeStore.DAL
{
    public interface ICoffeeRepository
    {
        Coffee GetACoffee();
        Coffee GetCoffeeById(int id);
        List<Coffee> GetCoffees();
    }
}
