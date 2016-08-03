//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public interface IPositionEntity {
        PositionComponent position { get; }
        bool hasPosition { get; }
        IPositionEntity AddPosition(int newX, int newY);
        IPositionEntity ReplacePosition(int newX, int newY);
        IPositionEntity RemovePosition();
    }

    public partial class Entity {
        public PositionComponent position { get { return (PositionComponent)GetComponent(ComponentIds.Position); } }

        public bool hasPosition { get { return HasComponent(ComponentIds.Position); } }

        public Entity AddPosition(int newX, int newY) {
            var component = CreateComponent<PositionComponent>(ComponentIds.Position);
            component.x = newX;
            component.y = newY;
            return AddComponent(ComponentIds.Position, component);
        }

        public Entity ReplacePosition(int newX, int newY) {
            var component = CreateComponent<PositionComponent>(ComponentIds.Position);
            component.x = newX;
            component.y = newY;
            ReplaceComponent(ComponentIds.Position, component);
            return this;
        }

        public Entity RemovePosition() {
            return RemoveComponent(ComponentIds.Position);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherPosition;

        public static IMatcher Position {
            get {
                if (_matcherPosition == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Position);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherPosition = matcher;
                }

                return _matcherPosition;
            }
        }
    }
}
