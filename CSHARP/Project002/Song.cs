using System;

namespace Project002
{
    class classSong
    {
            public string title;
            public string artist;
            public int duration;
            public static int songCount = 0;
            public classSong(string aTitle, string aArtist, int aDuration)
            {
                title = aTitle;
                artist = aArtist;
                duration = aDuration;
                songCount++;
            }
        }
    }
