# Design Pattern Samples

A comprehensive C# .NET 8.0 console application demonstrating implementations of various software design patterns. This project serves as an educational resource for developers looking to understand and learn design patterns through practical examples.

## 🌟 Features

- **Interactive Console Application**: Navigate through different pattern categories with an intuitive menu system
- **Comprehensive Pattern Coverage**: Implements 14 different design patterns across all three main categories
- **Clean Code**: Follows C# best practices with proper nullable reference handling
- **Educational Comments**: Each pattern includes explanatory comments and documentation
- **Practical Examples**: Real-world scenarios demonstrating when and how to use each pattern

## 🏗️ Design Patterns Included

### Creational Patterns
Design patterns that deal with object creation mechanisms.

- **Singleton Pattern** - Ensures a class has only one instance and provides global access to it
- **Factory Pattern** - Creates objects without specifying their exact class
- **Abstract Factory Pattern** - Provides an interface for creating families of related objects
- **Builder Pattern** - Constructs complex objects step by step
- **Prototype Pattern** - Creates objects by cloning existing instances

### Structural Patterns
Design patterns that deal with object composition and relationships.

- **Adapter Pattern** - Allows incompatible interfaces to work together
- **Composite Pattern** - Composes objects into tree structures to represent part-whole hierarchies
- **Decorator Pattern** - Adds new functionality to objects dynamically without altering their structure
- **Facade Pattern** - Provides a simplified interface to a complex subsystem
- **Flyweight Pattern** - Minimizes memory usage by sharing common data among multiple objects
- **Proxy Pattern** - Provides a placeholder or surrogate for another object to control access to it

### Behavioral Patterns
Design patterns that focus on communication between objects and the assignment of responsibilities.

- **Iterator Pattern** - Provides a way to access elements of a collection sequentially without exposing its underlying representation
- **Null Object Pattern** - Eliminates the need for null checks by providing default behavior through a null object

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A code editor or IDE (Visual Studio, Visual Studio Code, JetBrains Rider, etc.)

### Installation & Running

1. **Clone the repository**
   ```bash
   git clone https://github.com/duonghoangkha01/DesignPatternSamples.git
   cd DesignPatternSamples
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   dotnet run --project DesignPatternSamples
   ```

4. **Navigate through the interactive menu**
   - Choose from Creational, Structural, or Behavioral patterns
   - Option to run all patterns at once
   - Each pattern includes detailed explanations and output

## 📁 Project Structure

```
DesignPatternSamples/
├── DesignPatternSamples/
│   ├── Behaviour/
│   │   ├── IteratorPattern/
│   │   └── NullObjectPattern/
│   ├── Creation/
│   │   ├── AbstractFactoryPattern/
│   │   ├── BuilderPattern/
│   │   ├── FactoryPattern/
│   │   ├── PrototypePattern/
│   │   └── SingletonPattern/
│   ├── Structure/
│   │   ├── AdapterPattern/
│   │   ├── CompositePattern/
│   │   ├── DecoratorPattern/
│   │   ├── FacadePattern/
│   │   ├── FlyweightPattern/
│   │   └── ProxyPattern/
│   ├── DataAccess/
│   └── Program.cs
├── DesignPatternSamples.sln
└── README.md
```

## 🎯 Usage Examples

### Running Specific Pattern Categories

```bash
# Interactive menu will guide you through:
dotnet run

# Choose option 1 for Creational Patterns
# Choose option 2 for Structural Patterns  
# Choose option 3 for Behavioral Patterns
# Choose option 4 to see all patterns
```

### Sample Output

```
=================================================================
               DESIGN PATTERN SAMPLES DEMONSTRATION
=================================================================

--- SINGLETON PATTERN ---
Ensures a class has only one instance and provides global access to it.
Testing Singleton V1 (Thread-unsafe):
Instance called.
Constructor invoked.
Same instance: True
```

## 🔧 Code Quality Features

- **Zero Compiler Warnings**: All nullable reference warnings have been resolved
- **Clean Architecture**: Well-organized folder structure separating different pattern types
- **Comprehensive Testing**: Each pattern includes test classes demonstrating usage
- **Documentation**: XML documentation comments on key classes and methods
- **Best Practices**: Follows C# coding conventions and design principles

## 📚 Learning Resources

Each pattern implementation includes:
- Clear comments explaining the pattern's purpose
- Real-world usage scenarios
- Benefits and drawbacks
- Implementation details and considerations

## 🤝 Contributing

This project is designed for educational purposes. If you'd like to contribute:

1. Fork the repository
2. Create a feature branch
3. Add your design pattern implementation
4. Include comprehensive tests and documentation
5. Submit a pull request

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 🎓 Educational Value

This repository is perfect for:
- **Students** learning design patterns
- **Developers** preparing for technical interviews
- **Architects** reviewing pattern implementations
- **Teams** establishing coding standards and best practices

---

*Happy coding and pattern learning! 🎉*