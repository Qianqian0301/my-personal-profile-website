using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodSearchController : ControllerBase
{
    private readonly ILogger<FoodSearchController> _logger;

    public FoodSearchController(ILogger<FoodSearchController> logger)
    {
      _logger = logger;
    }
    private static readonly List<string> _foods = new List<string> 
    {
        "Pizza",
        "Burgers",
        "Sushi",
        "Tacos",
        "Fried Chicken",
        "Steak",
        "Pasta",
        "Salad",
        "Soup",
        "Sandwiches",
        "Fish and Chips",
        "Dim Sum",
        "Curry",
        "BBQ Ribs",
        "Pho",
        "Pad Thai",
        "Falafel",
        "Ramen",
        "Gyro"
    };

    [HttpGet(Name = "SearchFood")]
    public List<string> SearchFoods(string searchStr)
    {
        List<string> matchingFoods = new List<string>();
        foreach (string food in _foods)
        {
            if (food.StartsWith(searchStr, StringComparison.OrdinalIgnoreCase))
            {
                matchingFoods.Add(food);
            }
        }
        return matchingFoods;

    }
}