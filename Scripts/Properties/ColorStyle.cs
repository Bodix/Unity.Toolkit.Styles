using UnityEngine;

namespace Toolkit.Styles
{
    [CreateAssetMenu(fileName = nameof(ColorStyle), menuName = "Styles/" + nameof(ColorStyle), order = 0)]
    public class ColorStyle : Style<Color>
    {
        protected override Color DefaultProperty => Color.white;
    }
}