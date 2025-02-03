static bool StartsWith(string s1, string s2)
{
    if(s2 == "")
	{
		return true;
	}
	for (int i = 0; i < s2.Length; i++)
	{
		if (s1[i] != s2[i])
		{
			return false;
		}
	}
	return true;
}
static bool Contains(string s1, string s2)
{
    if (s2 == "")
    {
        return true;
    }
	if (s2.Length > s1.Length)
	{
		return false;
	}
    for (int i = 0; i <= s1.Length - s2.Length; i++)
    {
        bool found = true;

        for (int j = 0; j < s2.Length; j++)
        {
            if (s1[i + j] != s2[j])
            {
                found = false;
                break;
            }
        }
        if (found)
        {
            return true; 
        }
    }
    return false; 
}

Console.WriteLine(Contains("Grünes Gras", "Gras"));