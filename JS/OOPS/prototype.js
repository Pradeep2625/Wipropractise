// OOPS/prototype.js
// JavaScript Prototype Example
// Creating a prototype object
//prototype is a mechanism in JavaScript that allows you to add properties and methods to existing objects or functions.
// It is a fundamental part of JavaScript's object-oriented programming model.

let company = { name: "wipro", location: "hyderabad" };
let employ = { empname: "pradeep", designation: "developer", __proto__: company };
console.log(employ.empname, employ.designation, employ.name, employ.location);

function Employee(empname, designation) {
  this.empname = empname;
  this.designation = designation;
}

Employee.prototype.EmployeeDetails = function () {
  return `Employee Name: ${this.empname}, Designation: ${this.designation}`;
}
let emp1 = new Employee("John", "Developer");
let emp2 = new Employee("Jane", "Designer");
console.log(emp1.EmployeeDetails());
console.log(emp2.EmployeeDetails());
// Adding a new property to the prototype
Employee.prototype.company = "wipro";
console.log("company " + emp1.company); // Output: TechCorp

//method to get employee details
function Animal() {} // Animal constructor function
Animal.prototype.speak = function () { // Method to be inherited
  return `Animal speaking`;
};

function Dog() {} // Dog constructor function
Dog.prototype = Object.create(Animal.prototype);// Inherit from Animal
Dog.prototype.bark = function () {// Method specific to Dog
  return `Woof!`;
};

Dog.prototype.constructor = Dog;// Restore the constructor reference