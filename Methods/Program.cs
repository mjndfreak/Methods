static void printLyrics()
{
    Console.WriteLine(@"
I am just a copy of a copy of a copy
Everything I say has come before
Assembled into something, into something, into something
I don't know for certain anymore
I am just a shadow of a shadow of a shadow
Always tryin' to catch up with myself
I am just an echo of an echo of an echo
Listening to someone's cry for help
Look what you have just done
Why all the change of heart?
You need to play your part
A copy of a copy of a...
Now look what you've gone and done
Well, that doesn't sound like fun
See, I'm not the only one
A copy of a copy of a...

");
}

printLyrics();

static int randomMod()
{
    Random random = new Random() ;
    int rnd = random.Next() ;
    Console.WriteLine(rnd % 2);
    return rnd % 2;
}

randomMod();

static int multiply(int a, int b)
{ 
    int mul = a * b;
    Console.WriteLine(mul);
    return mul; 
}
multiply(3,5);


static void greet(string name, string surname)
{
    Console.WriteLine("Hoşgeldiniz " + name + " " + surname);
}

greet("cagdas" , "ergenc");




