using CoolCoffeeStore.DAL;
using CoolCoffeeStore.Model;
using System.Collections.Generic;

namespace CoolCoffeeStore.App.Services
{
    public class CoffeeDataService: ICoffeeDataService
    {
        readonly ICoffeeRepository _repository = new CoffeeRepository();

        public List<Coffee> GetAllCoffees()
        {
            return _repository.GetCoffees();
        }
    }
}
