/*
    Abstraction in JavaScript is a way to hide the complex implementation details and show only the essential features of an object.
    1. It allows developers to focus on the high-level functionality of an object without needing to understand the intricate details of how it works.
    2. Abstraction can be achieved through the use of classes, interfaces, or abstract  methods.
    3. It helps in reducing complexity and increasing the efficiency of code by providing a clear interface for interaction with objects.
    4. Abstraction promotes code reusability and maintainability by allowing developers to create objects that encapsulate specific behaviors  
    and properties while hiding the underlying implementation.
*/
class Vehicle {
    constructor(brand, model) {
        this.brand = brand;
        this.model = model;
    }

    // Abstract method to be implemented by subclasses
    start() {
        throw new Error("Method 'start()' must be implemented.");
    }

    getDetails() {
        return `Brand: ${this.brand}, Model: ${this.model}`;
    }

}
class Car extends Vehicle {
    constructor(brand, model, type) {
        super(brand, model); // Call the parent class constructor 
        this.type = type;
    }
// Implementing the abstract method
    start() {
        return `Starting the car: ${this.getDetails()}, Type: ${this.type}`;
    }
}
class Bike extends Vehicle {
    constructor(brand, model, engineCapacity) {
        super(brand, model); // Call the parent class constructor   
        this.engineCapacity = engineCapacity;
    }
// Implementing the abstract method
    start() {
        return `Starting the bike: ${this.getDetails()}, Engine Capacity: ${this.engineCapacity}cc`;
    }
}
let car1 = new Car("Toyota", "Camry", "Sedan");
let bike1 = new Bike("Yamaha", "R15", 155);
console.log(car1.start()); // Output: Starting the car: Brand: Toyota, Model:
console.log(bike1.start()); // Output: Starting the bike: Brand: Yamaha, Model: R15, Engine Capacity: 155cc
console.log(car1.getDetails()); // Output: Brand: Toyota, Model: Camry
console.log(bike1.getDetails()); // Output: Brand: Yamaha, Model: R15