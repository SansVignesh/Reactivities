using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;

            var activities=new List<Activity>()
            {
                new Activity
                {
                    Title="Past Activity 1",
                    Date=DateTime.UtcNow.AddMonths(-2),
                    Description="Activity 2 months ago",
                    Category="drinks",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 2",
                    Date=DateTime.UtcNow.AddMonths(-1),
                    Description="Activity 1 months ago",
                    Category="culture",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 3",
                    Date=DateTime.UtcNow.AddMonths(0),
                    Description="Activity in a month",
                    Category="travel",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 4",
                    Date=DateTime.UtcNow.AddMonths(-1),
                    Description="Activity 1 months ago",
                    Category="drinks",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 5",
                    Date=DateTime.UtcNow.AddMonths(-1),
                    Description="Activity 1 months ago",
                    Category="travel",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 6",
                    Date=DateTime.UtcNow.AddMonths(-2),
                    Description="Activity 2 months ago",
                    Category="Culture",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 7",
                    Date=DateTime.UtcNow.AddMonths(-3),
                    Description="Activity 3 months ago",
                    Category="drinks",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past Activity 8",
                    Date=DateTime.UtcNow.AddMonths(-4),
                    Description="Activity 4 months ago",
                    Category="music",
                    City="London",
                    Venue="Pub"
                },
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}