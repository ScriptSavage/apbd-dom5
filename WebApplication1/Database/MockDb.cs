using WebApplication1.Model;

namespace WebApplication1.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();

    public MockDb()
    {
        Animals.Add(new Animal { Id = 1, Name = "Max", Category = "Pies", Weight = 30.5, FurColor = "Brązowy" });
        Animals.Add(new Animal { Id = 2, Name = "Luna", Category = "Kot", Weight = 5.0, FurColor = "Czarny" });

        Visits.Add(new Visit { Id = 1, AnimalId = 1, VisitDate = DateTime.Now.AddDays(-10), Description = "Routine check-up", Cost = 100.00m });
    }

    public Animal GetAnimalById(int id)
    {
        return Animals.FirstOrDefault(a => a.Id == id);
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void UpdateAnimal(Animal animal)
    {
        var existingAnimal = GetAnimalById(animal.Id);
        if (existingAnimal != null)
        {
            existingAnimal.Name = animal.Name;
            existingAnimal.Category = animal.Category;
            existingAnimal.Weight = animal.Weight;
            existingAnimal.FurColor = animal.FurColor;
        }
    }

    public void DeleteAnimal(int id)
    {
        var animal = GetAnimalById(id);
        if (animal != null)
        {
            Animals.Remove(animal);
        }
    }

    public List<Visit> GetVisitsForAnimal(int animalId)
    {
        return Visits.Where(v => v.AnimalId == animalId).ToList();
    }

    public void AddVisit(Visit visit)
    {
        Visits.Add(visit);
    }
}


