namespace FoodPlaner.Domain.Models;

public record Cover(
	string FullPath,
	string ThumbFullPath,
	Uri Url,
	Uri ThumbUrl);

