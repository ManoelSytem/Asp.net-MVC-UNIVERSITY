using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Dvd_CodeFirst.Models
{
    public class Professor
    {

        [Key, Column(Order = 0)]
        public int IDProfessor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Professor"), Column(Order = 1)]
        [MaxLength(8, ErrorMessage = "o Tamanho Mininimo são de 8 Caracteres")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Materia { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}",
                       ApplyFormatInEditMode = true,
                       NullDisplayText = "sem remuneração")]
        [Range(1200, 25000, ErrorMessage = "O Salário devera ser entre 1.200 e 2.500 R$")]
        public decimal? Salario { get; set; }



        [Display(Name = "Twitter/Blog")]
        [Column("ContatoDigital", Order = 5)]
        public string TwitterBlog { get; set; }

        public bool Disponivel { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Admissao { get; set; }

        public List<Aluno> Alunos { get; set; }

        public List<Topico> Topicos { get; set; }
    }
}