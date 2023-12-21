var actionObj = Outer();

actionObj();
actionObj();

var counter1 = GetCounter();
Console.WriteLine(counter1(1));
Console.WriteLine(counter1(2));
Console.WriteLine(counter1(3));

//var counter2 = GetCounter(10);
//Console.WriteLine(counter2());
//Console.WriteLine(counter2());
//Console.WriteLine(counter2());

//Console.WriteLine(counter1());

var getCounterLambda = (int count = 0) =>
{
    var counter = (int step) =>
    {
        count += step;
        return count;
    };
    return counter;
};

var counter3 = getCounterLambda(5);

Console.WriteLine(counter3(5));
Console.WriteLine(counter3(10));
Console.WriteLine(counter3(15));

Action Outer()
{
    int a = 10;
    int b = 20;

    void Inner()
    {
        a++;
        b++;
        Console.WriteLine($"Inner result: {a + b}");
    }

    return Inner;
}


Func<int, int> GetCounter(int count = 0)
{
    int Counter(int step = 1)
    {
        count += step;
        return count;
    }

    return Counter;
}