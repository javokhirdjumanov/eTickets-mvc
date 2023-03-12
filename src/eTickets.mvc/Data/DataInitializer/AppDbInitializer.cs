using eTickets.mvc.Models;

namespace eTickets.mvc.Data;
public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            //Cinema
            if (!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                });
                context.SaveChanges();
            }
            //Actors
            if (!context.Actors.Any())
            {
                context.Actors.AddRange(new List<Actor>()
                {
                    new Actor()
                    {
                        FullName = "Actor 1",
                        Biography = "This is the Bio of the first actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 2",
                        Biography = "This is the Bio of the second actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                    }
                });
                context.SaveChanges();
            }
            //Producers
            if (!context.Producers.Any())
            {
                context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Biography = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Biography = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        }
                    });
                context.SaveChanges();
            }
            //Movies
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                context.SaveChanges();
            }
            //Actors & Movies
            if (!context.Actor_Movies.Any())
            {
                context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        }
                    });
                context.SaveChanges();
            }
        }
    }
}
