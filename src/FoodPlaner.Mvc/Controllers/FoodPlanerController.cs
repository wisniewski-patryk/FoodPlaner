using FoodPlaner.Mvc.Models;
using FoodPlaner.Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodPlaner.Mvc.Controllers;

public class FoodPlanerController(FoodPlanerService service) : Controller
{
	private readonly FoodPlanerService service = service;
	public IActionResult Index()
	{
		var a = service.GetMeals();
		return View(new MealsModel(a.ToArray()));
	}
}
