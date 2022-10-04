List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
Func<int, bool> oddcheck = x=> x % 2 != 0;
var oddnumbers = numbers.Where(oddcheck).ToList();


Action<int> printOdd = x =>
{
    var square = x * x;
    var cube = x * x * x;
    Console.WriteLine($"{x} : {square}, : {cube}");
};

oddnumbers.ForEach(printOdd);
