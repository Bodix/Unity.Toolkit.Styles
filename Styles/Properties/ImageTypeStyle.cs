using UnityEngine;
using UnityEngine.UI;

namespace Toolkit.Styles
{
    [CreateAssetMenu(fileName = nameof(ImageTypeStyle), menuName = "Styles/" + nameof(ImageTypeStyle), order = 0)]
    public class ImageTypeStyle : Style<ImageTypeData>
    {
        protected override ImageTypeData DefaultProperty => new ImageTypeData(Image.Type.Simple);
    }
}