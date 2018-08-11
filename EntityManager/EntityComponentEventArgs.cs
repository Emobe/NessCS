using System;
namespace NessCS
{
    public class EntityComponentEventArgs : EventArgs
    {
        EntityComponent component;

        public EntityComponentEventArgs(EntityComponent component)
        {
            this.component = component;
        }

        public EntityComponent Component
        {
            get
            {
                return Component;
            }
        }
    }
}
