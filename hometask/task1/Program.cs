
using U;

        Cache<int>.Add(10);
        Cache<int>.Add(11);
        Cache<string>.Add("Ronaldo");
        Cache<string>.Add("Messi");

        var s2 = Cache<string>.Get();

        foreach (var item in s2)
        {
            Console.WriteLine(item);
        }

        Cache<int>.Remove(10);

        var s = Cache<int>.Get();

        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
