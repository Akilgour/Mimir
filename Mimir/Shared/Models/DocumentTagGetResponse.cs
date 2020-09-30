using FluentValidation;
using MediatR;
using Mimir.Shared.Validator;
using System;

namespace Mimir.Shared.Models
{
    public class DocumentTagGetResponse : IRequest<DocumentTagUpdateResponse>
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
                .NotEmpty().WithMessage(ErrorMessages.StringNotEmpty)
                .Length(2, 50).WithMessage(ErrorMessages.StringLength);

            RuleFor(x => x.Description)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage(ErrorMessages.StringNotEmpty)
            .Length(2, 50).WithMessage(ErrorMessages.StringLength);
        }
    }
}