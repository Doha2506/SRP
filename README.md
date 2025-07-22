# SRP
Implementing Single Responsibility Principle (SRP) 

1. What was wrong with the original design?

  the wrong was that we do multiple things in one class and when we want to edit on fetching product or logging product this means i will change the class multiple times which    violate the principle of sing responsibilty  

3. What changes did you make?

  i make 3 interfaces and 3 services for each function i will do fect , log and notify .. then i register them in program.cs to enable me to call them 

3. How is the new version better?
  it makes it easy to me to locate the file which contains the part will change only and ensure that no other part will be affected if i make change in it.
   
