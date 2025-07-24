using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace Toolkit.Styles
{
    [Serializable]
    public struct ImageTypeData
    {
        public Image.Type Type;
        [AllowNesting, ShowIf(nameof(IsSimple))]
        public bool UseSpriteMesh;
        [AllowNesting, ShowIf(EConditionOperator.Or, nameof(IsSimple), nameof(IsFilled))]
        public bool PreserveAspect;
        [AllowNesting, ShowIf(EConditionOperator.Or, nameof(IsSliced), nameof(IsTiled))]
        public bool FillCenter;
        [AllowNesting, ShowIf(EConditionOperator.Or, nameof(IsSliced), nameof(IsTiled))]
        public float PixelsPerUnitMultiplier;
        [AllowNesting, ShowIf(nameof(IsFilled))]
        public Image.FillMethod FillMethod;
        [AllowNesting, ShowIf(EConditionOperator.And, nameof(IsFilled), nameof(IsOriginHorizontal)), Label("Fill Origin")]
        public Image.OriginHorizontal OriginHorizontal;
        [AllowNesting, ShowIf(EConditionOperator.And, nameof(IsFilled), nameof(IsOriginVertical)), Label("Fill Origin")]
        public Image.OriginVertical OriginVertical;
        [AllowNesting, ShowIf(EConditionOperator.And, nameof(IsFilled), nameof(IsOrigin90)), Label("Fill Origin")]
        public Image.Origin90 Origin90;
        [AllowNesting, ShowIf(EConditionOperator.And, nameof(IsFilled), nameof(IsOrigin180)), Label("Fill Origin")]
        public Image.Origin180 Origin180;
        [AllowNesting, ShowIf(EConditionOperator.And, nameof(IsFilled), nameof(IsOrigin360)), Label("Fill Origin")]
        public Image.Origin360 Origin360;
        [AllowNesting, ShowIf(nameof(IsFilled)), Range(0, 1)]
        public float FillAmount;
        [AllowNesting, ShowIf(EConditionOperator.And, nameof(IsFilled), nameof(IsRadial))]
        public bool Clockwise;

        public int FillOrigin => GetFillOrigin();
        private bool IsSimple => Type == Image.Type.Simple;
        private bool IsSliced => Type == Image.Type.Sliced;
        private bool IsTiled => Type == Image.Type.Tiled;
        private bool IsFilled => Type == Image.Type.Filled;
        private bool IsOriginHorizontal => FillMethod == Image.FillMethod.Horizontal;
        private bool IsOriginVertical => FillMethod == Image.FillMethod.Vertical;
        private bool IsOrigin90 => FillMethod == Image.FillMethod.Radial90;
        private bool IsOrigin180 => FillMethod == Image.FillMethod.Radial180;
        private bool IsOrigin360 => FillMethod == Image.FillMethod.Radial360;
        private bool IsRadial => FillMethod == Image.FillMethod.Radial90 || FillMethod == Image.FillMethod.Radial180 || FillMethod == Image.FillMethod.Radial360;

        public ImageTypeData(Image.Type type)
        {
            Type = type;
            UseSpriteMesh = false;
            PreserveAspect = false;
            FillCenter = true;
            PixelsPerUnitMultiplier = 1;
            FillMethod = Image.FillMethod.Radial360;
            OriginHorizontal = Image.OriginHorizontal.Left;
            OriginVertical = Image.OriginVertical.Bottom;
            Origin90 = Image.Origin90.BottomLeft;
            Origin180 = Image.Origin180.Bottom;
            Origin360 = Image.Origin360.Bottom;
            FillAmount = 1;
            Clockwise = true;
        }

        public int GetFillOrigin()
        {
            switch (FillMethod)
            {
                case Image.FillMethod.Horizontal:
                    return (int)OriginHorizontal;
                case Image.FillMethod.Vertical:
                    return (int)OriginVertical;
                case Image.FillMethod.Radial90:
                    return (int)Origin90;
                case Image.FillMethod.Radial180:
                    return (int)Origin180;
                case Image.FillMethod.Radial360:
                    return (int)Origin360;
                default:
                    return FillOrigin;
            }
        }

        public bool Equals(ImageTypeData other)
        {
            return Type == other.Type 
                && UseSpriteMesh == other.UseSpriteMesh 
                && PreserveAspect == other.PreserveAspect 
                && FillCenter == other.FillCenter 
                && PixelsPerUnitMultiplier.Equals(other.PixelsPerUnitMultiplier) 
                && FillMethod == other.FillMethod 
                && OriginHorizontal == other.OriginHorizontal 
                && OriginVertical == other.OriginVertical 
                && Origin90 == other.Origin90 
                && Origin180 == other.Origin180 
                && Origin360 == other.Origin360 
                && FillAmount.Equals(other.FillAmount) 
                && Clockwise == other.Clockwise;
        }

        public override bool Equals(object obj)
        {
            return obj is ImageTypeData other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (int)Type;
                hashCode = (hashCode * 397) ^ UseSpriteMesh.GetHashCode();
                hashCode = (hashCode * 397) ^ PreserveAspect.GetHashCode();
                hashCode = (hashCode * 397) ^ FillCenter.GetHashCode();
                hashCode = (hashCode * 397) ^ PixelsPerUnitMultiplier.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)FillMethod;
                hashCode = (hashCode * 397) ^ (int)OriginHorizontal;
                hashCode = (hashCode * 397) ^ (int)OriginVertical;
                hashCode = (hashCode * 397) ^ (int)Origin90;
                hashCode = (hashCode * 397) ^ (int)Origin180;
                hashCode = (hashCode * 397) ^ (int)Origin360;
                hashCode = (hashCode * 397) ^ FillAmount.GetHashCode();
                hashCode = (hashCode * 397) ^ Clockwise.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(ImageTypeData left, ImageTypeData right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ImageTypeData left, ImageTypeData right)
        {
            return !left.Equals(right);
        }
    }
}