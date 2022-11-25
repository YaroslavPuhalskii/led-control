using FluentValidation;
using LED_Control.MVVM.Models;

namespace LED_Control.Validators;

internal class ReportValidator : AbstractValidator<TranzitReport>
{
    public ReportValidator()
    {
        RuleFor(report => report.VendorId)
            .NotNull().WithMessage("Enter the Vendor ID.")
            .NotEmpty().WithMessage("Enter the Vendor ID.");

        RuleFor(report => report.ProductId)
            .NotNull().WithMessage("Enter the Product ID.")
            .NotEmpty().WithMessage("Enter the Product ID.");

        RuleFor(report => report.Color)
            .NotNull().WithMessage("Enter a color.");

        RuleFor(report => report.Command)
            .NotNull().WithMessage("Select commands.");
    }
}
