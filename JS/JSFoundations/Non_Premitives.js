/*
    * JSFoundations - Non-Primitives
    * This file contains examples of non-primitive data types in JavaScript.
    * Non-primitive data types include objects and arrays.
    * Non-primitive data types are reference types, meaning they are stored by reference rather than by value.
    * They can hold collections of values and more complex entities.
    * Non-primitive data types can be modified and are mutable.
    * They can also contain properties and methods.
    
*/

console.log("Non-Primitive Data Types in JavaScript");
/*
    Objects are collections of key-value pairs, where keys are strings (or Symbols) and values can be any data type.
    Objects can represent real-world entities and can contain methods (functions).
*/
let person = {
  name: "pradeep",
  age: 23,
  isprogrammer: true,
  hobbies: ["coding", "reading", "gaming"], // Array as a property
  address: {
    city: "Rajahmundry",
    state: "AP",
  }, // Nested object
};
console.log("Details of a person:", person);
console.log("Person's Name:", person.name); // Accessing object property
console.log("Person's Age:", person.age); // Accessing object property
console.log("Person's Hobbies:", person.hobbies); // Accessing array property
console.log("Person's City:", person.address.city); // Accessing nested object property
/*
    Arrays are ordered collections of values, which can be of any data type.
    Arrays are also objects in JavaScript and can hold multiple values in a single variable.
*/
let login = ["Pradeep2625", "pradeep@gmail.com", "Pradeep@2002", "true"];
console.log("Login Details:", login);
console.log("Username:", login[0]); // Accessing array element
console.log("Email:", login[1]); // Accessing array element
console.log("Password:", login[2]); // Accessing array element
console.log("Is Logged In:", login[3]); // Accessing array element

console.log("change password", (login[2] = "Pradeep@2023")); // Changing an array element
console.log("Updated Login Details:", login[2]); // Displaying updated array
console.log("Updated Login Details:", login);

let updatePerson = (person.address.city = "RJY"); // Changing a property of an object
console.log("Updated City:", updatePerson); // Displaying updated property
person.hobbies.push("travelling"); // Adding a new hobby to the array
console.log("Updated Hobbies:", person.hobbies); // Displaying updated array
login.pop();
console.log("Login Details after pop:", login); // Displaying array after removing last element
console.log(typeof person); // Output: object
console.log(typeof login); // Output: object
let name = 1245;
console.log(typeof name);
