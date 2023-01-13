using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ContactList.Models;


public class Contacts{
    
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id {get;set;}
    
    public string Name {get;set;} = null!;
    public string Email {get;set;} = null!;
    public string Phone {get;set;} = null!;
    public string Company {get;set;} = null!;
    public string Notes {get;set;} = null!;

    
}