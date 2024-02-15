using Xipa_Poshta.Utils.Interfaces;

namespace Xipa_Poshta.Utils.Abstract
{
    /// <summary>
    /// Abstract class for integer-based strong IDs on the platform.
    /// </summary>
    /// <typeparam name="T">The type of the implementing ID.</typeparam>
    public abstract record class PlatformIntegerStrongId<T>(int Value)
        : IPlatformIntegerStrongId<T> where T : IPlatformIntegerStrongId<T>
    {
        /// <inheritdoc/>
        public int CompareTo(T? other) => Value.CompareTo(other?.Value);

        /// <inheritdoc/>
        public sealed override string ToString() => Value.ToString();

    }


    /// <summary>
    /// Represents a strong ID for an entity.
    /// </summary>
    public sealed record class ItemId(int Value)
        : PlatformIntegerStrongId<ItemId>(Value)
    { }
}
