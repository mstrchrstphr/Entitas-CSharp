//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.PoolEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Entitas;

namespace Entitas {

    public interface IPoolBPoolEntity : IEntity {
        BComponent b { get; }
        bool hasB { get; }
        IPoolBPoolEntity AddB();
        IPoolBPoolEntity ReplaceB();
        IPoolBPoolEntity RemoveB();
        CComponent c { get; }
        bool hasC { get; }
        IPoolBPoolEntity AddC();
        IPoolBPoolEntity ReplaceC();
        IPoolBPoolEntity RemoveC();
        DComponent d { get; }
        bool hasD { get; }
        IPoolBPoolEntity AddD();
        IPoolBPoolEntity ReplaceD();
        IPoolBPoolEntity RemoveD();
    }
}