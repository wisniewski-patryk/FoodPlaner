namespace FoodPlaner.Mvc.Models;

public record MealsModel(Meal[] Meals);

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

public record Cover(
	string FullPath,
	string ThumbFullPath,
	Uri Url,
	Uri ThumbUrl);

public record Product(
	int Id,
	string Name,
	string Type,
	string[] Categories,
	float Protein,
	float Carbs,
	float Fat,
	float Kcal,
	string Measure,
	float? GramsPerMeasure,
	object AdditionalData,
	string FilteredBy,
	int? Amount,
	Macro CalculatedMacro);

public record Macro(
	float Protein,
	float Carbs,
	float Fat,
	float Kcal);
