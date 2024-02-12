namespace Blogify.Models;

public class CategoryResponseModel: CategoryRequestModel
{
    public string Id { get; set; }
}

public class CategoryRequestModel
{
    public string Name { get; set; }
    public string Description { get; set; }
}