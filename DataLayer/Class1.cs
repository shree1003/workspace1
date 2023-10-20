using Entity;
namespace DataLayer;
public class DataAccess
{

    public static List<Movie> movies = new List<Movie>() {
        new Movie{ID=1,Name="Toofan",Ryear=2021, Ratings=3},
        new Movie{ID=2,Name="Ludo",Ryear=2020, Ratings=4},
        new Movie{ID=3,Name="GUnjan",Ryear=2020, Ratings=1},
        new Movie{ID=4,Name="Big Bull",Ryear=2021, Ratings=3},
        new Movie{ID=5,Name="Laxmi",Ryear=2020, Ratings=2},
    };

    public List<Movie> GetMovies(){
        return movies;
    }

}
