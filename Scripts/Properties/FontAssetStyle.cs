using TMPro;
using UnityEngine;

namespace Toolkit.Styles
{
    [CreateAssetMenu(fileName = nameof(FontAssetStyle), menuName = "Styles/" + nameof(FontAssetStyle), order = 0)]
    public class FontAssetStyle : Style<TMP_FontAsset>
    {
        protected override TMP_FontAsset DefaultProperty => null;
    }
}