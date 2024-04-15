using WebApplication1.Database;
using WebApplication1.Endpoints;
using WebApplication1.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<MockDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Minimal API
//app.MapAnimalEndpoints();

// Controllers
app.MapControllers();

app.MapGet("/animals", () =>
{
    var animals = StaticData.animals;
    return Results.Ok(animals);
});

app.MapGet("/animals/{id}", (int id) =>
{
    var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
    return animal != null ? Results.Ok(animal) : Results.NotFound();
});

app.MapPost("/animals", (Animal animal) =>
{
    StaticData.animals.Add(animal);
    return Results.Created($"/animals/{animal.Id}", animal);
});

app.MapPut("/animals/{id}", (int id, Animal update) =>
{
    var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
    if (animal == null)
        return Results.NotFound();

    animal.Name = update.Name;
    animal.Category = update.Category;
    animal.Weight = update.Weight;
    animal.FurColor = update.FurColor;
    return Results.NoContent();
});

app.MapDelete("/animals/{id}", (int id) =>
{
    var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
    if (animal == null)
        return Results.NotFound();

    StaticData.animals.Remove(animal);
    return Results.NoContent();
});


app.MapGet("/visits/{animalId}", (int animalId) =>
{
    var visits = StaticData.visits.Where(v => v.AnimalId == animalId).ToList();
    if (!visits.Any())
        return Results.NotFound();

    return Results.Ok(visits);
});

app.MapPost("/visits", (Visit visit) =>
{
    StaticData.visits.Add(visit);
    return Results.Created($"/visits/{visit.Id}", visit);
});


app.Run();





