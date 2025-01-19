using FoodPlaner.Domain.Models;
using FoodPlaner.Domain.Ports;
using System.Text.Json;

namespace FoodPlaner.Mvc.Services;

public class FoodPlanerService(ILogger<FoodPlanerService> logger) : IMealDataService
{
	private readonly ILogger<FoodPlanerService> logger = logger;

	public List<Meal> GetMeals()
	{
		var options = new JsonSerializerOptions()
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
		};

		var files = Directory.GetFiles("data");
		var meals = new List<Meal>();

		foreach(var file in files)
		{
			var mealJson = File.ReadAllText(file);
			var mealModel = JsonSerializer.Deserialize<MealsModel>(mealJson, options);
			var meal = mealModel?.Meals.FirstOrDefault();
			if (meal is not null) meals.Add(meal);
		}
		return meals;
	}
}
