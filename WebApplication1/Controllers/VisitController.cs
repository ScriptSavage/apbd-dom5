using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Controllers;


public class VisitsController
{
    // [HttpGet("{animalId}")]
    // public IActionResult GetVisitsForAnimal(int animalId)
    // {
    //     var visits = StaticData.visits.Where(v => v.AnimalId == animalId).ToList();
    //     if (!visits.Any())
    //         return NotFound();
    //
    //     return Ok(visits);
    // }
    //
    // [HttpPost]
    // public IActionResult AddVisit([FromBody] Visit visit)
    // {
    //     StaticData.visits.Add(visit);
    //     return CreatedAtAction(nameof(GetVisitsForAnimal), new { animalId = visit.AnimalId }, visit);
    // }
}