using Microsoft.AspNetCore.Routing.Constraints;

namespace Modul10_103022400081
{
    public class Game
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string Developer { get; set; }
        public int TahunRilis { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string[] Platform { get; set; }
        public string[] Mode { get; set; }
        public Boolean IsOnline { get; set; }
        public int Harga { get; set; }

        public Game()
        {

        }
    }
}
