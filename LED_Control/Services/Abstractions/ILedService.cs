using LED_Control.MVVM.Models;
using System.Threading.Tasks;

namespace LED_Control.Services.Abstractions;

internal interface ILedService
{
    /// <summary>
    /// Checking the device connection.
    /// </summary>
    /// <param name="vendorId"></param>
    /// <param name="productId"></param>
    /// <returns></returns>
    bool IsConnected(string? vendorId, string? productId);

    /// <summary>
    /// Change RGB color on the device.
    /// </summary>
    /// <param name="report"></param>
    Task SetColorAsync(TranzitReport report);
}
