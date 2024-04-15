using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Endpoints;

public static class AnimalEndpoints
{
    // public static void MapAnimalEndpoints(this WebApplication app)
    // {
    //     app.MapGet("/animals", () =>
    //     {
    //         // 200 - Ok
    //         // 201 - Created
    //         // 400 - Bad Request
    //         // 404 - Not Found
    //         var animals = StaticData.animals;
    //         return Results.Ok(animals);
    //     });
    //
    //     app.MapGet("/animals/{id}", (int id) =>
    //     {
    //         return Results.Ok(id);
    //     });
    //
    //     app.MapPost("/animals", (Animal animal) =>
    //     {
    //         return Results.Created("", animal);
    //     });
    //     
    //     
    //     app.MapGet("/visits/{animalId}", (int animalId) =>
    //     {
    //         var visits = StaticData.visits.Where(v => v.AnimalId == animalId).ToList();
    //         if (!visits.Any())
    //             return Results.NotFound();
    //
    //         return Results.Ok(visits);
    //     });
    //
    //     app.MapPost("/visits", (Visit visit) =>
    //     {
    //         StaticData.visits.Add(visit);
    //         return Results.Created($"/visits/{visit.Id}", visit);
    //     });
    //     
    //     
    // }
}


