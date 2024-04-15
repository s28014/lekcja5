using Cwiczenia5.Models;
using Cwiczenia5.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia5.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalsController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult addAnimal(Animal animal)
    {
        var affectedCount = _animalService.addAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPut("{idAnimal:int}")]
    public IActionResult updateAnimal(int idAnimal, Animal animal)
    {
        var affectedCount = _animalService.updateAnimal(animal);
        return NoContent();
    }
    
    [HttpDelete("{idAnimal:int}")]
    public IActionResult deleteAnimal(int idAnimal)
    {
        var affectedCount = _animalService.deleteAnimal(idAnimal);
        return NoContent();
    }
}