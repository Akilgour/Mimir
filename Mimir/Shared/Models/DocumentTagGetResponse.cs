using FluentValidation;
using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagGetResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class DocumentTagGetResponseValidator : AbstractValidator<DocumentTagGetResponse>
    {
        public DocumentTagGetResponseValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("You must enter a {PropertyName}")
                .Length(2, 50).WithMessage("Length({TotalLength}) of {PropertyName} is Invalid.  Must be between {MinLength} - {MaxLength}");

            RuleFor(x => x.Description)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("You must enter a {PropertyName}")
            .Length(2, 50).WithMessage("Length({TotalLength}) of {PropertyName} Invalid.  Must be between {MinLength} - {MaxLength}");
        }
    }
}
