using Microsoft.EntityFrameworkCore;

namespace BlogODataApi.Data;

public static class SeedData
{
    public static void InsertTestData(AppDbContext db)
    {
        db.Database.ExecuteSqlRaw("INSERT INTO \"Authors\" (\"Name\") VALUES ({0})", "John Doe");
        db.Database.ExecuteSqlRaw(
            "INSERT INTO \"Posts\" (\"Title\", \"Content\", \"CreatedAt\", \"AuthorId\") VALUES ({0}, {1}, {2}, {3})",
            "Hello World", "This is my first post", DateTime.UtcNow, 1
        );
    }
}