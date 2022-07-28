using IWantApp.InfraEstrutura.Data;

namespace IWantApp.EndPoints.Categories;

public class CategoryPost
{
    public static string Template => "/categories";

    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };

    public Delegate Handle => Action;

    public IResult Action(categoryRequest categoryRequest, applicationDbContext applicationDbContext)
    {
        return Results.Ok("Ok");
    }
}
                                           


