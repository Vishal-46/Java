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

// 17. RECORD CLASSES (Java 14+) - Similar to C# Records
public record PersonRecord(String name, int age) {
    // C#: public record PersonRecord(string Name, int Age);
    
    // Custom constructor with validation
    public PersonRecord {
        if (age < 0) {
            throw new IllegalArgumentException("Age cannot be negative");
        }
    }
    
    // Additional methods can be added
    public String getDisplayName() {
        return name.toUpperCase();
    }
}

// 18. SEALED CLASSES (Java 17+) - Similar to C# Sealed Classes
public sealed class Shape permits Circle, Rectangle, Triangle {
    // C#: public sealed class Shape
    protected final String type;
    
    protected Shape(String type) {
        this.type = type;
    }
}

final class Circle extends Shape {
    private final double radius;
    
    public Circle(double radius) {
        super("Circle");
        this.radius = radius;
    }
    
    public double getArea() {
        return Math.PI * radius * radius;
    }
}

final class Rectangle extends Shape {
    private final double width, height;
    
    public Rectangle(double width, double height) {
        super("Rectangle");
        this.width = width;
        this.height = height;
    }
    
    public double getArea() {
        return width * height;
    }
}

final class Triangle extends Shape {
    private final double base, height;
    
    public Triangle(double base, double height) {
        super("Triangle");
        this.base = base;
        this.height = height;
    }
    
    public double getArea() {
        return 0.5 * base * height;
    }
}

// 19. PATTERN MATCHING (Java 17+) - Similar to C# Pattern Matching
public static class PatternMatching {
    
    public static String describe(Object obj) {
        // C#: obj switch { ... }
        return switch (obj) {
            case String s -> "String with length " + s.length();
            case Integer i when i > 0 -> "Positive integer: " + i;
            case Integer i -> "Non-positive integer: " + i;
            case null -> "Null value";
            default -> "Unknown type: " + obj.getClass().getSimpleName();
        };
    }
    
    public static double calculateArea(Shape shape) {
        // Pattern matching with sealed classes
        return switch (shape) {
            case Circle c -> c.getArea();
            case Rectangle r -> r.getArea();
            case Triangle t -> t.getArea();
        };
    }
}

// 20. ANNOTATIONS - Similar to C# Attributes
@interface CustomAnnotation {
    String value() default "";
    int priority() default 0;
}

@CustomAnnotation(value = "Important method", priority = 1)
public static void annotatedMethod() {
    // C#: [CustomAttribute(Value = "Important method", Priority = 1)]
    System.out.println("This method has custom annotation");
}

// 21. REFLECTION - Similar to C# Reflection
public static class ReflectionExample {
    
    public static void demonstrateReflection() {
        try {
            // Get class information
            Class<?> clazz = Person.class;
            System.out.println("Class name: " + clazz.getName());
            
            // Create instance
            Object instance = clazz.getDeclaredConstructor().newInstance();
            
            // Get and invoke methods
            java.lang.reflect.Method setNameMethod = clazz.getMethod("setName", String.class);
            setNameMethod.invoke(instance, "Reflection User");
            
            java.lang.reflect.Method getNameMethod = clazz.getMethod("getName");
            String name = (String) getNameMethod.invoke(instance);
            System.out.println("Name via reflection: " + name);
            
        } catch (Exception e) {
            System.err.println("Reflection error: " + e.getMessage());
        }
    }
}

// 22. BUILDER PATTERN - Common in both C# and Java
public static class ProductBuilder {
    private String name;
    private double price;
    private String category;
    private boolean available;
    
    public ProductBuilder setName(String name) {
        this.name = name;
        return this;
    }
    
    public ProductBuilder setPrice(double price) {
        this.price = price;
        return this;
    }
    
    public ProductBuilder setCategory(String category) {
        this.category = category;
        return this;
    }
    
    public ProductBuilder setAvailable(boolean available) {
        this.available = available;
        return this;
    }
    
    public Product build() {
        return new Product(name, price, category, available);
    }
}

public static class Product {
    private final String name;
    private final double price;
    private final String category;
    private final boolean available;
    
    public Product(String name, double price, String category, boolean available) {
        this.name = name;
        this.price = price;
        this.category = category;
        this.available = available;
    }
    
    // Getters
    public String getName() { return name; }
    public double getPrice() { return price; }
    public String getCategory() { return category; }
    public boolean isAvailable() { return available; }
    
