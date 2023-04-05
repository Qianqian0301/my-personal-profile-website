using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalSearchController : ControllerBase
{
    private readonly ILogger<FoodSearchController> _logger;
    private readonly List<Animal> _animalList;

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
    }




    [HttpGet(Name = "SearchAnimal")]
    public List<Animal> SearchAnimal(string Species, int? maxAge)
    {





       var resList = new List<Animal>();
        
       

        resList = _animalList.Where(animal => 
        animal.Species == Species).ToList();
      
       
        /// Filter by age > 5
        // var oldAnimals = _animalList.Where(animal => animal.Age > 5);
        
        // foreach (var animal in oldAnimals)
        // {
        //     Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Species: {animal.Species}");
        // }
        return resList.ToList();
    }
}