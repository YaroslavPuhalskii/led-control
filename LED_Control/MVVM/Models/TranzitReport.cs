using System.Windows.Media;

namespace LED_Control.MVVM.Models;

internal class TranzitReport
{
    /// <summary>
    /// The ID of Vendor.
    /// </summary>
    public string? VendorId { get; set; }

    /// <summary>
    /// The ID of Product.
    /// </summary>
    public string? ProductId { get; set; }

    /// <summary>
    /// The ID of Command.
    /// </summary>
    public Command? Command { get; set; }

    /// <summary>
    /// The Color the user has chosen.
    /// </summary>
    public Color Color { get; set; }
}
