let name = "pradeep";
let age = 30;
let isStudent = false;
let user;
let userDetails = undefined;
let dob = null;
/*
    typeOf() is a built-in JavaScript function that returns the type of a variable or expression.
    It can be used to determine the data type of a variable at runtime.
*/
console.log(typeof name); // Output: string
console.log(typeof age); // Output: number
console.log(typeof isStudent); // Output: boolean
console.log(typeof user); // Output: undefined
console.log(typeof userDetails); // Output: undefined
console.log(typeof dob); // Output: object (null is considered an object in JavaScript)
console.log(dob);

/*
    symbol is a new primitive data type introduced in ES6 (ECMAScript 2015).
    It is used to create unique identifiers for object properties.
    Symbols are immutable and can be used to avoid name clashes in object properties.
*/
let uniqueId1 = Symbol("id");
let uniqueId2 = Symbol("id");
console.log(uniqueId1 === uniqueId2); // Output: false, because each symbol is
console.log(typeof uniqueId); // Output: symbol

let firstName = "Ganesula";
let lastName = "Pradeep";
let fullName = `${firstName} ${lastName}`; // Template literals for string interpolation
console.log(fullName); // Output: Ganesula Pradeep