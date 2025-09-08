/*
    Encapsulation in JavaScript is a fundamental concept of object-oriented programming that restricts direct access to an object's properties and methods. 
    This is typically achieved using closures or the module pattern, allowing for private variables and methods.
    1. Encapsulation helps in bundling the data (properties) and methods (functions) that operate on the data into a single unit, known as an object.
    2. It restricts access to certain components of an object, preventing external code from modifying the internal state of the object directly.
    3. Encapsulation promotes data hiding, which enhances security and reduces the risk of unintended interference with an object's state.
    4. It allows for controlled access to an object's properties and methods through public interfaces, enabling better maintainability and flexibility in code design.
*/
class Banking {
    #balance = 0; // Private property using the # syntax
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

let myBankAccount = new Banking();
myBankAccount.Deposit(1000); // Deposited: 1000. New Balance
// myBankAccount.#balance; // This line would throw an error because #balance is private
myBankAccount.Withdraw(200); // Withdrew: 500. New Balance:
console.log(`Current Balance: ${myBankAccount.GetBalance()}`); // Current Balance: 500
// myBankAccount.Withdraw(600); // This line would throw an error because of insufficient balance
// myBankAccount.Deposit(-100); // This line would throw an error because deposit amount must be positive
// myBankAccount.GetBalance(); // This line would throw an error because #balance is private