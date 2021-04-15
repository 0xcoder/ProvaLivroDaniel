using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroLivro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string AnoPu { get; set; }
        public string Editora { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }


    }
}
