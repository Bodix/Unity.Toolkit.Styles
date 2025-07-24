using UnityEngine;

namespace Toolkit.Styles
{
    [CreateAssetMenu(fileName = nameof(ShadowColorStyle), menuName = "Styles/" + nameof(ShadowColorStyle), order = 0)]
    public class ShadowColorStyle : Style<Color>
    {
        protected override Color DefaultProperty => new Color(0, 0, 0, 0.5f);
    }
}