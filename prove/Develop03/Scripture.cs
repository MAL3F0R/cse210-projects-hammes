using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public static class Scripture
{
    public static string generateScripture(int inputint)
    {
        Dictionary<int, string> scriptureDictionary = new Dictionary<int, string>
        {
            {1, @"And he read, saying: Wo, wo, unto Jerusalem, for I have seen
thine abominations!  Yea, and many things did my father read
concerning Jerusalem--that it should be destroyed, and the
inhabitants thereof; many should perish by the sword, and many
should be carried away captive into Babylon."},
            {2, @"Cry unto him over the crops of your fields, that ye may
prosper in them."},
            {3, @"Fear not, for thou shalt not be ashamed; neither be thou
confounded, for thou shalt not be put to shame; for thou shalt
forget the shame of thy youth, and shalt not remember the
reproach of thy youth, and shalt not remember the reproach of thy
widowhood any more."},
            {4, @"And it came to pass that they went forth whither the master
had hid the natural branches of the tree, and he said unto the
servant: Behold these; and he beheld the first that it had
brought forth much fruit; and he beheld also that it was good. 
And he said unto the servant: Take of the fruit thereof, and lay
it up against the season, that I may preserve it unto mine own
self; for behold, said he, this long time have I nourished it,
and it hath brought forth much fruit."}
        };
        string randomScripture = scriptureDictionary[inputint];
        return (randomScripture);
    }
}