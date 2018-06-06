using System.ComponentModel;

namespace RTX.Core.Enums
{
    /// <summary>
    /// Тип цены
    /// </summary>
    public enum PriceTypes
    {
        [Description("В час")]
        Hour = 1,
        [Description("В день")]
        Day = 2,
        [Description("Километр")]
        Km = 3,
        [Description("м2")]
        Qm = 4
    }
}
