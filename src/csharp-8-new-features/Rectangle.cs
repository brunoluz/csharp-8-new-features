using System;
namespace csharp_8_new_features
{
    // You can apply the readonly modifier to members of a struct.
    // It indicates that the member doesn't modify state.
    // It's more granular than applying the readonly modifier to a struct declaration.

    public struct Rectangle
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public readonly decimal Area => X * Y;

        public readonly override string ToString() => $"Rectangle area is {Area}";
    }
}
