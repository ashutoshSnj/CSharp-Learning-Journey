# 🚀 C# Collections Deep Exploration – By Ashutosh Shelke

📅 **Last Updated:** 2025-07-15

---

## 🧠 Objective:
Explore and master **C# Collections Framework** by comparing with **Java**, diving into internal behaviors, overriding mechanisms, and real-time usage. This also includes implementation examples and interview-level insights.

---

## ✅ 1. Core Concepts Explored

- Differences between Generic vs Non-Generic collections
- Interface hierarchy: `IEnumerable`, `IEnumerator`, `ICollection`, `IList`, `IDictionary`, `ISet`
- Manual iteration vs `foreach`
- Default capacity & resizing behavior (like Java’s `ArrayList`)
- Bucketing formula `(hash & (n - 1))` — same in Java and C#
- Collision handling techniques (LinkedList, Red-Black Tree in Java)

---

## 📚 2. Generic Collections (System.Collections.Generic)

### 🔹 List<T> → like Java's ArrayList
- Maintains insertion order, supports indexing
- Methods implemented:
  - `Add`, `Remove`, `ElementAt`, `Sort`, `Count`, `ForEach`, `Insert`
- Overloaded methods, default capacity, resizing explored
- Explored `ToString`, `string interpolation`, `+` vs `$""`

### 🔹 LinkedList<T> → like Java's LinkedList
- Implemented: `AddFirst`, `AddLast`, iteration
- Verified: no null elements unless explicitly added
- Internally doubly linked list

---

## 🔹 Set Collections

### ✔ HashSet<T>
- Allows only unique items
- 1 null value allowed
- Overridden:
  - `Equals()` and `GetHashCode()` in `Student` class

### ✔ SortedSet<T>
- Maintains elements in sorted order (like Java TreeSet)
- Must implement `IComparable<T>`
- No null elements allowed (throws exception)
- Explored `CompareTo()` logic with custom sorting

---

## 🔹 Dictionary / Map Collections

### ✔ Dictionary<TKey, TValue> → like Java's HashMap
- Fast key lookup via hashing
- No null key allowed (throws ArgumentNullException)
- Value duplicates allowed

### ✔ SortedDictionary<TKey, TValue> → like Java TreeMap
- Sorted by key using `CompareTo()` or custom comparer
- Must override `CompareTo()` in key type
- Explored error on null keys

### ✔ OrderedDictionary (non-generic) → like LinkedHashMap
- Maintains insertion order
- Allows one null key
- Used when key ordering is required + flexibility

---

## 🔃 Iterator Exploration

- Used `IEnumerator<T>` manually
- Compared with Java’s `Iterator`
- Noted: C# `IEnumerator` doesn’t support remove()
- Fail-Fast vs Fail-Safe: Discussed in both Java and C# context

---

## 👨‍💻 Student Class (Used across all structures)

```csharp
public class Student : IComparable<Student> {
    int id; string name;
    public override int GetHashCode() => this.id;
    public override bool Equals(object obj) => (obj as Student).id == this.id;
    public override string ToString() => $"Student(Id={this.id}, Name={this.name})";
    public int CompareTo(Student other) => this.id.CompareTo(other.id);
}
```
Used in:
- `HashSet`, `SortedSet`
- `Dictionary`, `SortedDictionary`, `OrderedDictionary`
- LINQ operations (filter, map, group)

---

## 🔍 Internals & Interview Insights

- Java vs C# bucket formula: **same** — `hash & (n - 1)`
- Collision handled via chaining → LinkedList/Tree (Java concept)
- Load factor & threshold: discussed theory (C# doesn’t expose directly)
- Why some collections allow null and others don’t
- Immutable and Concurrent collections — intro level touched

---

## 📦 Specialized Collections Briefed

- `Queue<T>` – FIFO structure
- `Stack<T>` – LIFO structure
- `ConcurrentDictionary<TKey, TValue>` – planned next
- `ImmutableList<T>` – touched upon, install via NuGet

---

## 🔄 Java vs C# Comparison Table

| Concept         | Java                          | C#                              |
|----------------|-------------------------------|----------------------------------|
| List            | ArrayList, LinkedList         | List<T>, LinkedList<T>          |
| Set             | HashSet, TreeSet              | HashSet<T>, SortedSet<T>        |
| Map             | HashMap, TreeMap              | Dictionary, SortedDictionary     |
| Ordered Map     | LinkedHashMap                 | OrderedDictionary (non-generic) |
| Thread Safe     | ConcurrentHashMap             | ConcurrentDictionary             |
| Immutable       | Java 9 Immutable              | System.Collections.Immutable     |
| Iterator        | Iterator (fail-fast)          | IEnumerator (no remove)          |

---

## 🧪 LINQ (Stream API Equivalent) — Upcoming Section

- `Where`, `Select`, `GroupBy`, `Any`, `All`, `OrderBy`
- Anonymous types, chaining filters
- Lambda and Delegates integration

---

## 🧑‍💻 Author

**Ashutosh Shelke**  
_Java + C# Dev | Spring Boot | REST APIs | Angular | MySQL | GitHub Contributor_

---

🚀 Keep Learning | Keep Building | Keep Documenting
