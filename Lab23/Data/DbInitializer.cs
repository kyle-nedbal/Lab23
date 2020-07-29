using System;
using Lab23.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Lab23.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MoviesContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie() { Title = "Superman", Genre = Genre.Action, Runtime = 3.13 });
                context.Movies.Add(new Movie() { Title = "Superbad", Genre = Genre.Comedy, Runtime = 1.98 });
                context.Movies.Add(new Movie() { Title = "Spiderman", Genre = Genre.Action, Runtime = 2.02 });
                context.Movies.Add(new Movie() { Title = "Bad Cop", Genre = Genre.Comedy, Runtime = 1.55 });
                context.Movies.Add(new Movie() { Title = "Idiocracy", Genre = Genre.Comedy, Runtime = 1.40 });
                context.Movies.Add(new Movie() { Title = "It", Genre = Genre.Horror, Runtime = 1.25 });
                context.Movies.Add(new Movie() { Title = "Shawshank Redemption", Genre = Genre.Horror, Runtime = 2.37 });
                context.Movies.Add(new Movie() { Title = "1917", Genre = Genre.Drama, Runtime = 1.98 });
                context.Movies.Add(new Movie() { Title = "Joker", Genre = Genre.Drama, Runtime = 2.03 });
                context.Movies.Add(new Movie() { Title = "Midway", Genre = Genre.Action, Runtime = 2.30 });
                context.Movies.Add(new Movie() { Title = "Rambo", Genre = Genre.Action, Runtime = 1.65 });
                context.Movies.Add(new Movie() { Title = "Parasite", Genre = Genre.Drama, Runtime = 2.20 });
                context.SaveChanges();
            }

        }
    }
}
