static int HammingDistance(string word, string wordToCheck)
{
	if (word.Length != wordToCheck.Length)
	{
		throw new ArgumentException();
	}
	int count = 0;
	for (int i = 0; i < word.Length; i++)
	{
		if (word[i] != wordToCheck[i])
		{
			count++;
		}
	}
	return count;
}
HammingDistance("Foo", "Bar");
HammingDistance("Hello", "Hallo");
//HammingDistance("Hallo", "Welt");