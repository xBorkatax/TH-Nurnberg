static bool IsValidEmail(string email)
{
    bool contains = false;
    foreach (char a in email)
    {
        if (!char.IsLetter(a) && !char.IsDigit(a) && a != '@' && a != '.')
        {
            break;
        }
        if (a == '@')
        {
            if (contains)
            {
                break;
            }
            contains = true;
        }
        if (contains)
        {
            if (a == '.')
            {
                return true;
            }
        }
    }
    return false;
}