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

    public interface IMetaPoolEntity : IEntity {
        CoinsComponent coins { get; }
        bool hasCoins { get; }
        IMetaPoolEntity AddCoins(int newCount);
        IMetaPoolEntity ReplaceCoins(int newCount);
        IMetaPoolEntity RemoveCoins();
    }
}