using FoodPlaner.Domain.Models;
using FoodPlaner.Domain.Ports;
using Microsoft.AspNetCore.Mvc;

namespace FoodPlaner.Mvc.Controllers;

public class FoodPlanerController(IMealDataService service) : Controller
{
	private readonly  IMealDataService service = service;

	[ResponseCache(Duration = 604800)] //cache for 7 days * 24 h * 60 min * 60 sek
	public IActionResult Index()
	{
		var a = service.GetMeals();
		return View(new MealsModel(a.ToArray()));
	}
}
