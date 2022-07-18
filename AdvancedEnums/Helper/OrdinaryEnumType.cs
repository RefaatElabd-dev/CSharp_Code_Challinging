namespace AdvancedEnums.Helper
{
    public enum Color
    {
        Red,            // by convention the First value is The Default Value for the Type
        Blue,
        Green,
        Yellow,
        Brown,
        Orange
    }
    //for more Readability
    //public enum Color
    //{
    //    Red    = 0,
    //    Blue   = 1,
    //    Green  = 2,
    //    Yellow = 3,
    //    Brown  = 4,
    //    Orange = 5
    //}

    //We can Put its values Manually
    public enum WeekDay
    {
        Sat  = 5,            
        Sun  = 6,
        Mon  = 0,  // 0 Value is the Default value.
        Tues = 1,
        Wen  = 2,
        Thar = 3, 
        Fri  = 4
    }

    public enum Status
    {
        New = 10,
        Old = 20,
        Actual = 30,

        // Use Status.Default to specify default status in your code. 
        Default = New    // => it will Takes The 0 index By Default for the type array
    }

}
