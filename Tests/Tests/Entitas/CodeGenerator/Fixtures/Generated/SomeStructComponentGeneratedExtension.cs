//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public class SomeStructComponent : IComponent {
    public SomeStruct value;
}

namespace Entitas {
    public interface ISomeStructEntity : IEntity {
        SomeStructComponent someStruct { get; }
        bool hasSomeStruct { get; }
        ISomeStructEntity AddSomeStruct(SomeStruct newValue);
        ISomeStructEntity ReplaceSomeStruct(SomeStruct newValue);
        ISomeStructEntity RemoveSomeStruct();
    }

    public partial class Entity {
        public SomeStructComponent someStruct { get { return (SomeStructComponent)GetComponent(ComponentIds.SomeStruct); } }

        public bool hasSomeStruct { get { return HasComponent(ComponentIds.SomeStruct); } }

        public Entity AddSomeStruct(SomeStruct newValue) {
            var component = CreateComponent<SomeStructComponent>(ComponentIds.SomeStruct);
            component.value = newValue;
            return (Entity)AddComponent(ComponentIds.SomeStruct, component);
        }

        public Entity ReplaceSomeStruct(SomeStruct newValue) {
            var component = CreateComponent<SomeStructComponent>(ComponentIds.SomeStruct);
            component.value = newValue;
            ReplaceComponent(ComponentIds.SomeStruct, component);
            return this;
        }

        public Entity RemoveSomeStruct() {
            return (Entity)RemoveComponent(ComponentIds.SomeStruct);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherSomeStruct;

        public static IMatcher SomeStruct {
            get {
                if (_matcherSomeStruct == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.SomeStruct);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherSomeStruct = matcher;
                }

                return _matcherSomeStruct;
            }
        }
    }
}