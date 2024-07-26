using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayear.Commen
{
    public class ReadEntitybase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string  id { get; set; }

        public long productid { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreateDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
