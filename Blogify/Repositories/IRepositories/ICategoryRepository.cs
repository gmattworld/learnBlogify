using Blogify.Entities;

namespace Blogify.Repositories.IRepositories;

public interface ICategoryRepository
{
    Category CreateCategory(string name, string description);
    Category UpdateCategory(string categoryId, string name, string description);
    bool DeleteCategory(string categoryId);
    Category GetCategory(string categoryId);
    List<Category> GetCategories();
    bool CategoryExists(string categoryId);
}