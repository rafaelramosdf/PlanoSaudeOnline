using Google.Cloud.Firestore;

namespace PlanoSaudeOnline.Domain._Shared.Base.Entities;

[FirestoreData]
public abstract class FirestoreEntity
{
    [FirestoreProperty]
    public string Id { get; set; } = Guid.NewGuid().ToString("N");

    [FirestoreDocumentCreateTimestamp]
    public DateTime CadastradoEm { get; set; }

    [FirestoreDocumentUpdateTimestamp]
    public DateTime? AlteradoEm { get; set; }

    [FirestoreDocumentReadTimestamp]
    public DateTime? ConsultadoEm { get; set; }
}
