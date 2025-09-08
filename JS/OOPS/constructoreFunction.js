/* 
Constructor Function Example
In JavaScript, a constructor function is a special type of function that is used to create and initialize objects.
    1. It is typically named with a capital letter to distinguish it from regular functions.
    2.Constructor functions are used to create multiple instances of an object with the same properties and methods.
    3.Constructor functions are called with the `new` keyword, which creates a new object and sets the prototype of that object to the constructor's prototype.
    4.And also used this keyword to refer to the newly created object inside the constructor function.
*/

function Company(name, location) {
  this.name = name;
  this.location = location;
}
function Employee(empname, designation) {
  this.empname = empname;
  this.designation = designation;
  this.company = new Company("wipro", "hyderabad");
}
// Adding a method to the Employee prototype
//prototype is a mechanism in JavaScript that allows you to add properties and methods to existing objects or functions.
//.prototype binds the method to the Employee constructor function, allowing all instances of Employee to access it.
Employee.prototype.EmployeeDetails = function () {
  return `Employee Name: ${this.empname}, Designation: ${this.designation}, Company: ${this.company.name}, Location: ${this.company.location}`;
}
let emp1 = new Employee("John", "Developer");
let emp2 = new Employee("Jane", "Designer");
console.log(emp1.EmployeeDetails());
console.log(emp2.EmployeeDetails());
// Adding a new property to the Employee prototype
Employee.prototype.salary = 50000;
console.log("Salary of emp1: " + emp1.salary); // Output: Salary of emp1: 50000
console.log("Salary of emp2: " + emp2.salary); // Output: Salary of emp2: 50000

