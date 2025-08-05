using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime CriadoEm { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public Guid? UsuarioId { get; set; } // pode ser anônimo
        public Usuario? Usuario { get; set; }
    }
}
