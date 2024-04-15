using System.Data.SqlClient;
using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private readonly IConfiguration _configuration;

    public AnimalRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        using var con = new SqlConnection(_configuration[
            "Data Source=db-mssql;Initial Catalog=2019SBD;" +
            "Integrated Security=True;Trust Server Certificate=True"]);
        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT idAnimal, imie, kategoria, masa, kolor_sierści FROM Animal";

        var dr = cmd.ExecuteReader();
        var animals = new List<Animal>();
        
    }

    int addAnimal(Animal animal);

    int updateAnimal(Animal animal);

    int deleteAnimal(int idAnimal);
}