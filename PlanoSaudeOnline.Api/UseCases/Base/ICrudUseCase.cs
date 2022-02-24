using PlanoSaudeOnline.Api.Models.Base;

namespace PlanoSaudeOnline.Api.UseCases.Base
{
    public interface ICrudUseCase<TEntity>
        where TEntity : EntityBase
    {
        TEntity Incluir(TEntity entity);
        void Alterar(string id, TEntity entity);
        void Excluir(string id);
        void Excluir(TEntity entity);

        TEntity ListarPorId(string id);
        List<TEntity> Listar(int? page, int? limit);
    }
}
