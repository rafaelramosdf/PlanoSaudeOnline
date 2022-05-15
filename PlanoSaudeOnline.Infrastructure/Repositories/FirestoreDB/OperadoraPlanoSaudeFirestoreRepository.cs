using Google.Cloud.Firestore;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.FirestoreDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.FirestoreDB;

public class OperadoraPlanoSaudeFirestoreRepository : FirestoreRepositoryBase<OperadoraPlanoSaudeFirestoreEntity>, IOperadoraPlanoSaudeFirestoreRepository
{
    public OperadoraPlanoSaudeFirestoreRepository(FirestoreDb firestoreDb)
        : base(firestoreDb)
    {
    }
}
