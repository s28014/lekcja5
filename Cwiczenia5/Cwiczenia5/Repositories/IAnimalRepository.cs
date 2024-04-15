using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals();

    int addAnimal(Animal animal);

    int updateAnimal(Animal animal);

    int deleteAnimal(int idAnimal);
}