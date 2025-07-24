using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Toolkit.Styles
{
    public class TextStyle : StyleComponent<TMP_Text>
    {
        [SerializeField, Expandable]
        private FontAssetStyle _fontAssetStyle;
        [SerializeField, Expandable]
        private FontSizeStyle _fontSizeStyle;
        [SerializeField, Expandable]
        private ColorStyle _colorStyle;

        public override void ApplyStyles()
        {
            if (_fontAssetStyle && _component.font != _fontAssetStyle.Property)
                _component.font = _fontAssetStyle.Property;

            if (_fontSizeStyle && _component.fontSize != _fontSizeStyle.Property)
                _component.fontSize = _fontSizeStyle.Property;

            if (_colorStyle && _component.color != _colorStyle.Property)
                _component.color = _colorStyle.Property;
        }
    }
}