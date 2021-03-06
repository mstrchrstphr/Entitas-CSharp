//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public interface IUIPositionEntity : IEntity {
        UIPositionComponent uIPosition { get; }
        bool hasUIPosition { get; }
        IUIPositionEntity AddUIPosition(int newX, int newY);
        IUIPositionEntity ReplaceUIPosition(int newX, int newY);
        IUIPositionEntity RemoveUIPosition();
    }

    public partial class Entity {
        public UIPositionComponent uIPosition { get { return (UIPositionComponent)GetComponent(UIComponentIds.UIPosition); } }

        public bool hasUIPosition { get { return HasComponent(UIComponentIds.UIPosition); } }

        public Entity AddUIPosition(int newX, int newY) {
            var component = CreateComponent<UIPositionComponent>(UIComponentIds.UIPosition);
            component.x = newX;
            component.y = newY;
            return (Entity)AddComponent(UIComponentIds.UIPosition, component);
        }

        public Entity ReplaceUIPosition(int newX, int newY) {
            var component = CreateComponent<UIPositionComponent>(UIComponentIds.UIPosition);
            component.x = newX;
            component.y = newY;
            ReplaceComponent(UIComponentIds.UIPosition, component);
            return this;
        }

        public Entity RemoveUIPosition() {
            return (Entity)RemoveComponent(UIComponentIds.UIPosition);
        }
    }
}

    public partial class UIMatcher {
        static IMatcher _matcherUIPosition;

        public static IMatcher UIPosition {
            get {
                if (_matcherUIPosition == null) {
                    var matcher = (Matcher)Matcher.AllOf(UIComponentIds.UIPosition);
                    matcher.componentNames = UIComponentIds.componentNames;
                    _matcherUIPosition = matcher;
                }

                return _matcherUIPosition;
            }
        }
    }
