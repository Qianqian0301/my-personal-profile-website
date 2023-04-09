using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalSearchController : ControllerBase
{
    private readonly ILogger<FoodSearchController> _logger;
    private readonly List<Animal> _animalList;
    private readonly List<Animal> _animalList2;

    public AnimalSearchController(ILogger<FoodSearchController> logger)
    {
        _logger = logger;
        List<Animal> animals = new List<Animal>();
        animals.Add(new Animal("Lion", 5, "Mammal"));
        animals.Add(new Animal("Toucan", 2, "Bird"));
        animals.Add(new Animal("Gorilla", 8, "Mammal"));
        animals.Add(new Animal("Penguin", 3, "Bird"));
        animals.Add(new Animal("Elephant", 12, "Mammal"));
        animals.Add(new Animal("Dolphin", 6, "Mammal"));
        animals.Add(new Animal("Kangaroo", 4, "Mammal"));
        animals.Add(new Animal("Zebra", 7, "Mammal"));
        animals.Add(new Animal("Koala", 1, "Mammal"));
        animals.Add(new Animal("Giraffe", 9, "Mammal"));
        animals.Add(new Animal("Hippopotamus", 10, "Mammal"));
        animals.Add(new Animal("Crocodile", 15, "Reptile"));
        _animalList = animals;


         List<Animal> animals2 = new List<Animal>();
        animals2.Add(new Animal("Lion", 5, "Mammal"));
        animals2.Add(new Animal("Toucan", 2, "Bird"));
        animals2.Add(new Animal("Gorilla", 8, "Mammal"));
        animals2.Add(new Animal("Penguin", 3, "Bird"));
        animals2.Add(new Animal("Elephant", 12, "Mammal"));
        animals2.Add(new Animal("Dolphin", 6, "Mammal"));
        animals2.Add(new Animal("Kangaroo", 4, "Mammal"));
        animals2.Add(new Animal("Zebra", 7, "Mammal"));
        animals2.Add(new Animal("Koala", 1, "Mammal"));
        animals2.Add(new Animal("Giraffe", 9, "Mammal"));
        animals2.Add(new Animal("Hippopotamus", 10, "Mammal"));
        animals2.Add(new Animal("Crocodile", 15, "Reptile"));
        animals2.Add(new Animal("Golden Eagle", 4, "Bird"));
        animals2.Add(new Animal("Grizzly Bear", 6, "Mammal"));
        animals2.Add(new Animal("Polar Bear", 9, "Mammal"));
        animals2.Add(new Animal("Walrus", 12, "Mammal"));
        animals2.Add(new Animal("Blue Whale", 25, "Mammal"));
        animals2.Add(new Animal("Great White Shark", 20, "Fish"));
        animals2.Add(new Animal("Killer Whale", 18, "Mammal"));
        animals2.Add(new Animal("Raccoon", 2, "Mammal"));
        animals2.Add(new Animal("Red Panda", 3, "Mammal"));
        animals2.Add(new Animal("Snow Leopard", 7, "Mammal"));
        animals2.Add(new Animal("Tiger", 8, "Mammal"));
        animals2.Add(new Animal("Giant Panda", 4, "Mammal"));
        animals2.Add(new Animal("American Bison", 12, "Mammal"));
        _animalList2 = animals2;
    }




    // [HttpGet(Name = "SearchAnimal")]
    // public List<Animal> SearchAnimal(string Species, int? maxAge)
    // {
    //    var resList = new List<Animal>();

       

    //     resList = _animalList.Where(animal => animal.Species == Species).ToList();
    //     resList= resList.Where(animal => animal.Age <= maxAge).ToList();
    //     return resList.ToList();
    // }


    [HttpGet(Name = "SearchAnimal")]
    public List<Animal> SearchAnimal(string Species)
    {
       var resList = new List<Animal>();
       
        
        return resList.ToList();
        
    }
}