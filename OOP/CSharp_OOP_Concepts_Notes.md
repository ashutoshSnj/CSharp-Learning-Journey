# 🧱 C# OOP Concepts with Practical Examples

This document explains the **4 Pillars of Object-Oriented Programming (OOP)** in C#, along with real code examples from `Employee` and `SalseMan` classes.

---

## ✅ 1. Encapsulation

**Encapsulation** means binding data and methods together in a class, and controlling access to them using access modifiers.

```csharp
public class Employee
{
    private int id;
    private string name;

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int GetId() => this.id;
    public string GetName() => this.name;

    public void SetId(int id) => this.id = id;
    public void SetName(string name) => this.name = name;
}
```
🔒 Fields are made private and accessed through public methods.

---

## ✅ 2. Inheritance

Inheritance allows a class to reuse and extend features of another class.

```csharp
public class SalseMan : Employee
{
    private int target;

    public SalseMan(int id, string name, int target) : base(id, name)
    {
        this.target = target;
    }

    public override void Print()
    {
        Console.WriteLine("SalseMan method called: " + this.target);
    }
}
```
👨‍👦 `SalseMan` inherits from `Employee` using `: base(...)`.

---

## ✅ 3. Polymorphism

Polymorphism means one interface, many implementations.

### ➤ Method Overriding (Runtime Polymorphism)

```csharp
public class Employee
{
    public virtual void Print()
    {
        Console.WriteLine("Employee method called");
    }
}

public class SalseMan : Employee
{
    public override void Print()
    {
        Console.WriteLine("SalseMan method called");
    }
}
```

**Usage:**
```csharp
Employee e = new SalseMan(1, "Ashutosh", 500);
e.Print();  // Output: SalseMan method called
```

---

## ✅ 4. Abstraction (Selective Ignorance)

🧠 **Definition (Real View):**  
Abstraction is the process of selective ignorance — we focus only on what is essential and hide everything else that is unnecessary.

🛠 **In Software:**

- Show only the methods/properties that matter to the caller
- Hide unnecessary details behind a class/interface

🔸 **Real-World Analogy:**  
📦 *TV Remote*: You press Power, Volume, etc. — you don’t care about internal wiring or circuits.  
That’s abstraction — only important controls are shown, rest is hidden.

🔸 **Code Example:**
```csharp
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius) { this.radius = radius; }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
```

```csharp
Shape shape = new Circle(5);
Console.WriteLine(shape.GetArea());  // We don’t care how it’s calculated
```

### ✅ Abstraction Tools in C#:

| Tool           | Purpose                      |
|----------------|------------------------------|
| abstract class | Hide logic, force overriding |
| interface      | Expose only behavior         |
| Access Modifiers | Use private, public, protected to hide/show data |

---

## 🔍 Summary:

- Abstraction = Hide internal logic, expose only what's needed  
- It’s a design thinking, not just a keyword

---

## 🧠 Equality in C#: Equals(), ==, and GetHashCode()

By default, `==` and `Equals()` compare reference, not content.

### ✅ Solution: Override all 3

```csharp
public override bool Equals(object? obj)
{
    if (obj == null || this.GetType() != obj.GetType()) return false;

    SalseMan other = (SalseMan)obj;
    return this.GetId() == other.GetId();
}

public static bool operator ==(SalseMan obj1, SalseMan obj2)
{
    if ((object)obj1 == null || (object)obj2 == null) return false;
    return obj1.GetId() == obj2.GetId();
}

public static bool operator !=(SalseMan obj1, SalseMan obj2)
{
    return !(obj1 == obj2);
}

public override int GetHashCode()
{
    return this.GetId();
}
```

---

## 🧪 String Equality in C#

```csharp
string name1 = "Ashutosh";
string name2 = new string("Ashutosh");

Console.WriteLine(name1 == name2);         // ✅ True
Console.WriteLine(name1.Equals(name2));    // ✅ True
```

✅ Always prefer `.Equals()` for content comparison.

---

## 🧪 Sample Output:

```csharp
SalseMan em1 = new SalseMan(1, "Ashutosh", 500);
SalseMan em2 = new SalseMan(1, "Ashutosh", 500);

Console.WriteLine(em1.Equals(em2));   // True
Console.WriteLine(em1 == em2);        // True

SalseMan em3 = new SalseMan(2, "Ajay", 300);
Console.WriteLine(em1 == em3);        // False
```