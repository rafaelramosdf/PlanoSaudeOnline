namespace PlanoSaudeOnline.Domain.Handlers
{
    public abstract class QueryBase
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }
}
