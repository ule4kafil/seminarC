bool Word(int arg1) 
{
    if (arg1 % 2 == 0)
    {
        return true;
    }

    return false;
}



int arg = 43;


bool result = Word(arg);

Console.WriteLine(result);
