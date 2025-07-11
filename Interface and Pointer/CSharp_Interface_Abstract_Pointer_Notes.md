# 🔷 C# Abstract Classes, Interfaces & Unsafe Pointer Notes

This document contains two key parts:

- **Part 1:** Interfaces and Abstract Classes  
- **Part 2:** Unsafe Code and Pointer Usage

---

## 📘 Part 1: Interface vs Abstract Class

### 🔹 Interface: A Contract
- Interfaces define **what a class must do**, but not **how it does it**.
- All methods are **public and abstract by default** (except for static or default methods in C# 8+).
- Interfaces cannot have fields, but **constants are allowed**.
- Interface methods must be implemented by the class, unless marked as default.

```csharp
interface payable
{
    const int s = 12;
    void pay();

    public void payeable()
    {
        Console.WriteLine("interface method call");
    }
}
```

### 🔸 Important Notes:
- **Default methods** in interfaces (introduced in C# 8) provide a method body inside an interface.
- These do **not support polymorphism** like virtual/override.
- If you implement the same method explicitly, the default method is **hidden**, not overridden.

🧠 **This is called Method Hiding, NOT Runtime Polymorphism.**

---

### 🧱 Abstract Class

- Can have fields, constructors, implemented and abstract methods.
- Used when some **common functionality** is to be shared with derived classes.
- Abstract methods must be **overridden** in child classes.

```csharp
public abstract class Student
{
    public abstract void doStudy();
}
```

Derived class:
```csharp
public class Engineering_Student : Student
{
    public override void doStudy()
    {
        Console.WriteLine("derive class implements");
    }
}
```

✅ Abstract class gives **partial abstraction**. Interface gives **full abstraction**.

---

### 🤔 Interface vs Abstract Class

| Feature                    | Interface     | Abstract Class       |
|---------------------------|---------------|-----------------------|
| Fields                    | ❌ Not allowed | ✅ Allowed            |
| Constructors              | ❌ Not allowed | ✅ Allowed            |
| Access Modifiers          | ❌ No private  | ✅ Yes                |
| Multiple Inheritance      | ✅ Yes         | ❌ No                 |
| Default Method Support    | ✅ Yes (C# 8)  | ✅ Yes                |
| Polymorphism Support      | ❌ No for default method | ✅ Yes     |

---

## 📕 Part 2: Unsafe Code and Pointers

C# supports pointer programming using the `unsafe` keyword. Used in performance-critical systems like:

- Memory manipulation
- Interop with native code
- Game development / OS development

### 🔧 Unsafe Code Syntax

```csharp
unsafe
{
    int a = 10;
    int* b = &a;
    *b = 20;
}
```

🧠 `*` is used to dereference and `&` is used to get the address.

### ✅ fixed keyword
Used to **pin** an object in memory so GC doesn't move it.

```csharp
fixed (int* ptr = arr)
{
    // Access array using ptr
}
```

### 📌 Key Concepts:
- `unsafe` block: allows pointer operations
- `*`: dereference operator
- `&`: address-of operator
- `fixed`: prevents GC from relocating object
- `stackalloc`: allocates memory on the stack

### ⚠️ Important:
- Use unsafe only when absolutely necessary
- Needs `/unsafe` compiler flag or enabling it in project settings
- Can't be used in all project types (e.g., not allowed in some .NET Core environments by default)

---

## 🔚 Summary

- **Interfaces** = Contract (multiple inheritance, default methods, no runtime polymorphism for default)
- **Abstract Classes** = Partially implemented class (used for base functionality)
- **Unsafe & Pointers** = Low-level memory access with power and risk