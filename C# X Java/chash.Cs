using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

// C# Concepts Examples - Comparing with Java
// This file demonstrates C# concepts with Java equivalents

public class CSharpConcepts
{
    // 1. BASIC SYNTAX AND VARIABLES
    public static void BasicSyntax()
    {
        // C#: int number = 42; (same as Java)
        int number = 42;
        
        // C#: string text = "Hello World"; (Java: String text)
        string text = "Hello World";
        
        // C#: var auto = "Auto type"; (Java: var auto - Java 10+)
        var auto = "Auto type";
        
        // C#: const int CONSTANT = 100; (Java: final int CONSTANT)
        const int CONSTANT = 100;
        
        Console.WriteLine(text); // Java: System.out.println(text);
    }
    
    // 2. PROPERTIES (C# NATIVE CONCEPT)
    // Java uses getters/setters, C# has built-in properties
    public class Person
    {
        private string _name;
        private int _age;
        
        // C#: Auto-property (Java needs getter/setter methods)
        public string Name { get; set; }
        
        // C#: Property with validation (Java: getAge()/setAge() methods)
        public int Age 
        { 
            get => _age; 
            set => _age = value >= 0 ? value : _age; 
        }
    }
    
    // 3. NULLABLE TYPES
    public static void NullableTypes()
    {
        // C#: int? nullableInt = null; (Java: Integer nullableInt)
        int? nullableInt = null;
        
        // C#: string? nullableString = null; (Java: String nullableString)
        string? nullableString = null;
        
        // C#: nullableInt?.ToString() (Java: nullableInt != null ? nullableInt.toString() : null)
        string? result = nullableInt?.ToString();
    }
    
    // 4. STRING INTERPOLATION
    public static void StringInterpolation()
    {
        string name = "John";
        int age = 25;
        
        // C#: $"Hello {name}, you are {age} years old" (Java: String.format())
        string message = $"Hello {name}, you are {age} years old";
        
        // C#: Verbatim string (Java: Text Blocks Java 15+)
        string multiline = @"This is a
            multiline string
            like Java text blocks";
    }
    
    // 5. COLLECTIONS
    public static void Collections()
    {
        // C#: List<string> list = new List<string>(); (Java: List<String> list = new ArrayList<>())
        List<string> list = new List<string>();
        
        // C#: Dictionary<string, int> dict = new Dictionary<string, int>(); (Java: Map<String, Integer>)
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        // C#: var array = new int[] {1, 2, 3}; (same as Java)
        var array = new int[] {1, 2, 3};
        
        // Collection initialization (Java: Arrays.asList())
        var names = new List<string> {"Alice", "Bob", "Charlie"};
    }
    
    // 6. LINQ (C# NATIVE) - Java equivalent is Streams
    public static void LinqExamples()
    {
        var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
        // C#: LINQ query syntax (Java: Stream API)
        var result = numbers.Where(x => x % 2 == 0).Select(x => x * 2).ToList();
        
        // C#: FirstOrDefault (Java: findFirst().orElse())
        var first = numbers.FirstOrDefault(x => x > 5);
    }
    
    // 7. DELEGATES (C# NATIVE) - Java uses Functional Interfaces
    public delegate void MyDelegate(string message); // Java: @FunctionalInterface
    
    public static void Delegates()
    {
        // C#: Action<string> action = message => Console.WriteLine(message); (Java: Consumer<String>)
        Action<string> action = message => Console.WriteLine(message);
        
        // C#: Func<int, int, int> func = (a, b) => a + b; (Java: BinaryOperator<Integer>)
        Func<int, int, int> func = (a, b) => a + b;
        
        // C#: Predicate<int> predicate = x => x > 0; (same name in Java)
        Predicate<int> predicate = x => x > 0;
    }
    
    // 8. EVENTS (C# NATIVE) - Java uses Observer Pattern
    public class Publisher
    {
        // C#: event keyword (Java: List of handlers + methods)
        public event Action<string>? OnNotify;
        
        public void Notify(string message)
        {
            OnNotify?.Invoke(message); // Java: subscribers.forEach(handler -> handler.accept(message))
        }
    }
    
