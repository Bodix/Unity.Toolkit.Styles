using UnityEngine;

namespace Toolkit.Styles
{
    [CreateAssetMenu(fileName = nameof(FontSizeStyle), menuName = "Styles/" + nameof(FontSizeStyle), order = 0)]
    public class FontSizeStyle : Style<float>
    {
        protected override float DefaultProperty => 36;
    }
}