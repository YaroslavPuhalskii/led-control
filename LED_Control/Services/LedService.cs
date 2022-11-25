using System;
using System.Linq;
using System.Threading.Tasks;
using HidLibrary;
using FluentValidation;
using LED_Control.MVVM.Models;
using LED_Control.Services.Abstractions;

namespace LED_Control.Services;

internal class LedService : ILedService
{
    private HidDevice? _hidDevice;

    private readonly AbstractValidator<TranzitReport> _validator;

    public LedService(AbstractValidator<TranzitReport> validator)
        => _validator = validator;

    public bool IsConnected(string? vendorId, string? prooductId)
    {
        var device = HidDevices.Enumerate()
            .FirstOrDefault(device => device.Attributes.VendorHexId == $"0x{vendorId}"
            && device.Attributes.ProductHexId == $"0x{prooductId}"
            && device.Capabilities.FeatureReportByteLength > 0);

        _hidDevice = device;

        return device != null;
    }

    public async Task SetColorAsync(TranzitReport report)
    {
        await ValidateAsync(report);

        WriteData(report);
    }

    private void WriteData(TranzitReport report)
    {
        byte[] buffers = new byte[_hidDevice!.Capabilities.FeatureReportByteLength];

        buffers[0] = LedConstant.ReportId;
        buffers[1] = report.Command!.CommandId;
        buffers[2] = report.Command.Address;
        buffers[report.Command.BufferId] = report.Color.ConvertColorToByte();

        if (!_hidDevice.WriteFeatureData(buffers))
        {
            throw new Exception("Device isn't connected.");
        }
    }

    private async Task ValidateAsync(TranzitReport report)
    {
        var result = await _validator.ValidateAsync(report);

        if (!result.IsValid)
        {
            throw new ValidationException(result.Errors);
        }
    }
}
