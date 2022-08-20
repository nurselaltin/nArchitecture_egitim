namespace Core.Persistence.Repositories;

public class Entity  //Veritabanı nesnesi olduğunu belirtmek için kullanıyoruz
{
    public int Id { get; set; }

    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}