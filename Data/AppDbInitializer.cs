using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
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
                            Logo ="",
                            Description ="This is the description of Cinema 1"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo ="",
                            Description ="This is the description of Cinema 2"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo ="",
                            Description ="This is the description of Cinema 3"
                        },
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
                            Bio ="",
                            ProfilePictureUrl =""
                        },new Actor()
                        {
                            FullName = "Actor 2",
                            Bio ="",
                            ProfilePictureUrl =""
                        },new Actor()
                        {
                            FullName = "Actor 3",
                            Bio ="",
                            ProfilePictureUrl =""
                        },new Actor()
                        {
                            FullName = "Actor 4",
                            Bio ="",
                            ProfilePictureUrl =""
                        },

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
                            Bio ="",
                            ProfilePictureUrl =""
                        },new Producer()
                        {
                            FullName = "Producer 2",
                            Bio ="",
                            ProfilePictureUrl =""
                        },new Producer()
                        {
                            FullName = "Producer 3",
                            Bio ="",
                            ProfilePictureUrl =""
                        },new Producer()
                        {
                            FullName = "Producer 4",
                            Bio ="",
                            ProfilePictureUrl =""
                        },

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
                            Name = "Movie 1",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 2",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 3",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 4",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 5",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 6",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 7",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },new Movie()
                        {
                            Name = "Movie 8",
                            Description="",
                            Price ="",
                            ImageUrl="",
                            StartDate="",
                            EndDate="",
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = MovieCategory.Acton
                        },

                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        }, new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
