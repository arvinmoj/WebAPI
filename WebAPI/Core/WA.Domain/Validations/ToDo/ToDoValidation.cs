using FluentValidation;

namespace WA.Domain.Validations.ToDo;
public class ToDoValidation : AbstractValidator<Models.ToDo.ToDoModel>
{
    public ToDoValidation() : base()
    {
        RuleFor(current => current.Title)
            .NotEmpty()
            .WithMessage(errorMessage: "You did not specify {PropertyName} ")

            .MinimumLength(4)
            .WithMessage("{PropertyName} Must Be Longer Than 4 Characters")

            .MaximumLength(20)
            .WithMessage("{PropertyName} Must Be Less Than Or Equal To 20 Characters")
            ;

        RuleFor(current => current.Description)
            .MinimumLength(8)
            .WithMessage("{PropertyName} Must Be Longer Than 8 Characters")

            .MaximumLength(1000)
            .WithMessage("{PropertyName} Must Be Less Than Or Equal To 1000 Characters")
            ;

        RuleFor(current => current.State)
            .IsInEnum()
            .WithMessage("{PropertyName} has a range of values which does not include {PropertyValue}")
            ;
    }
}
