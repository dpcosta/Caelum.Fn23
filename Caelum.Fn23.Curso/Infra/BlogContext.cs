using Caelum.Fn23.Curso.Models;
using System.Data.Entity;

namespace Caelum.Fn23.Curso.Infra
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogContext() : base("name=blog")
        { }
    }
}