using System;
namespace NessCS
{
    public interface IEntityComponent
    {
        void Initialise();
        Entity Owner { get; }
    }
}
