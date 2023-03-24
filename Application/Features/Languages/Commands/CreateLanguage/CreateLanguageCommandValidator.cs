using FluentValidation;


namespace Application.Features.Languages.Commands.CreateLanguage
{
    public class CreateLanguageCommandValidator:AbstractValidator<CreateLanguageCommand>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
