using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace Toolkit.Styles
{
    [RequireComponent(typeof(Image))]
    public class ImageStyle : GenericGraphicStyle<Image>
    {
        [SerializeField, Expandable]
        private ImageTypeStyle _imageTypeStyle;

        private ImageTypeData _prevImageTypeData;

        public override void ApplyStyles()
        {
            base.ApplyStyles();

            if (_imageTypeStyle && _prevImageTypeData != _imageTypeStyle.Property)
            {
                _prevImageTypeData = _imageTypeStyle.Property;

                _component.type = _imageTypeStyle.Property.Type;
                _component.useSpriteMesh = _imageTypeStyle.Property.UseSpriteMesh;
                _component.preserveAspect = _imageTypeStyle.Property.PreserveAspect;
                _component.fillCenter = _imageTypeStyle.Property.FillCenter;
                _component.pixelsPerUnitMultiplier = _imageTypeStyle.Property.PixelsPerUnitMultiplier;
                _component.fillMethod = _imageTypeStyle.Property.FillMethod;
                _component.fillOrigin = _imageTypeStyle.Property.FillOrigin;
                _component.fillAmount = _imageTypeStyle.Property.FillAmount;
                _component.fillClockwise = _imageTypeStyle.Property.Clockwise;
            }
        }
    }
}