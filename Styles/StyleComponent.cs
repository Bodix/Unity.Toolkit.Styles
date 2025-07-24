using UnityEngine;

namespace Toolkit.Styles
{
    public abstract class StyleComponent<TComponent> : StyleComponent where TComponent : Component
    {
        [SerializeField, HideInInspector]
        protected TComponent _component;

        private void OnValidate()
        {
            if (!_component)
                _component = GetComponent<TComponent>();

            ApplyStyles();
        }
    }

    public abstract class StyleComponent : MonoBehaviour
    {
        public abstract void ApplyStyles();
    }
}