static string RemoveBlanks(string input)
{
    string result = "";  
    bool lastWasSpace = false;

    foreach (char c in input)
    {
        if (c == ' ')
        {

            if (!lastWasSpace)
            {
                result += c; 
                lastWasSpace = true;
            }
        }
        else
        {
            result += c;
            lastWasSpace = false;
        }
    }

    return result;
}

Console.WriteLine(RemoveBlanks("asdasd sadas das    a sda s    as da sd as d"));