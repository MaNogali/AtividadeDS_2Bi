using System.ComponentModel.DataAnnotations;

namespace AtividadeDS_2Bi.Models
{
    public class Login
    {
        [Display(Name = "Usuário")]
        // Verifica se o email está escrito no padrão em que os emails são escritos, com @ e .com e essas coisas
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email Inválido")]
        public string? Usuario { get; set; }
        [Display(Name = "Senha")]
        public string? Password { get; set; }
    }
}
// get busca os dados
// set determina os dados