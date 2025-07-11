# 💥 C# Exception Handling - Full Notes

This note covers **exception handling in C#** with complete examples, concepts, and Java comparison.

---

## 📌 What is Exception Handling?

Exception handling is a mechanism to catch and handle **runtime errors** in a controlled way.

### ✅ Syntax:
```csharp
try
{
    // risky code
}
catch (ExceptionType ex)
{
    // handle it
}
finally
{
    // always runs
}
```

---

## 🚫 All Exceptions Are Unchecked in C#

Unlike Java, C# does not have checked exceptions. That means:

- ❌ No `throws` keyword  
- ❌ Compiler doesn't force try-catch  
- ✅ You can ignore exceptions, but app may crash at runtime

---

## 📊 Java vs C# Exception Handling

| Feature                         | Java        | C#         |
|--------------------------------|-------------|------------|
| Checked Exceptions             | ✅ Yes      | ❌ No      |
| `throws` keyword               | ✅ Required | ❌ Not used |
| Compiler enforces handling     | ✅ Yes      | ❌ No       |
| `IOException` checked?         | ✅ Yes      | ❌ No       |
| Can crash at runtime           | ✅ Yes      | ✅ Yes      |

---

## 🔹 Throwing Exceptions

```csharp
throw new Exception("Something went wrong");
```

You can throw:

- Built-in exceptions like `DivideByZeroException`, `IOException`, etc.  
- Your own **custom exceptions**

---

## 🔨 Custom Exception

```csharp
public class BalanceLessException : Exception
{
    public BalanceLessException(string message) : base(message) {}

    public override string ToString()
    {
        return $"BalanceLessException: {Message}";
    }
}
```

---

## 🏦 Real Bank Example

### Bank.cs
```csharp
public class Bank
{
    private int id;
    private string name;
    private double amount;

    public Bank(int id, string name, double amount)
    {
        this.id = id;
        this.name = name;
        this.amount = amount;
    }

    public void Withdraw(int withdrawAmount)
    {
        double finalBalance = this.amount - withdrawAmount;
        if (finalBalance < 0)
        {
            throw new BalanceLessException("Cannot withdraw: insufficient balance.");
        }

        this.amount = finalBalance;
    }
}
```

### MainApp.cs
```csharp
public class MainApp
{
    public static void Main(string[] args)
    {
        Bank acc = new Bank(1, "Ashutosh Shelke", 125.02);

        try
        {
            acc.Withdraw(1250);  // This will throw
        }
        catch (BalanceLessException ex)
        {
            Console.WriteLine(ex);  // Output: BalanceLessException: Cannot withdraw...
        }
    }
}
```

---

## 🔁 finally Block

```csharp
try
{
    int result = 100 / age;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Age cannot be zero");
}
finally
{
    Console.WriteLine("I am always executed");
}
```

---

## 📘 Common Exception Hierarchy in C#

```
object
 └── System.Exception
       ├── SystemException
       │     ├── DivideByZeroException
       │     ├── NullReferenceException
       │     └── IndexOutOfRangeException
       ├── IOException
       │     └── FileNotFoundException
       └── YourCustomException
```

---

## 🎯 How Caller Knows Method Throws Exception?

C# doesn't use `throws`, so the caller knows by:

- Reading **XML comments**
- IntelliSense in IDE
- Reading method body
- Documentation

```csharp
/// <exception cref="BalanceLessException">
/// Thrown when balance is insufficient.
/// </exception>
public void Withdraw(int amount) { ... }
```

---

## 🔎 String Interpolation for Exception Messages

```csharp
public override string ToString()
{
    return $"BalanceLessException: {Message}";
}
```

✅ `$"..."` is **string interpolation** in C# (like template literals).

---

## ✅ Final Tips

- Always use `try-catch` when dealing with file/network/db operations  
- Use custom exceptions for **business rule violations**  
- Document your exceptions with `/// <exception>` comments  
- Use `finally` for cleanup (like closing file/connection)