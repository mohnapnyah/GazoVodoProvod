using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GazoVodoProvod.Data;

public class Project
{
    [BsonId]
    [BsonIgnoreIfDefault]
    ObjectId id;
    public string Name { get; set; }
    public Customer Customer { get; set; }
    public Designer Designer { get; set; }
    public Builder Builder { get; set; }
    public List<Document> Documents { get; set; }

    public Project(Builder builder, string name)
    {
        Builder = builder;
        Name = name;
        //create List<Document>
        Documents = new List<Document>();
        //var DocTypes = DocumentDB.FindDocumentTypesForProject(Builder.Industries);
        //foreach (var docType in DocTypes)
        //{
        //    Documents.Add(new Document(docType));
        //}
    }
}
