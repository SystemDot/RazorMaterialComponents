namespace SystemDot.Web.Razor.MaterialComponents.Examples.Messages.Charts
{
    using SystemDot.Web.Razor.MaterialComponents.Examples.Abstractions;
    using MediatR;

    public record GetChartsViewDataRequest : IRequest<GetChartsViewDataResponse>
    {
        public Month From { get; init; }
        public Month To { get; init; }
    }
}
