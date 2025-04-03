using FluentValidation;
using Plataforma.Backend_.DTOs;

public class CriarProfissionalDtoValidator : AbstractValidator<CriarProfissionalDto>
{
    public CriarProfissionalDtoValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome é obrigatório.");

        RuleFor(x => x.Telefone)
            .NotEmpty()
            .WithMessage("O telefone é obrigatório.")
            .Matches(@"^\d{9,11}$")
            .WithMessage("O telefone deve conter 9 ou 11 dígitos.");

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("O email é obrigatório.")
            .EmailAddress()
            .WithMessage("O email deve ser um endereço de email válido.");
    }
}