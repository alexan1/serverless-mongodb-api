using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoMusic.API.Helpers
{
    public class Settings
    {
        private const string connectionString = Environment.GetEnvironmentVariable("MongoDBAtlasConnectionString");
        public const string MONGO_CONNECTION_STRING = connectionString; //"MongoDBAtlasConnectionString";
        public const string DATABASE_NAME = "Album";
        public const string COLLECTION_NAME = "Album";
    }
}
