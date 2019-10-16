using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNESS.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        [Column("IdUsuario")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Display(Name = "Nome:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve ter menos de 50 caracteres")]
        public string Nome { get; set; }
        [Display(Name = "CPF:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O CPF é obrigatório")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CPF deve ter 14 caracteres")]
        public string Cpf { get; set; }
        [Display(Name = "Telefone:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O telefone é obrigatório")]
        [StringLength(19, MinimumLength = 15, ErrorMessage = "O telefone deve ter entre 15 e 19 caracteres")]
        public string Telefone { get; set; }
    }
}
