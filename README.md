# Matrix Generator 🧮

A simple yet effective C# console application that generates a multi-dimensional matrix, dynamically sizes it based on user input, and populates it with random numbers.

## 📖 What is the Matrix Generator?

The **Matrix Generator** is an application that helps developers visualize and understand N-dimensional arrays in C#. It uses recursive functions to handle arrays with an arbitrary number of dimensions.

The application works as follows:
1. Prompts the user to enter the number of dimensions for the matrix.
2. Prompts the user to enter the size for each individual dimension.
3. Dynamically creates the N-dimensional array using `Array.CreateInstance`.
4. Recursively fills every element of the multidimensional array with a random number between 1 and 100.
5. Recursively prints out the index combination and the assigned random value for every element in the matrix.

## 🎯 Project Purpose

The main objective of this project is to demonstrate how to dynamically instantiate, populate, and traverse multi-dimensional arrays (N-dimensional arrays) in C# using recursion, rather than relying on nested loops that only work for a fixed number of dimensions.

## 🚀 How to Run

Follow these steps to run the application on your local machine:

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) must be installed on your system.

### Steps
1. **Clone the repository** (or download the source code):
   ```bash
   git clone <repository-url>
   ```
2. **Navigate to the project directory**:
   ```bash
   cd MatrisGenerator
   ```
3. **Run the application**:
   ```bash
   dotnet run
   ```
4. **Usage**: The console will prompt you to enter the number of dimensions and the sizes for each. Type the required values and press "Enter" to see the generated matrix.

## 📄 License

This project is licensed under the [MIT License](LICENSE). See the `LICENSE` file for details.
