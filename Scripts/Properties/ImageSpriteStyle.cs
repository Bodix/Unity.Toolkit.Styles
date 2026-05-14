using UnityEngine;

namespace Toolkit.Styles
{
	[CreateAssetMenu(fileName = nameof(ImageSpriteStyle), menuName = "Styles/" + nameof(ImageSpriteStyle), order = 0)]
	public class ImageSpriteStyle : Style<Sprite>
	{
		protected override Sprite DefaultProperty => null;
	}
}