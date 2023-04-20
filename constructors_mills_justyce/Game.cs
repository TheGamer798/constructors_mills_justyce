using System;
using System.Collections.Generic;
using System.Text;

namespace constructors_mills_justyce
{
    class Game
    {
        public string title, genre;//creates pbluc string fields for title and genre

        public Game(string titlePm = "unknown title", string genrePm = "casual")
        {
            genre = genrePm;
            title = titlePm;
        }
        /*
         class constructor for the game class that takes 2 string parameters
         gives genre the default value of casual
         gives title the default value of unknown title
         */
    }
}
