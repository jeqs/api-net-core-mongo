using Mongo.Core.Entities;
using Mongo.Infrastructure.AppConfig;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mongo.Infrastructure.Services
{
    public class ARSService
    {
        private readonly IMongoCollection<ARS> _arsCollection;

        public ARSService(IOptions<DatabaseSetting> databaseSetting)
        {
            var client = new MongoClient(databaseSetting.Value.ConnectionString);
            var database = client.GetDatabase(databaseSetting.Value.DatabaseName);

            _arsCollection = database.GetCollection<ARS>("ARS");
        }

        public async Task<List<ARS>> GetAsync() => await _arsCollection.Find(_ => true).ToListAsync();

        public async Task<ARS?> GetAsync(string id) => await _arsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(ARS newARS) => await _arsCollection.InsertOneAsync(newARS);

        public async Task UpdateAsync(string id, ARS updatedARS) => await _arsCollection.ReplaceOneAsync(x => x.Id == id, updatedARS);

        public async Task RemoveAsync(string id) => await _arsCollection.DeleteOneAsync(x => x.Id == id);

    }
}
