using UnityEngine;

namespace Toolkit.Styles
{
    [CreateAssetMenu(fileName = nameof(ShadowDistanceStyle), menuName = "Styles/" + nameof(ShadowDistanceStyle), order = 0)]
    public class ShadowDistanceStyle : Style<Vector2>
    {
        protected override Vector2 DefaultProperty => new Vector2(1, -1);
    }
}