    // 9. EXCEPTION HANDLING
    public static void ExceptionHandling()
    {
        try
        {
            int result = 10 / 0;
        }
        catch (DivideByZeroException ex) // Java: ArithmeticException
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Cleanup code");
        }
        
        // C#: using statement (Java: try-with-resources)
        using (var reader = new StreamReader("file.txt"))
        {
            string? line = reader.ReadLine();
        }
    }
    
    // 10. INHERITANCE AND POLYMORPHISM
    public abstract class Animal // Same as Java
    {
        protected string name; // Same as Java
        
        public Animal(string name)
        {
            this.name = name;
        }
        
        public abstract void MakeSound(); // Java: makeSound()
        
        public virtual void Eat() // Java: needs @Override in subclass
        {
            Console.WriteLine($"{name} is eating");
        }
    }
    
    public class Dog : Animal // Java: extends Animal
    {
        public Dog(string name) : base(name) // Java: super(name)
        {
        }
        
        public override void MakeSound() // Java: @Override
        {
            Console.WriteLine($"{name} barks");
        }
        
        public override void Eat()
        {
            Console.WriteLine($"{name} eats dog food");
        }
    }
    
    // 11. INTERFACES
    public interface IDrawable // C# convention: I prefix (Java: no prefix)
    {
        void Draw(); // Java: draw()
        
        // Default implementation (Java 8+: default methods)
        void Prepare()
        {
            Console.WriteLine("Preparing to draw");
        }
    }
    
    // 12. GENERICS
    public class GenericClass<T> // Same as Java
    {
        private T value;
        
        public void SetValue(T value) // Java: setValue()
        {
            this.value = value;
        }
        
        public T GetValue() // Java: getValue()
        {
            return value;
        }
        
        // Generic method
        public static void Swap<U>(U[] array, int i, int j)
        {
            U temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    
    // 13. STATIC MEMBERS
    public static class MathUtils // Java: public static class (but Java can't have static classes at top level)
    {
        public static readonly double PI = 3.14159; // Java: public static final
        
        public static int Add(int a, int b) // Java: add()
        {
            return a + b;
        }
        
        // Static constructor (Java: static block)
        static MathUtils()
        {
            Console.WriteLine("MathUtils initialized");
        }
    }
    
    // 14. ENUMS
    public enum Day // Same as Java but simpler syntax
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    
    // 15. NESTED CLASSES
    public class OuterClass
    {
        private string outerField = "Outer";
        
        // Nested class (Java: static nested class)
        public class Nested
        {
            public void Display()
            {
                Console.WriteLine("Nested class");
            }
        }
        
        // Inner class (can access outer members)
        public class Inner
        {
            private OuterClass outer;
            
            public Inner(OuterClass outer)
            {
                this.outer = outer;
            }
            
            public void Display()
            {
                Console.WriteLine($"Inner class accessing: {outer.outerField}");
            }
        }
    }
    
    // 16. ASYNC/AWAIT (C# NATIVE) - Java uses CompletableFuture
    public static async Task<string> GetDataAsync()
    {
        // C#: async/await (Java: CompletableFuture.supplyAsync())
        await Task.Delay(1000); // Simulate async work
        return "Data loaded";
    }
    
    public static async Task AsyncOperations()
    {
        // C#: await keyword (Java: .thenAccept())
        string data = await GetDataAsync();
        Console.WriteLine(data);
    }
    
    public static async Task Main(string[] args)
    {
        BasicSyntax();
        
        var person = new Person();
        person.Name = "John"; // C# property (Java: person.setName("John"))
        person.Age = 25;
        
        Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");
        
        // Demonstrate other concepts
        Collections();
        LinqExamples();
        ExceptionHandling();
        await AsyncOperations();
        
        // Enum usage
        Day today = Day.Friday;
        Console.WriteLine($"Today is {today} (value: {(int)today})");
    }
}

import java.util.*;
import java.util.function.*;
import java.io.*;

// C# Concepts Examples - Comparing with Java
// This file demonstrates C# concepts with Java equivalents


public class CSharpConcepts {
    
    // 1. BASIC SYNTAX AND VARIABLES
    public static void basicSyntax() {
        // C#: int number = 42;
        int number = 42;
        
        // C#: string text = "Hello World";
        String text = "Hello World";
        
        // C#: var auto = "Auto type";
        var auto = "Auto type"; // Java 10+
        
        // C#: const int CONSTANT = 100;
        final int CONSTANT = 100;
        
        System.out.println(text); // C#: Console.WriteLine(text);
    }
    
    // 2. PROPERTIES (C# CONCEPT)
    // Java equivalent using getters/setters
    public static class Person {
        private String name;
        private int age;
        
        // C# property: public string Name { get; set; }
        public String getName() { return name; }
        public void setName(String name) { this.name = name; }
        
        // C# auto-property with validation
        public int getAge() { return age; }
        public void setAge(int age) {
            if (age >= 0) this.age = age;
        }
    }
    
    // 3. NULLABLE TYPES
    public static void nullableTypes() {
        // C#: int? nullableInt = null;
        Integer nullableInt = null;
        
        // C#: string? nullableString = null;
        String nullableString = null;
        
        // C#: nullableInt?.ToString()
        String result = nullableInt != null ? nullableInt.toString() : null;
    }
    
    // 4. STRING INTERPOLATION
    public static void stringInterpolation() {
        String name = "John";
        int age = 25;
        
        // C#: $"Hello {name}, you are {age} years old"
        String message = String.format("Hello %s, you are %d years old", name, age);
        
        // Java 15+ Text Blocks (similar to C# verbatim strings)
        String multiline = """
            This is a
            multiline string
            like C# @"string"
            """;
    }
    
    // 5. COLLECTIONS
    public static void collections() {
        // C#: List<string> list = new List<string>();
        List<String> list = new ArrayList<>();
        
        // C#: Dictionary<string, int> dict = new Dictionary<string, int>();
        Map<String, Integer> dict = new HashMap<>();
        
        // C#: var array = new int[] {1, 2, 3};
        int[] array = {1, 2, 3};
        
        // Collection initialization
        List<String> names = Arrays.asList("Alice", "Bob", "Charlie");
    }
    
    // 6. LINQ EQUIVALENT - STREAMS
    public static void linqEquivalent() {
        List<Integer> numbers = Arrays.asList(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        
        // C#: numbers.Where(x => x % 2 == 0).Select(x => x * 2).ToList()
        List<Integer> result = numbers.stream()
            .filter(x -> x % 2 == 0)
            .map(x -> x * 2)
            .collect(Collectors.toList());
        
        // C#: numbers.FirstOrDefault(x => x > 5)
        Optional<Integer> first = numbers.stream()
            .filter(x -> x > 5)
            .findFirst();
    }
    
    // 7. DELEGATES EQUIVALENT - FUNCTIONAL INTERFACES
    // C#: public delegate void MyDelegate(string message);
    @FunctionalInterface
    interface MyDelegate {
        void invoke(String message);
    }
    
    public static void delegates() {
        // C#: Action<string> action = message => Console.WriteLine(message);
        Consumer<String> action = message -> System.out.println(message);
        
        // C#: Func<int, int, int> func = (a, b) => a + b;
        BinaryOperator<Integer> func = (a, b) -> a + b;
        
        // C#: Predicate<int> predicate = x => x > 0;
        Predicate<Integer> predicate = x -> x > 0;
    }
    
    // 8. EVENTS EQUIVALENT - OBSERVER PATTERN
    public static class Publisher {
        private List<Consumer<String>> subscribers = new ArrayList<>();
        
        // C#: public event Action<string> OnNotify;
        public void subscribe(Consumer<String> handler) {
            subscribers.add(handler);
        }
        
        public void notify(String message) {
            subscribers.forEach(handler -> handler.accept(message));
        }
    }
    
    // 9. EXCEPTION HANDLING
    public static void exceptionHandling() {
        try {
            int result = 10 / 0;
        } catch (ArithmeticException ex) { // C#: catch (DivideByZeroException ex)
            System.err.println("Error: " + ex.getMessage());
        } finally {
            System.out.println("Cleanup code");
        }
        
        // Try-with-resources (similar to C# using statement)
        try (BufferedReader reader = new BufferedReader(new FileReader("file.txt"))) {
            // C#: using (var reader = new StreamReader("file.txt"))
            String line = reader.readLine();
        } catch (IOException ex) {
            System.err.println("IO Error: " + ex.getMessage());
        }
    }
    
    // 10. INHERITANCE AND POLYMORPHISM
    public static abstract class Animal { // C#: public abstract class Animal
        protected String name; // C#: protected string name;
        
        public Animal(String name) {
            this.name = name;
        }
        
        public abstract void makeSound(); // C#: public abstract void MakeSound();
        
        public virtual void eat() { // C# virtual method
            System.out.println(name + " is eating");
        }
    }
    
    public static class Dog extends Animal { // C#: public class Dog : Animal
        public Dog(String name) {
            super(name); // C#: base(name)
        }
        
        @Override
        public void makeSound() { // C#: public override void MakeSound()
            System.out.println(name + " barks");
        }
        
        @Override
        public void eat() { // Override virtual method
            System.out.println(name + " eats dog food");
        }
    }
    
    // 11. INTERFACES
    public interface IDrawable { // C#: public interface IDrawable
        void draw(); // C#: void Draw();
        
        // Default method (Java 8+, similar to C# default interface methods)
        default void prepare() {
            System.out.println("Preparing to draw");
        }
    }
    
    // 12. GENERICS
    public static class GenericClass<T> { // C#: public class GenericClass<T>
        private T value;
        
        public void setValue(T value) { // C#: public void SetValue(T value)
            this.value = value;
        }
        
        public T getValue() { // C#: public T GetValue()
            return value;
        }
        
        // Generic method
        public static <U> void swap(U[] array, int i, int j) {
            U temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    
    // 13. STATIC MEMBERS
    public static class MathUtils { // C#: public static class MathUtils
        public static final double PI = 3.14159; // C#: public static readonly double PI
        
        public static int add(int a, int b) { // C#: public static int Add(int a, int b)
            return a + b;
        }
        
        // Static constructor equivalent - static block
        static {
            // C#: static MathUtils() { ... }
            System.out.println("MathUtils initialized");
        }
    }
    
    // 14. ENUMS
    public enum Day { // C#: public enum Day
        MONDAY(1), TUESDAY(2), WEDNESDAY(3), THURSDAY(4), 
        FRIDAY(5), SATURDAY(6), SUNDAY(7);
        
        private final int value;
        
        Day(int value) {
            this.value = value;
        }
        
        public int getValue() {
            return value;
        }
    }
    
    // 15. NESTED CLASSES
    public static class OuterClass {
        private String outerField = "Outer";
        
        // Static nested class (similar to C# nested class)
        public static class StaticNested {
            public void display() {
                System.out.println("Static nested class");
            }
        }
        
        // Inner class (similar to C# inner class)
        public class Inner {
            public void display() {
                System.out.println("Inner class accessing: " + outerField);
            }
        }
    }
    
    // 16. ASYNC/AWAIT EQUIVALENT - COMPLETABLEFUTURE
    public static void asyncOperations() {
        // C#: async Task<string> GetDataAsync()
        CompletableFuture<String> future = CompletableFuture.supplyAsync(() -> {
            try {
                Thread.sleep(1000); // Simulate async work
                return "Data loaded";
            } catch (InterruptedException e) {
                return "Error";
            }
        });
        
        // C#: await GetDataAsync()
        future.thenAccept(System.out::println);
    }
    
    public static void main(String[] args) {
        basicSyntax();
        
        Person person = new Person();
        person.setName("John");
        person.setAge(25);
        
        System.out.println("Person: " + person.getName() + ", Age: " + person.getAge());
        
        // Demonstrate other concepts
        collections();
        linqEquivalent();
        exceptionHandling();
        asyncOperations();
        
        // Enum usage
        Day today = Day.FRIDAY;
        System.out.println("Today is " + today + " (value: " + today.getValue() + ")");
    }
}
