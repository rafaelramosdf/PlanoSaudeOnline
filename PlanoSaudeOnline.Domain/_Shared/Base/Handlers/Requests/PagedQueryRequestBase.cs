namespace PlanoSaudeOnline.Domain._Shared.Base.Handlers.Requests
{
    public abstract class PagedQueryRequestBase
    {
        public string? Search { get; set; } = string.Empty;
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }
}
