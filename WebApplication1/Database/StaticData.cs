using WebApplication1.Model;

namespace WebApplication1.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal { Id = 1, Name = "Max", Category = "Pies", Weight = 30.5, FurColor = "Brązowy" },
        new Animal { Id = 2, Name = "Luna", Category = "Kot", Weight = 5.0, FurColor = "Czarny" },
        new Animal { Id = 3, Name = "Charlie", Category = "Królik", Weight = 1.2, FurColor = "Biały" }
    };
    public static List<Visit> visits = new List<Visit>()
    {
        new Visit { Id = 1, AnimalId = 1, VisitDate = DateTime.Now.AddDays(-10), Description = "Routine check-up", Cost = 100.00m },
        new Visit { Id = 2, AnimalId = 2, VisitDate = DateTime.Now.AddDays(-5), Description = "Vaccination", Cost = 120.00m },
        new Visit { Id = 3, AnimalId = 3, VisitDate = DateTime.Now.AddDays(-3), Description = "Emergency care", Cost = 300.00m },
        new Visit { Id = 4, AnimalId = 1, VisitDate = DateTime.Now, Description = "Follow-up visit", Cost = 90.00m }
    };
}


