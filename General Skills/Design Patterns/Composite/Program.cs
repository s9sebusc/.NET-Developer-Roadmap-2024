using Composite;

Manager manager1 = new Manager("Willy Brand", "Department Manager"); // composite, can have employees
Manager manager2 = new Manager("James Brown", "Security Manager"); // composite, can have employees
Manager manager3 = new Manager("John Smith", "Project Manager"); // composite, can have employees

Developer developer1 = new Developer("Mark Johnson", "Senior Developer"); // Leaf, no employees
Developer developer2 = new Developer("Alex Miller", "Junior Developer"); // Leaf, no employees

manager1.Add(manager3);
manager1.Add(manager2);
manager2.Add(developer1);
manager2.Add(developer2);

manager1.Display();
