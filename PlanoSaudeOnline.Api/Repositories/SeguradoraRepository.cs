using MongoDB.Driver;
using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories
{
    public class SeguradoraRepository : ISeguradoraRepository
    {
        private readonly IMongoCollection<Seguradora> _seguradoras;

        public SeguradoraRepository(IDbPlanoSaudeOnlineConnectionString settings)
        {
            var mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(settings.ConnectionString));
            mongoClientSettings.SslSettings.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;

            var client = new MongoClient(mongoClientSettings);
            var database = client.GetDatabase(settings.DatabaseName);

            _seguradoras = database.GetCollection<Seguradora>("Seguradoras");
        }

        public List<Seguradora> Get() =>
            _seguradoras.Find(seguradora => true).ToList();

        public Seguradora Get(string id) =>
            _seguradoras.Find(s => s.Id == id).FirstOrDefault();

        public Seguradora Create(Seguradora seguradora)
        {
            _seguradoras.InsertOne(seguradora);
            return seguradora;
        }

        public void Update(string id, Seguradora seguradoraIn) =>
            _seguradoras.ReplaceOne(seguradora => seguradora.Id == id, seguradoraIn);

        public void Remove(Seguradora seguradoraIn) =>
            _seguradoras.DeleteOne(seguradora => seguradora.Id == seguradoraIn.Id);

        public void Remove(string id) =>
            _seguradoras.DeleteOne(seguradora => seguradora.Id == id);
    }
}
