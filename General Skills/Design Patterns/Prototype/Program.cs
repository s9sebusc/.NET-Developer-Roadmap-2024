using Prototype;

Sheep sheep_original = new Sheep() { Age = 10, Name = "My Sheep" };

// The clone class has all values of the original class. Also the private values.
Sheep sheep_clone = (Sheep)sheep_original.Clone(); 

Console.WriteLine("Original name: " + sheep_original.Name); // My Sheep
Console.WriteLine("Original age: " + sheep_original.Age); // 10

Console.WriteLine("Clone name: " + sheep_clone.Name); // My Sheep
Console.WriteLine("Clone age: " + sheep_clone.Age); // 10

sheep_clone.Name = "Dolly";
sheep_clone.Age = 1;

Console.WriteLine("Original name: " + sheep_original.Name); // My Sheep
Console.WriteLine("Original age: " + sheep_original.Age); // 10

// The copy of the sheep is a deep copy!
Console.WriteLine("Clone name: " + sheep_clone.Name); // Dolly
Console.WriteLine("Clone age: " + sheep_clone.Age); // 1

Console.ReadKey();
