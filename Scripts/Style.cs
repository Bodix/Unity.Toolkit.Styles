using NaughtyAttributes;
using UnityEngine;

namespace Toolkit.Styles
{
    // [CreateAssetMenu(fileName = nameof(ClassName), menuName = "Styles/" + nameof(ClassName), order = 0)]
    public abstract class Style<TProperty> : ScriptableObject
    {
        [SerializeField, OnValueChanged(nameof(UpdateAllStyles))]
        private TProperty _property;

        public TProperty Property
        {
            get => _property;
            private set
            {
                _property = value;

                UpdateAllStyles();
            }
        }
        protected abstract TProperty DefaultProperty { get; }

        private void Reset()
        {
            Property = DefaultProperty;
        }

        protected void UpdateAllStyles()
        {
            StyleComponent[] styles = FindObjectsOfType<StyleComponent>();
            foreach (StyleComponent style in styles)
                style.ApplyStyles();
        }
    }
}