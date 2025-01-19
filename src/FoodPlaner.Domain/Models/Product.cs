namespace FoodPlaner.Domain.Models;

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

