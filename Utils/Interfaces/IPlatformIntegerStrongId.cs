namespace Xipa_Poshta.Utils.Interfaces
{
    public interface IPlatformIntegerStrongId<T> : IComparable<T>
    {
        /// <summary>
        /// Gets the integer value of the ID.
        /// </summary>
        int Value { get; }
    }
}
