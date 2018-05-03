using System;
using System.ComponentModel.DataAnnotations;

namespace Caelum.Fn23.Curso.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(255)]
        public string Resumo { get; set; }

        public string Categoria { get; set; }

        public DateTime? DataPublicacao { get; set; }

        public bool Publicado { get; set; }
    }
}