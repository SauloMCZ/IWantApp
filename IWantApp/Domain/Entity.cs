namespace IWantApp.Domain;

public abstract class Entity  //classe criada para mesclar os dados, evitar as repetições

{
    public Entity()
    {
        Id = Guid.NewGuid(); //quanto instanciar categoria e produto o ID já será gerado através deste Guid novo
    }
    public Guid Id { get; set; }
    public string CAtegoryId { get; set; }
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }
    
}



