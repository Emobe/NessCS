using System;
namespace NessCS
{
    public abstract class EntityComponent : IEntityComponent
    {
        Entity owner;
        int updateOrder;
        bool enabled = true;

        public Entity Owner { get => owner; set => owner = value; }

        public void Initialise()
        {
            throw new NotImplementedException();
        }
    }
}
