using Microsoft.Extensions.Options;
using MongoDB.Driver;
using UserManagementAPI.Model;

namespace UserManagementAPI.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbSettings.Value.Database);
            _users = database.GetCollection<User>("Users");

            // Create compound index for GDPR compliance (e.g., unique email)
            var indexKeys = Builders<User>.IndexKeys.Ascending(user => user.Email);
            _users.Indexes.CreateOne(new CreateIndexModel<User>(indexKeys));
        }

        public List<User> GetAll() => _users.Find(user => true).ToList();

        public User Get(Guid id) => _users.Find(user => user.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            user.CreatedAt = DateTime.UtcNow;
            _users.InsertOne(user);
            return user;
        }
    }
}
