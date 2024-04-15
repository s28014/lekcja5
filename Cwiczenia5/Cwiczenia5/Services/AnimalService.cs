using Cwiczenia5.Models;
using Cwiczenia5.Repositories;

namespace Cwiczenia5.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }

    public int addAnimal(Animal animal)
    {
        return _animalRepository.addAnimal(animal);
    }

    public int updateAnimal(Animal animal)
    {
        return _animalRepository.updateAnimal(animal);
    }

    public int deleteAnimal(int idAnimal)
    {
        return _animalRepository.deleteAnimal(idAnimal);
    }
}