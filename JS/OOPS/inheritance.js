/*
    Inheritance in JavaScript allows one object to inherit properties and methods from another.
    1. It is a way to create a new object that is based on an existing object, allowing for code reuse and the creation of hierarchical relationships.
    2. Inheritance can be achieved using constructor functions, prototypes, or ES6 classes.
    3. The prototype chain is a key concept in inheritance, where an object can access properties and methods from its prototype and the prototypes of its prototype, forming a chain.
    4. Inheritance allows for the creation of more specific objects that can extend or override properties and methods of a more general object.
 */

class Company {
    constructor(name, location) {
        this.name = name;
        this.location = location;
    }
}

Company.prototype.CompanyDetails = function () {
    return `Company Name: ${this.name}, Location: ${this.location}`;
}
class Employee extends Company {
    constructor(empname, designation, companyName, companyLocation) {
        //super() is used to call the constructor of the parent class (Company in this case).
        super(companyName, companyLocation); // Call the parent class constructor 
        //this refers to the current instance of the Employee class.
        //It allows you to set properties specific to the Employee class.
        this.empname = empname;
        this.designation = designation; 
    }
// Adding a method to the Employee class
    EmployeeDetails() {
        return `Employee Name: ${this.empname}, Designation: ${this.designation}, Company: ${this.name}, Location: ${this.location}`;
    }
}
let emp1 = new Employee("John", "Developer", "Wipro", "Hyderabad");
let emp2 = new Employee("Jane", "Designer", "TCS", "Bangalore");
console.log(emp1.EmployeeDetails());
console.log(emp2.EmployeeDetails());