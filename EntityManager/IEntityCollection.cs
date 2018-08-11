using System;
using System.Collections.Generic;
namespace NessCS
{
    public interface IEntityCollection : ICollection<Entity>
    {
        Entity Find(string name);
        Entity FindWith<T>() where T : EntityComponent;
        List<Entity> FindAllWith<T>() where T : EntityComponent;
    }
}
