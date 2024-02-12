using Blogify.Entities;
using Blogify.Persistence;
using Blogify.Repositories.IRepositories;

namespace Blogify.Repositories;

public class CategoryRepository: ICategoryRepository
{
    private readonly AppDBContext _context;

    public CategoryRepository(AppDBContext context)
    {
        _context = context;
    }
    public Category CreateCategory(string name, string description)
    {
        var category = new Category
        {
            Name = name,
            Description = description
        };
        _context.Categories.Add(category);
        _context.SaveChanges();
        return category;
    }

    public Category UpdateCategory(string categoryId, string name, string description)
    {
        throw new NotImplementedException();
    }

    public bool DeleteCategory(string categoryId)
    {
        throw new NotImplementedException();
    }

    public Category GetCategory(string categoryId)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetCategories()
    {
        throw new NotImplementedException();
    }

    public bool CategoryExists(string categoryId)
    {
        throw new NotImplementedException();
    }
}