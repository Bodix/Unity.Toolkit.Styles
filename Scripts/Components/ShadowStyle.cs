using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace Toolkit.Styles
{
    [AddComponentMenu("Styles/Shadow Style")]
    [RequireComponent(typeof(Shadow))]
    public class ShadowStyle : StyleComponent<Shadow>
    {
        [SerializeField, Expandable]
        private ShadowColorStyle _effectColorStyle;
        [SerializeField, Expandable]
        private ShadowDistanceStyle _effectDistanceStyle;

        public override void ApplyStyles()
        {
            if (_effectColorStyle && _component.effectColor != _effectColorStyle.Property)
                _component.effectColor = _effectColorStyle.Property;

            if (_effectDistanceStyle && _component.effectDistance != _effectDistanceStyle.Property)
                _component.effectDistance = _effectDistanceStyle.Property;
        }
    }
}