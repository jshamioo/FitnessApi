using Microsoft.AspNetCore.Mvc;
using FitnessApi.Dtos.Exercises;

namespace FitnessApi.Controllers;


[ApiController]
[Route("[controller]")]
public class ExercisesController : ControllerBase
{
    [HttpGet]
    public ExerciseResponse GetExercises()
    {
        return new ExerciseResponse(Guid.NewGuid(), "Exercise name!");
    }

    [HttpGet("{id:Guid}")]
    public ExerciseResponse GetExercise([FromRoute] Guid id)
    {
        return new ExerciseResponse(id, "hello");
    }

    [HttpPost]
    public ExerciseResponse CreateExercise([FromBody] ExerciseRequest exerciseRequest)
    {
        return new ExerciseResponse(Guid.NewGuid(), exerciseRequest.Name);
    }

    [HttpPut("{id:Guid}")]
    public ExerciseResponse UpdateExercise([FromRoute] Guid id, [FromBody] ExerciseRequest exerciseRequest)
    {
        return new ExerciseResponse(id, exerciseRequest.Name);
    }
}
