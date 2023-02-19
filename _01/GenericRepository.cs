namespace _01;

public class GenericRepository<TId> where TId : notnull
{
    private Dictionary<TId, IEntity<TId>> Db { get; }

    public GenericRepository()
    {
        Db = new Dictionary<TId, IEntity<TId>>();
    }

    public IEntity<TId> Get(TId id)
    {
        return Db[id];
    }

    public IList<IEntity<TId>> GetAll()
    {
        return Db.Values.ToList();
    }

    public void Add(IEntity<TId> item)
    {
        Db.Add(item.Id, item);
    }

    public void Update(TId id, IEntity<TId> values)
    {
        Db[id] = values;
    }

    public IEntity<TId> Delete(TId id)
    {
        var toDelete = Db[id];
        Db.Remove(id);

        return toDelete;
    }
}