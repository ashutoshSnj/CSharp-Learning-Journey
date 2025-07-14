
# 🌟 C# Multithreading & Async/Await Notes (2025-07-11)

## 🧵 Topics Covered

- Thread creation using `Thread` class  
- `ParameterizedThreadStart` usage  
- `Start()`, `Join()`, `IsAlive` methods  
- Race condition and synchronization  
- `lock` keyword and monitor concept  
- `this` vs custom lock object  
- `async/await` in C#  
- Difference between blocking and non-blocking code  
- Java vs C# comparison (Multithreading & Async)

---

## 🔧 Thread Creation in C#

### ✅ Basic Thread

```csharp
Thread t1 = new Thread(SomeMethod);
t1.Start();
```

### ✅ With Parameters

```csharp
Thread t2 = new Thread(new ParameterizedThreadStart(SomeMethodWithParam));
t2.Start("some value");
```

---

## 🔐 Synchronization in C#

### Using `lock`

```csharp
lock(this)
{
    // critical section
}
```

### Or Use a Custom Lock Object

```csharp
private readonly object lockObj = new object();

lock(lockObj)
{
    // safe access
}
```

#### ❓ Why Use Custom Lock?

Using `this` may lead to external code accidentally acquiring the lock — unsafe.  
A private `lockObj` gives more control and safety.

---

## 🚀 Thread Methods

| Method    | Description                   |
|-----------|-------------------------------|
| `Start()` | Starts the thread             |
| `Join()`  | Waits until thread finishes   |
| `IsAlive` | Checks if thread is running   |

---

## 🛑 Race Condition Example

When two threads access a shared resource simultaneously without synchronization, it leads to inconsistent results.

✅ **Handled using `lock`.**

---

## ⚡ Async & Await in C#

- `async` marks a method as asynchronous  
- `await` tells the compiler to "pause here" until the awaited task completes, **without blocking the thread**

---

## 🔄 Blocking vs Non-blocking

| Blocking Code           | Non-blocking Code         |
|-------------------------|---------------------------|
| `Thread.Sleep(3000)`    | `await Task.Delay(3000)`  |
| Freezes the thread      | Frees up the thread       |

---

## 🔁 Java vs C# Concepts

| Concept        | Java                        | C#               |
|----------------|-----------------------------|------------------|
| Async method   | `@Async`                    | `async`          |
| Await          | `CompletableFuture.get()`   | `await`          |
| Return type    | `CompletableFuture<T>`      | `Task<T>`        |
| Monitor lock   | `synchronized(obj)`         | `lock(obj)`      |

---

## 🧠 Best Practices

✅ Use `lock` to avoid race conditions  
✅ Prefer `lockObj` over `this` to protect shared data  
✅ Avoid blocking threads with `Thread.Sleep()` — use `await Task.Delay()`  
✅ Use `Task` over `Thread` for modern apps  
✅ Use `async/await` for clean, readable async code  
