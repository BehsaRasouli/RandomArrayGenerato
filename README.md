# RandomArrayGenerato
RandomArrayGenerator

A simple C# console application that creates an array with a user-defined size and fills it with random integers between 1 and 100.
The program then prints the array in a formatted layout.

🚀 Features

Generates an integer array of any size

Fills the array with random values (1–100)

Uses Random class for number generation

Prints results in a clean, readable format

Beginner-friendly example

📌 Code Example
```csharp
Random rnd = new Random();

int[] array = new int[tedad];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 101);
}
```
▶️ How It Works

The user enters the number of elements.

The program creates an array with that size.

Each element is filled using rnd.Next(1, 101).

Output is printed, with a new line after every 10 values.

📁 Project Structure
```csharp
RandomArrayGenerator/
 ├── Program.cs
 └── README.md
```
▶️ How to Run
Clone the repository:
```csharp
git clone https://github.com/BehsaRasouli/RandomArrayGenerator.git
```
Build and run:
```csharp
dotnet run
```

Or open the project using Visual Studio or Rider.

📝 License

This project is licensed under the MIT License.
