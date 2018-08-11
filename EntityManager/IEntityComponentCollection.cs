using System;
using System.Collections.Generic;

namespace NessCS
{
    public interface IEntityComponentCollection
    {
        void Add(EntityComponent item);
        T Find<T>() where T : EntityComponent;
        List<T> FindAll<T>() where T : EntityComponent;

        event EventHandler<EntityComponentEventArgs> ComponentAdded;

    }
}
