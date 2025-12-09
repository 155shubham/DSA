using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Random_Questions;

/*
 * 1.Given someone's favorite songs (as a map) and a genre category (as a map as well).
 * Find out this person's most favorite genre. For example,

John": ["song1", "song2", "song3", "song4", "song8"],
"Jyotsna": ["song5", "song6", "song7"]
 
and
 
"Rock": ["song1", "song3"],
"Dubstep": ["song7"],
"Techno": ["song2", "song4"],
"Pop": ["song5", "song6"],
"Jazz": ["song8", "song9"]

output 
John : Rock, Techno,Jazz
Jyotsna : Pop, Dubste
 */

public class Find_Favourite_Songs
{
    Dictionary<string , List<string>> keyValuePairs = new Dictionary<string , List<string>>();
}
