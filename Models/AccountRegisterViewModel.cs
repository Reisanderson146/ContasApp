﻿using System.ComponentModel.DataAnnotations;

namespace ContasApp.Presentation.Models
{
    //Modelo de dados para a página de criação de onta de usuário
    public class AccountRegisterViewModel
    {
        [MaxLength(150, ErrorMessage ="Por faovr, informe no máximo {1} caracteres.")]
        [MinLength(8, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do usuário.")]
        public string? Nome { get; set; }


        [EmailAddress(ErrorMessage ="Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do usuário.")]

        public string? Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage ="Informe uma senha com letras maísculas, letras minúsculas, números, caracteres especiais e no mínimo 8 dígitos.")]
        [Required(ErrorMessage = "Por favor, informe a senha do usuário.")]

        public string? Senha { get; set; }

        [Compare("Senha", ErrorMessage ="Senhas não conferem, por favor verifique.")]
        [Required(ErrorMessage = "Por favor, confirme a senha do usuário.")]

        public string? SenhaConfirm { get; set; }

    }
}
