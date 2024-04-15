using Cwiczenia5.Models;

namespace Cwiczenia5.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();

    int addAnimal(Animal animal);

    int updateAnimal(Animal animal);

    int deleteAnimal(int idAnimal);
}