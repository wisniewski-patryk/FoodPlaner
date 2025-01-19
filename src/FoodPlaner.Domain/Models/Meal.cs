namespace FoodPlaner.Domain.Models;

public record Meal(
	int MealId,
	string Name,
	Cover Cover,
	string Type,
	string Taste,
	string[] Categories,
	string[] Equipment,
	string PrepTimeType,
	int PrepTimeValue,
	Product[] Products,
	string[] Recipe,
	string[] Tips,
	float DefaultProtein,
	float DefaultCarbs,
	float DefautFat,
	float DefaultKcal,
	int[] ProductsIds,
	string[] ProductsCategories);

