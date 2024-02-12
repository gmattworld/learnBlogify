using Blogify.Models;
using Blogify.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Blogify.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController: ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    [HttpPost]
    public IActionResult CreateCategory(CategoryRequestModel request)
    {
        var response = _categoryRepository.CreateCategory(request.Name, request.Description);
        return Ok(response);
    }
}