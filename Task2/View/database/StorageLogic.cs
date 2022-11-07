using database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace database
{
    public class StorageLogic
    {
        public void InsertCategory(Category category)
        {
            using (var context = new Context())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public void InsertProduct(Product product)
        {
            using (var context = new Context())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void InsertProductCategory(CategoryProduct category)
        {
            using (var context = new Context())
            {
                context.CategoryProducts.Add(category);
                context.SaveChanges();
            }
        }
        public List<Product> ReadProduct()
        {
            using (var context = new Context())
            {
                return context.Products
                .ToList();
            }
        }
        public List<Category> ReadCategoty()
        {
            using (var context = new Context())
            {
                return context.Categories
                .ToList();
            }
        }
        public List<CategoryProduct> ReadCategotyProducts()
        {
            using (var context = new Context())
            {
                return context.CategoryProducts
                .ToList();
            }
        }
    }
}
