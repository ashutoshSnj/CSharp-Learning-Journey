
# 🌟 C# LINQ Interview & Real-Use CheatSheet (Downloadable)

## 📘 What is LINQ?
LINQ (Language Integrated Query) allows you to perform queries on collections like arrays, lists, or databases in a SQL-like or stream-style way.

Think of LINQ as the **Stream API of Java**, but built directly into C#.

---

## 🔥 Top 15 Commonly Used LINQ Methods (with Examples & Explanations)

### 1. `Where()` – Filter Elements
```csharp
var evens = numbers.Where(x => x % 2 == 0);
```
✅ Filters elements based on a condition. Equivalent to Java's `.filter()`.

---

### 2. `Select()` – Transform/Map Elements
```csharp
var squares = numbers.Select(x => x * x);
```
✅ Projects/transforms each item. Like Java’s `.map()`.

---

### 3. `OrderBy()` – Sort in Ascending Order
```csharp
var asc = numbers.OrderBy(x => x);
```
✅ Sorts elements in ascending order.

---

### 4. `OrderByDescending()` – Sort in Descending Order
```csharp
var desc = numbers.OrderByDescending(x => x);
```
✅ Sorts elements in descending order.

---

### 5. `Take(n)` – Get First N Elements
```csharp
var top3 = numbers.Take(3);
```
✅ Useful when you want top `n` records.

---

### 6. `Skip(n)` – Skip First N Elements
```csharp
var skipped = numbers.Skip(3);
```
✅ Used for pagination with `Take()`.

---

### 7. `First()` – Get First Item (Exception If Empty)
```csharp
var first = numbers.First();
```
✅ Use when you're sure list isn't empty.

---

### 8. `FirstOrDefault()` – Get First Item or Default (Safe)
```csharp
var firstOrDefault = emptyList.FirstOrDefault(); // returns 0/null
```
✅ Prevents exceptions if the list is empty.

---

### 9. `Last()` – Get Last Element
```csharp
var last = numbers.Last();
```
✅ Gets the last element. Throws if empty.

---

### 10. `Any()` – Check if Any Element Matches
```csharp
bool hasLarge = numbers.Any(x => x > 100);
```
✅ Returns true if **any** match is found.

---

### 11. `All()` – Check if All Elements Match
```csharp
bool allPositive = numbers.All(x => x > 0);
```
✅ Returns true only if **all** elements match condition.

---

### 12. `Count()` – Count Elements
```csharp
int count = numbers.Count();
```
✅ Counts total or filtered items.

---

### 13. `Distinct()` – Remove Duplicates
```csharp
var distinctValues = numbers.Distinct();
```
✅ Removes duplicate values.

---

### 14. `ToList()` – Convert to List (Force Execution)
```csharp
var filteredList = numbers.Where(x => x > 5).ToList();
```
✅ Converts query to actual `List<T>`. Required to iterate multiple times.

---

### 15. `GroupBy()` – Group Elements by Key
```csharp
var grouped = names.GroupBy(n => n);
foreach (var group in grouped)
{
    Console.WriteLine($"{group.Key} appears {group.Count()} times");
}
```
✅ Used to group records (e.g. by city, category, etc.)

---

## ✅ Intermediate vs Terminal Operations in LINQ (Like Java Stream)

| Type           | Examples                     | Execution       |
|----------------|------------------------------|------------------|
| Intermediate   | `Where()`, `Select()`, `OrderBy()` | Lazy (Deferred) |
| Terminal       | `ToList()`, `First()`, `Count()` | Executes Query  |


---

## 💡 Real-World Combo Example:
```csharp
var top3EvenSquares = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * x)
    .OrderByDescending(x => x)
    .Take(3)
    .ToList();
```

---

## 🚀 Interview & Project Use Cases:
- Filter employee records by department or age
- Transform entity to DTO
- Use `Skip()` + `Take()` for pagination in APIs
- Use `GroupBy()` to generate reports
- Check validations with `Any()` / `All()`

---

## ☑️ Java vs C# Stream Differences
| Feature                | Java Stream API            | C# LINQ                     |
|------------------------|-----------------------------|-----------------------------|
| Stream Creation        | `list.stream()` required    | Directly on list (no `.stream()` needed) |
| Filter                 | `.filter()`                 | `.Where()`                 |
| Map                   | `.map()`                    | `.Select()`                |
| Collect                | `.collect(toList())`        | `.ToList()`                |
| Group                 | `.collect(groupingBy())`    | `.GroupBy()`               |

---

## 📁 Reminder:
```java
// Java
list.stream().filter(...).map(...).collect(Collectors.toList());

// C#
list.Where(...).Select(...).ToList();
```
✅ Because `List<T>` already implements `IEnumerable<T>` in C#.

---

## 💪 Keep Learning Daily
> "Every day you learn, every day you grow."
