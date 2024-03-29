﻿using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain._Shared.Contracts.Handlers.Requests;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Repositories.MongoDB;

public interface IRepositoryBase<TEntity>
    where TEntity : Entity
{
    TEntity Buscar(string id);
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(IQueryRequest<TEntity> query);
    Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> query);
    TEntity Inserir(TEntity entity);
    void Inserir(IEnumerable<TEntity> entities);
    void Alterar(string id, TEntity entity);
    void Remover(TEntity entity);
    void Remover(string id);
}
