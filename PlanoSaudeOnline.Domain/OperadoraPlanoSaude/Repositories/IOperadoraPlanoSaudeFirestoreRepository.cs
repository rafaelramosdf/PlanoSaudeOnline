using PlanoSaudeOnline.Domain._Shared.Contracts.Repositories.FirestoreDB;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

public interface IOperadoraPlanoSaudeFirestoreRepository : IFirestoreRepositoryBase<OperadoraPlanoSaudeFirestoreEntity>
{
}
