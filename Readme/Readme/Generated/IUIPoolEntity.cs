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

    public interface IUIPoolEntity : IEntity {
        UIPositionComponent uIPosition { get; }
        bool hasUIPosition { get; }
        IUIPoolEntity AddUIPosition(int newX, int newY);
        IUIPoolEntity ReplaceUIPosition(int newX, int newY);
        IUIPoolEntity RemoveUIPosition();
    }
}
