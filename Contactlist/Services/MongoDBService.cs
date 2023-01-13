using ContactList.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ContactList.Services;

public class MongoDBService{

    private readonly IMongoCollection<Contacts> _contactsCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings){
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _contactsCollection = database.GetCollection<Contacts>(mongoDBSettings.Value.CollectionName);
    }

    public async Task CreateAsync(Contacts contacts){
        await _contactsCollection.InsertOneAsync(contacts);
        return;
    }

     public async Task<List<Contacts>> GetAsync(){
        return await _contactsCollection.Find(new BsonDocument()).ToListAsync();
    }

     public async Task AddToContactsListAsync(string id,string contactId){
        FilterDefinition<Contacts> filter = Builders<Contacts>.Filter.Eq("Id", id);
    //UpdateDefinition<Contacts> update=Builders<Contacts>.Update.AddToSet<string>("contactId", contactId);
       // await _contactsCollection.UpdateOneAsync(filter);
        return;
    }

    public async Task DeleteAsync(string id){
        FilterDefinition<Contacts> filter = Builders<Contacts>.Filter.Eq("Id", id);
        await _contactsCollection.DeleteOneAsync(filter);
        return;
    }
}