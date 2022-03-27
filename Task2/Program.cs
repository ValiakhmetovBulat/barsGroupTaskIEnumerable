using Task2;

Entity createEntity(int id, int parentId, string Name)
{
    Entity entity = new Entity
    {
        Id = id,
        Name = Name,
        ParentId = parentId,
    };
    return entity;
}
Dictionary<int, List<Entity>> getEntitiesDictionary(List<Entity> entityList)
{
    Dictionary<int, List<Entity>> entitiesDictionary = new Dictionary<int, List<Entity>>();

    foreach (Entity entity in entityList)
    {
        if (entitiesDictionary.ContainsKey(entity.ParentId))
            entitiesDictionary[entity.ParentId].Add(entity);
        else
        {
            entitiesDictionary.Add(entity.ParentId, new List<Entity>());
            entitiesDictionary[entity.ParentId].Add(entity);
        }
    }
    return entitiesDictionary;
}


List<Entity> entities = new List<Entity>
{
    createEntity(1, 0, "Root entity"),
    createEntity(2, 1, "Child of 1 entity"),
    createEntity(3, 1, "Child of 1 entity"),
    createEntity(4, 2, "Child of 2 entity"),
    createEntity(5, 4, "Child of 4 entity"),
};
Dictionary<int, List<Entity>> dic = getEntitiesDictionary(entities);
foreach (var item in dic)
{
    Console.WriteLine(item.Key);
    item.Value.ForEach(e => Console.WriteLine(e.Id + " " + e.ParentId + " " + e.Name));
}