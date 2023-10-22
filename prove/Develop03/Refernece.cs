using System;

public class Referenece
{
	public static string getReference(int randomInt)
	{ 
		Dictionary<int, string> refDictionary = new Dictionary<int, string>
        {
            {1, "1 Nephi 1:13"},
            {2, "Alma 34:24"},
            {3, "3 Nephi 22:4"},
            {4, "Jacob 5:20"}
        };

		string randomRef = refDictionary[randomInt];
		return (randomRef);

	}
	
}