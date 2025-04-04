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
        
        RuleFor(x => x.Bio)
            .NotEmpty()
            .WithMessage("A bio é obrigatória.")
            .MaximumLength(500)
            .WithMessage("A bio deve ter no máximo 500 caracteres.");

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("O email é obrigatório.")
            .EmailAddress()
            .WithMessage("O email deve ser um endereço de email válido.");

        RuleFor(x => x.Localizacao)
            .NotEmpty()
            .WithMessage("A localização é obrigatória.")
            .MaximumLength(100)
            .WithMessage("A localização deve ter no máximo 100 caracteres.");

        RuleFor(x => x.Servicos)
            .NotEmpty()
            .WithMessage("Os serviços são obrigatórios.")
            .Must(servicos => servicos.Count <= 5)
            .WithMessage("Você pode selecionar no máximo 5 serviços.");
    }
}