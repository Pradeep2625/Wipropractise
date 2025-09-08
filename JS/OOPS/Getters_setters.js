/*
    Getters and Setters in JavaScript
    Getters and setters are special methods that allow you to define how properties of an object are accessed and modified.
    1. Getters are used to retrieve the value of a property, while setters are used to set or update the value of a property.
    2. They provide a way to control access to an object's properties, allowing for validation or transformation of data before it is set or retrieved.
    3. Getters and setters can be defined using the `get` and `set` keywords, respectively.
    4. They can be used to create computed properties, where the value is derived from other properties or methods of the object.

*/
class ATM{
    #balance;
    constructor(initialBalance) {
        this.#balance = initialBalance; // Private property using the # syntax
    }
    // Getter for balance
    get balance() {
        return this.#balance; // Accessing private property
    }
    // Setter for balance
    set balance
    (amount) {
        if (amount >= 0) {
            this.#balance = amount; // Accessing private property
        } else {
            console.log("Balance cannot be negative.");
        }
    }
    Deposit(amount) {
        if (amount > 0) {
            this.#balance += amount; // Accessing private property
            console.log(`Deposited: ${amount}. New Balance: ${this.#balance}`);
        } else {
            console.log("Deposit amount must be positive.");
        }
    }
    Withdraw(amount) {
if (amount > 0 && amount <= this.#balance) {
this.#balance -= amount; // Accessing private property
            console.log(`Withdrew: ${amount}. New Balance: ${this.#balance}`);
        } else {
            console.log("Insufficient balance or invalid withdrawal amount.");
        }
    }
    GetBalance() {
        return this.#balance; // Accessing private property
    }
}
let myATM = new ATM(1000);
myATM.Deposit(500); // Deposited: 500. New Balance: 1500
myATM.Withdraw(200); // Withdrew: 200. New Balance: 1300
console.log(`Current Balance: ${myATM.GetBalance()}`); // Current Balance: 1300
myATM.balance = 2000; // Setting balance using setter
console.log(`Updated Balance: ${myATM.balance}`); // Updated Balance: 2000