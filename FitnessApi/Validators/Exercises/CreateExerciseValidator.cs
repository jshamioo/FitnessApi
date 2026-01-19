using FitnessApi.Dtos.Exercises;
using FluentValidation;

namespace FitnessApi.Validators.Exercises;

public class CreateExerciseValidator : AbstractValidator<CreateExerciseRequest>
{
    public CreateExerciseValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();
    }
}
