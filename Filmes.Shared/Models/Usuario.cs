using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmes.Shared.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Hash { get; set; }

        public string Nome { get; set; }
    }

    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(r => r.Login)
                .Empty()
                .WithMessage("É necessário informar o login")
                .EmailAddress()
                .WithMessage("É necessário que o login seja um e-mail");

            RuleFor(r => r.Nome)
                .Empty()
                .WithMessage("É necessário informar o nome")
                .MinimumLength(3)
                .WithMessage("É necessário que o nome tenha ao menos 3 e no máximo 150 caracteres")
                .MaximumLength(150)
                .WithMessage("É necessário que o nome tenha ao menos 3 e no máximo 150 caracteres");
        }
    }
}
