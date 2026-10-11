# Toolkit.Styles

Shared look for uGUI. A style is an asset that holds one value: a color, a font, a font size, a sprite, an image type or a shadow. A style component on a UI object takes values from style assets and writes them into the Unity component next to it. Change the asset, and every object that uses it changes too.

## Requirements

- Perfect Foundation: the inspector attributes come from it
- TextMeshPro
- uGUI

## How it works

1. Create a style asset: **Create → Styles**, then the style you need, for example **ColorStyle**.
2. Add a style component to a UI object: **Add Component → Styles**, then **Text Style**, **Image Style**, **Graphic Style** or **Shadow Style**.
3. Drag style assets into the fields of the component. An empty field leaves that value alone: set it on the Unity component as usual.

- The component applies its styles in the Editor: when you add it, change a field or load the object. When you change a style asset in the inspector, every loaded style component applies it again.
- The value lands in the Unity component, so the scene or the prefab stores it. Styles do not run at runtime.
- Code can read the value of a style through its `Property`. Use this when a script sets a value itself, for example a color that depends on game state. Do not put a style component on such a value: it has one owner, the script.
- TextMeshPro Auto Size overwrites the font size. Do not give a font size style to a text with Auto Size.

## Style assets

| Asset | Value | Used by |
|-------|-------|---------|
| ColorStyle | Color | Text Style, Image Style, Graphic Style |
| FontAssetStyle | TextMeshPro font asset | Text Style |
| FontSizeStyle | Font size | Text Style |
| ImageSpriteStyle | Sprite | Image Style |
| ImageTypeStyle | Image type and its options: sprite mesh, aspect, fill center, pixels per unit multiplier, fill method, origin, amount and direction | Image Style |
| ShadowColorStyle | Shadow color | Shadow Style |
| ShadowDistanceStyle | Shadow offset | Shadow Style |

## Style components

| Component | Needs | Applies |
|-----------|-------|---------|
| Text Style | TextMeshPro text | Font, font size, color |
| Image Style | Image | Color, sprite, image type |
| Graphic Style | Any Graphic | Color |
| Shadow Style | Shadow | Shadow color, shadow offset |

## Add your own style

1. The value: derive a class from `Style<T>`, add `CreateAssetMenu` and return the default value from `DefaultProperty`.
2. The component: derive from `StyleComponent<TComponent>`, where `TComponent` is the Unity component it styles. Write the value in `ApplyStyles`. Skip an empty field and write only a changed value, as the built-in components do.
