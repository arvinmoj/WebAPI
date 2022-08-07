using FluentValidation;

namespace WA.Domain.Validations.ToDo;
public class ToDoValidation : AbstractValidator<Models.ToDo.ToDoModel>
{
    public ToDoValidation() : base()
    {
        RuleFor(current => current.Title)
            .NotEmpty()
            .WithMessage(errorMessage: nameof(Resources.ErrorMessages.Required))

            .MinimumLength(4)
            .WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))

            .MaximumLength(20)
            .WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength))
            ;

        RuleFor(current => current.Description)
            .MinimumLength(8)
            .WithMessage(errorMessage: nameof(Resources.ErrorMessages.MinLength))

            .MaximumLength(1000)
            .WithMessage(errorMessage: nameof(Resources.ErrorMessages.MaxLength))
            ;

        RuleFor(current => current.State)
            .IsInEnum()
            .WithMessage(errorMessage: nameof(Resources.ErrorMessages.IsInEnum))
            ;
    }
}
