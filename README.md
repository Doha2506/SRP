✅ Week 1 Task: Refactor a Violation of SRP
-------------------------
🧠 Goal:
Apply Single Responsibility Principle — every class should have one reason to change, meaning it should do one job only.

📄 Task Scenario:
You're given a class that fetches product data, saves logs, and sends notifications — all in one place. Your mission is to refactor this class by applying SRP.

🔧 Code Spec (You Must Start From This)
Create a file named: ProductService.cs
Use this class structure as your starting point:

-----------------------
public class ProductService
{
    public void ProcessProduct()
    {
        // 1. Fetch product from database
        Console.WriteLine("Fetching product from database...");

        // 2. Save log to file
        Console.WriteLine("Logging: Product fetched at " + DateTime.Now);

        // 3. Send notification email
        Console.WriteLine("Sending email: Product fetched.");
    }
}
---------------------
🎯 Your Tasks:

✅ Task 1:
Refactor the above into separate classes, each doing only one responsibility, and make the ProductService only coordinate between them.

✅ Task 2:
Use interfaces where appropriate and follow dependency injection principles.

✅ Task 3:
Write a Main method or console app entry to demonstrate that the refactored code still behaves the same.

📁 Project Structure Example (Optional)
You can follow a structure like:

/Week1-SRP/
│
├── Interfaces/
│   ├── IProductFetcher.cs
│   ├── ILogger.cs
│   └── INotifier.cs
│
├── Services/
│   ├── ProductFetcher.cs
│   ├── FileLogger.cs
│   └── EmailNotifier.cs
│
├── ProductService.cs
└── Program.cs
