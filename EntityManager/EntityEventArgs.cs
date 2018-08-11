using System;
namespace NessCS
{
    public class EntityEventArgs : EventArgs
    {
        Entity entity;

        public EntityEventArgs(Entity entity)
        {
            this.entity = entity;
        }

        public Entity Entity
        {
            get => entity;
        }
    }
}
