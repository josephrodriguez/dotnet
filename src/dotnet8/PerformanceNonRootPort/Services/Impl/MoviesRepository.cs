using PerformanceNonRootPort.Models;

namespace PerformanceNonRootPort.Services.Impl;

internal class MoviesRepository : IMoviesRepository
{
    public async Task<IEnumerable<Movie>> GetMoviesAsync()
    {
        var movies = new Movie[]
        {
            new()
            {
                Rank = 1,
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Rating = 9.3,
                Genre = "Drama",
                ReleaseYear = 1994,
                Cast = "Tim Robbins, Morgan Freeman",
                Synopsis =
                    "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new()
            {
                Rank = 2,
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Rating = 9.2,
                Genre = "Crime, Drama",
                ReleaseYear = 1972,
                Cast = "Marlon Brando, Al Pacino",
                Synopsis =
                    "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new()
            {
                Rank = 3,
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Rating = 9.0,
                Genre = "Action, Crime, Drama",
                ReleaseYear = 2008,
                Cast = "Christian Bale, Heath Ledger",
                Synopsis =
                    "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham."
            },
            new()
            {
                Rank = 4,
                Title = "The Godfather: Part II",
                Director = "Francis Ford Coppola",
                Rating = 9.0,
                Genre = "Crime, Drama",
                ReleaseYear = 1974,
                Cast = "Al Pacino, Robert De Niro",
                Synopsis =
                    "The early life and career of Vito Corleone is depicted, as well as his son Michael’s attempt to expand the family business."
            },
            new()
            {
                Rank = 5,
                Title = "The Lord of the Rings: The Return of the King",
                Director = "Peter Jackson",
                Rating = 8.9,
                Genre = "Action, Adventure, Drama",
                ReleaseYear = 2003,
                Cast = "Elijah Wood, Viggo Mortensen",
                Synopsis =
                    "Gandalf and Aragorn lead the World of Men against Sauron to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."
            },
            new()
            {
                Rank = 6,
                Title = "Pulp Fiction",
                Director = "Quentin Tarantino",
                Rating = 8.9,
                Genre = "Crime, Drama",
                ReleaseYear = 1994,
                Cast = "John Travolta, Uma Thurman, Samuel L. Jackson",
                Synopsis = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
            },
            new()
            {
                Rank = 7,
                Title = "Schindler's List",
                Director = "Steven Spielberg",
                Rating = 8.9,
                Genre = "Biography, Drama, History",
                ReleaseYear = 1993,
                Cast = "Liam Neeson, Ben Kingsley, Ralph Fiennes",
                Synopsis = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."
            },
            new()
            {
                Rank = 8,
                Title = "12 Angry Men",
                Director = "Sidney Lumet",
                Rating = 8.9,
                Genre = "Drama",
                ReleaseYear = 1957,
                Cast = "Henry Fonda, Lee J. Cobb, Martin Balsam",
                Synopsis = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence."
            },
            new()
            {
                Rank = 9,
                Title = "The Good, the Bad and the Ugly",
                Director = "Sergio Leone",
                Rating = 8.8,
                Genre = "Adventure, Western",
                ReleaseYear = 1966,
                Cast = "Clint Eastwood, Eli Wallach, Lee Van Cleef",
                Synopsis = "A bounty hunting scam joins two unlikely allies in an epic duel with a third opponent in a quest for gold buried in a cemetery."
            },
            new()
            {
                Rank = 10,
                Title = "The Fight Club",
                Director = "David Fincher",
                Rating = 8.8,
                Genre = "Drama",
                ReleaseYear = 1999,
                Cast = "Brad Pitt, Edward Norton, Helena Bonham Carter",
                Synopsis = "An insomniac office worker, looking for a way to change his life, crosses paths with a soap salesman, creating an underground fight club."
            },
            new()
            {
                Rank = 11,
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                Rating = 8.8,
                Genre = "Drama, Romance",
                ReleaseYear = 1994,
                Cast = "Tom Hanks, Robin Wright",
                Synopsis = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an extraordinary life story."
            },
            new()
            {
                Rank = 12,
                Title = "Inception",
                Director = "Christopher Nolan",
                Rating = 8.8,
                Genre = "Action, Adventure, Sci-Fi",
                ReleaseYear = 2010,
                Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page",
                Synopsis = "A thief who enters the dreams of others to steal secrets from their subconscious is given the task of planting an idea into the mind of a CEO."
            },
            new()
            {
                Rank = 13,
                Title = "The Matrix",
                Director = "Lana Wachowski, Lilly Wachowski",
                Rating = 8.7,
                Genre = "Action, Sci-Fi",
                ReleaseYear = 1999,
                Cast = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                Synopsis = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers."
            },
            new()
            {
                Rank = 14,
                Title = "Goodfellas",
                Director = "Martin Scorsese",
                Rating = 8.7,
                Genre = "Crime, Drama",
                ReleaseYear = 1990,
                Cast = "Robert De Niro, Ray Liotta, Joe Pesci",
                Synopsis = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen and his mob partners, Jimmy Conway and Tommy DeVito."
            },
            new()
            {
                Rank = 15,
                Title = "The Silence of the Lambs",
                Director = "Jonathan Demme",
                Rating = 8.6,
                Genre = "Crime, Drama, Thriller",
                ReleaseYear = 1991,
                Cast = "Jodie Foster, Anthony Hopkins",
                Synopsis = "A young F.B.I. cadet must confide in an incarcerated and manipulative killer to receive his help on catching another serial killer who skins his victims."
            },
            new()
            {
                Rank = 16,
                Title = "City of God",
                Director = "Fernando Meirelles, Kátia Lund",
                Rating = 8.6,
                Genre = "Crime, Drama",
                ReleaseYear = 2002,
                Cast = "Alexandre Rodrigues, Leandro Firmino, Phellipe Haagensen",
                Synopsis = "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin."
            },
            new()
            {
                Rank = 17,
                Title = "Life Is Beautiful",
                Director = "Roberto Benigni",
                Rating = 8.6,
                Genre = "Comedy, Drama, Romance",
                ReleaseYear = 1997,
                Cast = "Roberto Benigni, Nicoletta Braschi",
                Synopsis = "A Jewish man uses his imagination to protect his son in a Nazi concentration camp."
            },
            new()
            {
                Rank = 18,
                Title = "Se7en",
                Director = "David Fincher",
                Rating = 8.6,
                Genre = "Crime, Drama, Mystery",
                ReleaseYear = 1995,
                Cast = "Brad Pitt, Morgan Freeman, Kevin Spacey",
                Synopsis = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his modus operandi."
            },
            new()
            {
                Rank = 19,
                Title = "The Usual Suspects",
                Director = "Bryan Singer",
                Rating = 8.5,
                Genre = "Crime, Drama, Mystery",
                ReleaseYear = 1995,
                Cast = "Kevin Spacey, Gabriel Byrne, Chazz Palminteri",
                Synopsis = "A sole survivor tells the twisted events leading up to a horrific gun battle on a ship, which began when five criminals met at a seemingly random police lineup."
            },
            new()
            {
                Rank = 20,
                Title = "The Lion King",
                Director = "Roger Allers, Rob Minkoff",
                Rating = 8.5,
                Genre = "Animation, Adventure, Drama",
                ReleaseYear = 1994,
                Cast = "Matthew Broderick, Jeremy Irons, James Earl Jones",
                Synopsis = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to seize the throne from Simba's father."
            },
        };
        
        return movies;
    }
}