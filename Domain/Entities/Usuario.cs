using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; } // nunca armazene a senha pura!
        public DateTime CriadoEm { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
