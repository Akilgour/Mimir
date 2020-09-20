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
            RuleFor(x => x.Name).NotEmpty().WithMessage("You must enter a name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("You must enter a description");
        }
    }
}
