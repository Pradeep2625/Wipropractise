/*
    Polymorphism in JavaScript defines one onject or method to behave differently based on the context or the type of object it is called on.
    Polymorphism in JavaScript allows methods to be defined in a way that they can operate on different types of objects.
    1. It enables objects to be treated as instances of their parent class, allowing forEach method to be called on different objects that share the same interface.
    2. Polymorphism can be achieved through method overriding, where a subclass provides a specific implementation of a method that is already defined in its parent class.
    3. It allows for flexibility and extensibility in code, as new classes can be created that implement the same methods as existing classes without modifying the original code.
    4. Polymorphism promotes code reusability and maintainability by allowing developers to write generic code that can work with different types of objects.
*/
class Animal {
  constructor(name) {
    this.name = name;
  }

  speak() {
    throw new Error("Method 'speak()' must be implemented.");
  }
}
class Dog extends Animal {
  speak() {
    return `${this.name} barks`;
  }
}
class Cat extends Animal {
  speak() {
    return `${this.name} meows`;
  }
}
let dog = new Dog("Buddy");
let cat = new Cat("Whiskers");
console.log(dog.speak()); // Output: Buddy barks
console.log(cat.speak()); // Output: Whiskers meows
