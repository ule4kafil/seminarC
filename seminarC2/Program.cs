int Max(int arg1,int arg2,int arg3) 
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    { 
        result = arg3; 
    }
    return result;
    
}



int arg1213 = 44;
int arg23332 = 5;
int arg23434 = 78;

int result2 = Max(arg23332, arg1213, arg23434);

Console.WriteLine(result2);
