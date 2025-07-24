using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace Toolkit.Styles
{
    public abstract class GenericGraphicStyle<T> : StyleComponent<T> where T : Graphic
    {
        // Protected to be visible by NaughtyAttributes on derived classes.
        [SerializeField, Expandable]
        protected ColorStyle _colorStyle;

        public override void ApplyStyles()
        {
            if (_colorStyle && _component.color != _colorStyle.Property)
                _component.color = _colorStyle.Property;
        }
    }
}