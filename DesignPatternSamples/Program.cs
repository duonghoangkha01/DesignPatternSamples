using DesignPatternSamples.Behaviour.IteratorPattern;
using DesignPatternSamples.Behaviour.NullObjectPattern;
using DesignPatternSamples.Creation.AbstractFactoryPattern;
using DesignPatternSamples.Creation.BuilderPattern;
using DesignPatternSamples.Creation.FactoryPattern;
using DesignPatternSamples.Creation.PrototypePattern;
using DesignPatternSamples.Creation.SingletonPattern;
using DesignPatternSamples.Structure.AdapterPattern;
using DesignPatternSamples.Structure.CompositePattern;
using DesignPatternSamples.Structure.DecoratorPattern;
using DesignPatternSamples.Structure.FacadePattern;
using DesignPatternSamples.Structure.FlyweightPattern;
using DesignPatternSamples.Structure.ProxyPattern;

namespace DesignPatternSamples
{
    /// <summary>
    /// Design Pattern Samples Demonstration
    /// This console application showcases implementations of various design patterns
    /// organized into three main categories: Creational, Structural, and Behavioral patterns.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("               DESIGN PATTERN SAMPLES DEMONSTRATION");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            
            while (true)
            {
                DisplayMenu();
                var choice = Console.ReadLine();
                
                Console.Clear();
                
                switch (choice?.ToLower())
                {
                    case "1":
                        DemonstrateCreationalPatterns();
                        break;
                    case "2":
                        DemonstrateStructuralPatterns();
                        break;
                    case "3":
                        DemonstrateBehavioralPatterns();
                        break;
                    case "4":
                        DemonstrateAllPatterns();
                        break;
                    case "q":
                    case "quit":
                        Console.WriteLine("Thank you for exploring Design Pattern Samples!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Choose a category to explore:");
            Console.WriteLine("1. Creational Patterns");
            Console.WriteLine("2. Structural Patterns");
            Console.WriteLine("3. Behavioral Patterns");
            Console.WriteLine("4. Demonstrate All Patterns");
            Console.WriteLine("Q. Quit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
        }

        private static void DemonstrateCreationalPatterns()
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("                    CREATIONAL PATTERNS");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            
            // Singleton Pattern
            Console.WriteLine("--- SINGLETON PATTERN ---");
            Console.WriteLine("Ensures a class has only one instance and provides global access to it.");
            DemonstrateSingleton();
            Console.WriteLine();
            
            // Factory Pattern
            Console.WriteLine("--- FACTORY PATTERN ---");
            Console.WriteLine("Creates objects without specifying their exact class.");
            FactoryTest.Test();
            Console.WriteLine();
            
            // Abstract Factory Pattern
            Console.WriteLine("--- ABSTRACT FACTORY PATTERN ---");
            Console.WriteLine("Provides an interface for creating families of related objects.");
            AbstractFactoryTest.Test();
            Console.WriteLine();
            
            // Builder Pattern
            Console.WriteLine("--- BUILDER PATTERN ---");
            Console.WriteLine("Constructs complex objects step by step.");
            BuilderTest.Test();
            Console.WriteLine();
            
            // Prototype Pattern
            Console.WriteLine("--- PROTOTYPE PATTERN ---");
            Console.WriteLine("Creates objects by cloning existing instances.");
            PrototypeTest.Test();
            Console.WriteLine();
        }

        private static void DemonstrateStructuralPatterns()
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("                    STRUCTURAL PATTERNS");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            
            // Adapter Pattern
            Console.WriteLine("--- ADAPTER PATTERN ---");
            Console.WriteLine("Allows incompatible interfaces to work together.");
            AdapterTest.Test();
            Console.WriteLine();
            
            // Composite Pattern
            Console.WriteLine("--- COMPOSITE PATTERN ---");
            Console.WriteLine("Composes objects into tree structures.");
            CompositeTest.Test();
            Console.WriteLine();
            
            // Decorator Pattern
            Console.WriteLine("--- DECORATOR PATTERN ---");
            Console.WriteLine("Adds new functionality to objects dynamically.");
            DecoratorTest.Test();
            Console.WriteLine();
            
            // Facade Pattern
            Console.WriteLine("--- FACADE PATTERN ---");
            Console.WriteLine("Provides a simplified interface to a complex subsystem.");
            FacadeTest.Test();
            Console.WriteLine();
            
            // Flyweight Pattern
            Console.WriteLine("--- FLYWEIGHT PATTERN ---");
            Console.WriteLine("Minimizes memory usage by sharing common data.");
            FlyweightTest.Test();
            Console.WriteLine();
            
            // Proxy Pattern
            Console.WriteLine("--- PROXY PATTERN ---");
            Console.WriteLine("Provides a placeholder or surrogate for another object.");
            ProxyTest.Test();
            Console.WriteLine();
        }

        private static void DemonstrateBehavioralPatterns()
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("                    BEHAVIORAL PATTERNS");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            
            // Iterator Pattern
            Console.WriteLine("--- ITERATOR PATTERN ---");
            Console.WriteLine("Provides a way to access elements of a collection sequentially.");
            IteratorTest.Test();
            Console.WriteLine();
            
            // Null Object Pattern
            Console.WriteLine("--- NULL OBJECT PATTERN ---");
            Console.WriteLine("Eliminates the need for null checks by providing default behavior.");
            NullObjectTest.Test();
            Console.WriteLine();
        }

        private static void DemonstrateAllPatterns()
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("              COMPLETE DESIGN PATTERNS DEMONSTRATION");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            
            DemonstrateCreationalPatterns();
            Console.WriteLine("\n" + new string('=', 65) + "\n");
            
            DemonstrateStructuralPatterns();
            Console.WriteLine("\n" + new string('=', 65) + "\n");
            
            DemonstrateBehavioralPatterns();
        }

        private static void DemonstrateSingleton()
        {
            // Demonstrate different Singleton implementations
            Console.WriteLine("Testing Singleton V1 (Thread-unsafe):");
            var singleton1a = SingletonV1.Instance;
            var singleton1b = SingletonV1.Instance;
            Console.WriteLine($"Same instance: {ReferenceEquals(singleton1a, singleton1b)}");
            
            Console.WriteLine("\nTesting Singleton V2 (Thread-safe with lock):");
            var singleton2a = SingletonV2.Instance;
            var singleton2b = SingletonV2.Instance;
            Console.WriteLine($"Same instance: {ReferenceEquals(singleton2a, singleton2b)}");
        }
    }
}
