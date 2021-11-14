// Custom default for OrDefault
var numbers = new int[] { 1, 2, 3, 4 };
var number = numbers.FirstOrDefault(x => x == 5, -1);
Console.WriteLine(number); // Output: -1

// MaxBy and MinBy
var person1 = new Person("Ben", 23);
var person2 = new Person("Martina", 55);
var person3 = new Person("Andrea", 13);
var people = new Person[] { person1, person2, person3 };

var youngest = people.MinBy(x => x.Age);
var oldest = people.MaxBy(x => x.Age);

// Chunk
foreach (Person[] chunk in people.Chunk(2))
{
    // First chunk: Ben and Martina
    // Second chunk: Andrea
}

public record Person(string Name, int Age);
