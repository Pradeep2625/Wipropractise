let teaTypes = ["herbal tea", "white tea", "chai", "masala chai"];
let newTeaTypes = [];
for (let l = 0; l < teaTypes.length; l++) {
  if (teaTypes[l] != "chai") {
    newTeaTypes.push(teaTypes[l]);
  } else {
    break;
  }
}
console.log("breaking loop when tea == chai");

console.log(newTeaTypes);

let cities = ["London", "Tokyo", "Paris", "New York"];
let newCities = [];

for (let i = 0; i < cities.length; i++) {
  if (cities[i] != "Paris") {
    newCities.push(cities[i]);
  } else {
    continue;
  }
}
console.log('skip "paris"');
console.log(newCities);

//using for-of loop
let teamenu = ["herbal tea", "white tea", "chai", "masala chai"];
let updatedMenu = [];
for (const tea of teamenu) {
  if (tea === "masala chai") {
    break;
  }
  updatedMenu.push(tea);
}
console.log("using for-of loop");
console.log(updatedMenu);

//using for-in loop for objects
let worldCities = {
  Sydney: 5000000,
  Tokyo: 9000000,
  Berlin: 3500000,
  Paris: 200000,
};
let largeCities = {};
for (const cities in worldCities) {
  if (worldCities[cities] >= 3000000) {
    largeCities[cities] = worldCities[cities];
  }
}
console.log("cities with high population:");

console.log(largeCities);

//using for-each loop
let unTravelledCities = ["Tokyo", "Berlin", "Sydney", "Paris"];
let travelledCities = [];

unTravelledCities.forEach(function (cities) {
  if (cities == "Sydney") {
    return;
  }
  travelledCities.push(cities);
});
console.log("to skip sydney");

console.log(travelledCities);

//iterate through array and skip '7' and multiply remaining with 2

let numbers = [2, 5, 7, 9];
let newMultiplied = [];

for (let i = 0; i < numbers.length; i++) {
  if (numbers[i] == 7) {
    continue;
  }
  newMultiplied.push(numbers[i] * 2);
}
console.log("new multiplied array");
console.log(newMultiplied);

//write a program using for-of loop to skip the string in a array if string of a length greater than 10

let typesOfTeas = ["herbal tea", "white tea", "chai", "masala chai"];
let revisedTeas = [];

for (const Teas of typesOfTeas) {
  if (Teas.length >= 10) {
    continue;
  }
  revisedTeas.push(Teas);
}
console.log(revisedTeas);
var count = 0;

while (count < 10) {
  console.log(count);

  count++;
}  