using FluentValidation;
using POS.Aplication.Dtos.Request;

namespace POS.Aplication.Validators.Category
{
    public class CategoryValidator : AbstractValidator<CategoryRequestDto>
    {
        public CategoryValidator() 
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo de Nombre no puede ser nulo.")
                .NotEmpty().WithMessage("El campo de nombre no puede ser vacio");
        }
    }
}
