using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Dvd_CodeFirst.Models
{
    public class InicializarBanco :DropCreateDatabaseAlways<BancoContexto>
    {
        
        protected override void Seed(BancoContexto context)
        {
            //Cria algumas lista no banco de dados

            new List<Professor> {
                 new Professor{
                     Nome="Manoel Neto",
                     Materia="Asp.net Mvc",
                     Salario= 1000,
                     Telefone ="71 91013491",
                     TwitterBlog = "www.ManoelSystem.com.br",
                     Disponivel = true,
                     Admissao = new DateTime(2016,07, 03),

                     Alunos = new List<Aluno>{
                     new Aluno{
                         NomeAluno = "Gafonhoto 1 ",
                         Email="gaf@msn.com",
                         Aprovado = false,
                         Ano = 2016,
                         Inscricao = new DateTime(2016,07,03) ,

                         },

                         new Aluno{
                         NomeAluno = "Master 1 ",
                         Email="Master@msn.com",
                         Aprovado = false,
                         Ano = 2016,
                         Inscricao = new DateTime(2016,08,03) ,

                         }

                     },

                     Topicos = new List<Topico>{

                              new Topico { Descricao = "topico 1"},
                              new Topico { Descricao = "topico 2"}
                     }
                     
                 
                 }
            };

            new List<Professor> {
                 new Professor{
                     Nome="Aisten",
                     Materia="Fisica",
                     Salario= 1000,
                     Telefone ="71 91013491",
                     TwitterBlog = "www.aisten.com.br",
                     Disponivel = true,
                     Admissao = new DateTime(2016,07, 03),

                     Alunos = new List<Aluno>{
                     new Aluno{
                         NomeAluno = "Galileu 1 ",
                         Email="gaf@msn.com",
                         Aprovado = false,
                         Ano = 2016,
                         Inscricao = new DateTime(2016,07,03) ,

                         },

                         new Aluno{
                         NomeAluno = "Froud 1 ",
                         Email="Master@msn.com",
                         Aprovado = false,
                         Ano = 2016,
                         Inscricao = new DateTime(2016,08,03) ,

                         }

                     },

                     Topicos = new List<Topico>{

                              new Topico { Descricao = "Fisica quantica 3"},
                              new Topico { Descricao = "Fisca Universal 4"}
                     }
                     
                 
                 }

            }.ForEach(p => context.Professores.Add(p));
            base.Seed(context);
        }

    }
}