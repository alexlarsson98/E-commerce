using E_commerce.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Data.Entities
{
    public class Category
    {
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            UrlSlug = name.Slugify();
        }

        public Category(int id, string name, string urlSlug)
        {
            Id = id;
            Name = name;
            UrlSlug = urlSlug;
        }

        public int Id { get; protected set; }

        [Required]
        public string Name { get; protected set; }

        public string UrlSlug { get; protected set; }

        public ICollection<Article> Articles { get; protected set; } = new List<Article>();

        public Category ParentCategory { get; protected set; }
    }
}
