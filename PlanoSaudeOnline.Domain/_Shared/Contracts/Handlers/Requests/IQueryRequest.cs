using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Handlers.Requests;

public interface IQueryRequest<TEntity> where TEntity : Entity
{
    string? Search { get; set; }
    int Page { get; set; }
    int Limit { get; set; }
    Expression<Func<TEntity, bool>> Query();
}
