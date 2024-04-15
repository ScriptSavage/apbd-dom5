using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;


public static class AnimalEndpoints
{
    // public static void MapAnimalEndpoints(this WebApplication app)
    // {
    //     app.MapGet("/api/animals", () =>
    //     {
    //         var animals = StaticData.animals;
    //         return Results.Ok(animals);
    //     });
    //
    //     app.MapGet("/api/animals/{id}", (int id) =>
    //     {
    //         var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
    //         return animal != null ? Results.Ok(animal) : Results.NotFound();
    //     });
    //
    //     app.MapPost("/api/animals", (Animal animal) =>
    //     {
    //         StaticData.animals.Add(animal);
    //         return Results.Created($"/api/animals/{animal.Id}", animal);
    //     });
    //
    //     app.MapGet("/api/visits/{animalId}", (int animalId) =>
    //     {
    //         var visits = StaticData.visits.Where(v => v.AnimalId == animalId).ToList();
    //         if (!visits.Any())
    //             return Results.NotFound();
    //
    //         return Results.Ok(visits);
    //     });
    //
    //     app.MapPost("/api/visits", (Visit visit) =>
    //     {
    //         StaticData.visits.Add(visit);
    //         return Results.Created($"/api/visits/{visit.Id}", visit);
    //     });
    // }
}

