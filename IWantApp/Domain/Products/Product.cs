namespace IWantApp.Domain.Products;

public class Product : Entity
{
    
    public string Name { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public bool HasStock {get; set;}
    //estou mandando herdar da classe abstrata os dados para juntar com estes
   
}
