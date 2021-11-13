// Custom default for OrDefault
var numbers = new int[] { 1, 2, 3, 4 };
var number = numbers.FirstOrDefault(x => x == 5, -1);
Console.WriteLine(number); // Output: -1

// MaxBy and MinBy
var person1 = new Person { Name = "Foo", Age = 23};
var person2 = new Person { Name = "Bar", Age = 55};
var people = new Person[] { person1, person2 };

var youngest = people.MinBy(x => x.Age);
var oldest = people.MaxBy(x => x.Age);

public class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}