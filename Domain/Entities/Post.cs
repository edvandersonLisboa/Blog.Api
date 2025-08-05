using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string ConteudoHtml { get; set; }
        public string? ImagemCapaUrl { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        public Guid AutorId { get; set; }
        public Usuario Autor { get; set; }

        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<PostTag> Tags { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}
