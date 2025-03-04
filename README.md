# Software Design Principles in C#

##Overview
This repository explains key **software design principles** with **real-life examples** in C#. These principles help write **clean, maintainable, and scalable** code.

---

### **SOLID Principles**
- **S** - **Single Responsibility Principle (SRP)**  
  *A class should have only one reason to change.*  
  **Example:** A `paymentProcessor` class should only process payments, while a separate `transactionLogger` class handles just the transaction logs.

- **O** - **Open/Closed Principle (OCP)**  
  *Classes should be open for extension but closed for modification.*  
  **Example:** Use interfaces or abstract classes to allow new functionality without modifying existing code.

- **L** - **Liskov Substitution Principle (LSP)**  
  *Subtypes should be replaceable for their base types without breaking code.*  
  **Example:** A `TroyPayment` and `CreditCardPayment` should work interchangeably when using a `PaymentMethod` base class.

- **I** - **Interface Segregation Principle (ISP)**  
  *Clients should not be forced to depend on interfaces they do not use.*  
  **Example:** Instead of one `ITrancaction` interface with `payment()`, `refund()` split it into smaller interfaces like `IPaymentMethod`, `IIRefundable`.

- **D** - **Dependency Inversion Principle (DIP)**  
  *High-level modules should not depend on low-level modules. Both should depend on abstractions.*  
  **Example:** Use dependency injection instead of creating instances inside a class.

---

### **DRY (Don't Repeat Yourself)**
*Avoid duplicating code by using functions, classes, or modules.*  
**Example:** Instead of duplicating validation logic, create a reusable `CalculatePrice(int days, deciaml dailtyRate)` method.

---

### **KISS (Keep It Simple, Stupid)**
*Write code that is simple, clear, and easy to understand.*  
**Example:** Prefer `Dictionary<string, decimal>` over `switch` cases.

---

### **YAGNI (You Ain’t Gonna Need It)**
*Don't add features until you actually need them.*  
**Example:** Don't add values to the function unlesss you have a use for them in it.

---

### **Law of Demeter (LoD)**
*"Don't talk to strangers" – A class should only interact with its direct dependencies.*  
**Example:** A `Cashier` should call `Barista.MakeCoffee()`, not `Barista.CoffeeMachine.BrewCoffee()`.

---

### **Composition Over Inheritance**
*Favor using object composition instead of deep inheritance trees.*  
**Example:** A `Car` has an `Engine` object instead of extending a `Vehicle` class.
