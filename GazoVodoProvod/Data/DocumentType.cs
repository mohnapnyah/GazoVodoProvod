using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using static GazoVodoProvod.Data.User;

namespace GazoVodoProvod.Data;

public class DocumentType
{
    [BsonId]
    [BsonIgnoreIfDefault]
    ObjectId id;
    public string Title { get; set; }
    public Industries Industry { get; set; }
    
    public Roles Role { get; set; }    

    public DocumentType(string title, Industries industry, Roles role)
    {
        Title = title;
        Industry = industry;
        Role = role;
    }
}
