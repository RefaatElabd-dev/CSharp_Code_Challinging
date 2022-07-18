using System;
/// <summary>
/// Indicates that an enumeration can be treated as a bit field
/// </summary>
namespace AdvancedEnums.Helper
{
    public enum SingleHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };

    // Define an Enum with FlagsAttribute.
    [Flags]
    public enum MultiHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };

    [Flags]
    public enum PhoneService
    {
        None = 0,
        LandLine = 1,
        Cell = 2,
        Fax = 4,
        Internet = 8,
        Other = 16
    }
}
