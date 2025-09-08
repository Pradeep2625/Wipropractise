console.log("Datatypes in JavaScript");
/*
JavaScript has several built-in data types that can be categorized into two main groups: 
primitive types and reference types.
Primitive types include:
1. Number: Represents both integer and floating-point numbers.
   Example: `let age = 30;`, `let price = 19.99;`
2. String: Represents a sequence of characters.
    Example: `let name = "Alice";`, `let greeting = 'Hello, World!';`
3. Boolean: Represents a logical entity and can have two values: true or false.
    Example: `let isActive = true;`, `let isComplete = false;`
4. Undefined: A variable that has been declared but not assigned a value.
5. Null: Represents the intentional absence of any object value.
6. Symbol: A unique and immutable value often used as object property keys.
7. BigInt: Represents integers with arbitrary precision, useful for very large numbers.
Reference types include:
1. Object: A collection of properties, which can include functions (methods).
    Example: `let person = { name: "Alice", age: 30 };`
2. Array: A special type of object used to store ordered collections of values.
   Example: `let numbers = [1, 2, 3];`
*/
var number = 42; // var is function-scoped or globally scoped where let and const are block-scoped and no one using var anymore

let name = "Dhoni"; // let is block-scoped and can be reassigned
let score = 98;
let isGointToBeCentury = true; // boolean type
let player = null; // null type, explicitly set to no value
let team = undefined; // undefined type, variable declared but not assigned
const PlayersinTeam = 11; // const is block-scoped and cannot be reassigned, used for constants.
// Example of an object
let cricketPlayer = {
  name: "Dhoni",
  age: 41,
  isCaptain: true,
  scores: [50, 75, 100], // Array of scores
};
// Example of an array
let cricketScores = [50, 75, 100]; // Array of numbers

let updatedScore = score + 2; // we can reassign let variables
console.log("Updated Score:", updatedScore);
player = "Rohit Sharma"; // reassigning player variable
console.log(
  "Player Name:",
  name + " is out after scoring",
  updatedScore + " new batsman is coming in " + player
);
team = "India"; // reassigning team variable
console.log("Team:", team);