    @Override
    public String toString() {
        return String.format("Product{name='%s', price=%.2f, category='%s', available=%s}", 
                           name, price, category, available);
    }
}

// 23. DEPENDENCY INJECTION CONCEPT
public interface IService {
    void performAction();
}

public static class EmailService implements IService {
    @Override
    public void performAction() {
        System.out.println("Sending email");
    }
}

public static class SmsService implements IService {
    @Override
    public void performAction() {
        System.out.println("Sending SMS");
    }
}

public static class NotificationManager {
    private final IService service;
    
    // Constructor injection (similar to C# DI)
    public NotificationManager(IService service) {
        this.service = service;
    }
    
    public void sendNotification() {
        service.performAction();
    }
}

// 24. EXTENSION METHODS EQUIVALENT - Utility Classes
public static class StringExtensions {
    // C#: public static bool IsNullOrEmpty(this string str)
    public static boolean isNullOrEmpty(String str) {
        return str == null || str.isEmpty();
    }
    
    public static String reverse(String str) {
        if (isNullOrEmpty(str)) return str;
        return new StringBuilder(str).reverse().toString();
    }
    
    public static String toTitleCase(String str) {
        if (isNullOrEmpty(str)) return str;
        return Arrays.stream(str.split(" "))
                .map(word -> word.substring(0, 1).toUpperCase() + 
                           word.substring(1).toLowerCase())
                .collect(Collectors.joining(" "));
    }
}

// 25. MULTIPLE INHERITANCE VIA INTERFACES (Diamond Problem Solution)
public interface CanFly {
    default void fly() {
        System.out.println("Flying in the sky");
    }
}

public interface CanSwim {
    default void swim() {
        System.out.println("Swimming in water");
    }
}

public static class Duck implements CanFly, CanSwim {
    @Override
    public void fly() {
        System.out.println("Duck is flying");
    }
    
    @Override
    public void swim() {
        System.out.println("Duck is swimming");
    }
}

// 26. ADVANCED GENERICS - Wildcards and Bounds
public static class AdvancedGenerics {
    
    // Upper bounded wildcard (similar to C# where T : BaseClass)
    public static void printAnimals(List<? extends Animal> animals) {
        for (Animal animal : animals) {
            animal.makeSound();
        }
    }
    
    // Lower bounded wildcard
    public static void addDogs(List<? super Dog> list) {
        list.add(new Dog("Buddy"));
    }
    
    // Multiple bounds (similar to C# where T : class, IInterface)
    public static <T extends Animal & IDrawable> void processDrawableAnimal(T item) {
        item.makeSound();
        item.draw();
    }
}

// 27. DEMONSTRATION METHOD
public static void demonstrateAdvancedConcepts() {
    System.out.println("\n=== ADVANCED C# TO JAVA CONCEPTS ===");
    
    // Records
    PersonRecord person = new PersonRecord("Alice", 30);
    System.out.println("Record: " + person);
    System.out.println("Display name: " + person.getDisplayName());
    
    // Pattern matching
    System.out.println("\nPattern Matching:");
    System.out.println(PatternMatching.describe("Hello"));
    System.out.println(PatternMatching.describe(42));
    System.out.println(PatternMatching.describe(-5));
    
    // Sealed classes and pattern matching
    Shape circle = new Circle(5);
    System.out.println("Circle area: " + PatternMatching.calculateArea(circle));
    
    // Builder pattern
    Product product = new ProductBuilder()
        .setName("Laptop")
        .setPrice(999.99)
        .setCategory("Electronics")
        .setAvailable(true)
        .build();
    System.out.println("\nBuilder pattern: " + product);
    
    // Dependency injection
    NotificationManager emailManager = new NotificationManager(new EmailService());
    NotificationManager smsManager = new NotificationManager(new SmsService());
    emailManager.sendNotification();
    smsManager.sendNotification();
    
    // String extensions
    System.out.println("\nString Extensions:");
    System.out.println("Reversed: " + StringExtensions.reverse("Hello"));
    System.out.println("Title case: " + StringExtensions.toTitleCase("hello world"));
    
    // Multiple inheritance via interfaces
    Duck duck = new Duck();
    duck.fly();
    duck.swim();
    
    // Reflection
    ReflectionExample.demonstrateReflection();
    
    System.out.println("\n=== All C# concepts covered in Java! ===");
}