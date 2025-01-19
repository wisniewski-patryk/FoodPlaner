using FoodPlaner.Domain.Models;

namespace FoodPlaner.Domain.Ports;

public interface IMealDataService
{
	List<Meal> GetMeals();
}
