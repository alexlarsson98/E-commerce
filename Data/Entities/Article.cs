using E_commerce.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Data.Entities
{
    public class Article
    {
        public Article(string name, string description, int price, Uri image)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            UrlSlug = name.Slugify();
        }

        public Article(int id, string name, string description, int price, Uri image, string urlSlug)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            UrlSlug = urlSlug;
        }

        public int Id { get; protected set; }

        [Required]
        public string Name { get; protected set; }

        [Required]
        public string Description { get; protected set; }

        [Required]
        public int Price { get; protected set; }

        [Required]
        public Uri Image { get; protected set; }

        public string UrlSlug { get; protected set; }

        public ICollection<Category> Categories { get; protected set; } = new List<Category>();
    }
}
