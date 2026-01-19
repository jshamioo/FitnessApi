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
    public ExerciseResponse CreateExercise([FromBody] CreateExerciseRequest createExerciseRequest)
    {
        return new ExerciseResponse(Guid.NewGuid(), createExerciseRequest.Name);
    }

    [HttpPut("{id:Guid}")]
    public ExerciseResponse UpdateExercise([FromRoute] Guid id, [FromBody] UpdateExerciseRequest updateExerciseRequest)
    {
        return new ExerciseResponse(id, updateExerciseRequest.Name);
    }
}
