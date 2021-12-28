namespace PlanoSaudeOnline.Api.Settings
{
    public interface IDbPlanoSaudeOnlineConnectionString
    {
        string? ConnectionString { get; set; }
        string? DatabaseName { get; set; }
    }
    public class DbPlanoSaudeOnlineConnectionString : IDbPlanoSaudeOnlineConnectionString
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
    }
}
