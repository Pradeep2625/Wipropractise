/* 
1. Declare an array named `teaFlavors` that contains the strings `"green tea"`, `"black tea"`, and `"oolong tea"`. 
   Access the first element of the array and store it in a variable named `firstTea`.
*/
let teaFlavors = ["green tea", "black tea", "oolong tea", 12];
let reversearr = [];
teaFlavors.reduce
// let firstTea = teaFlavors[0];
teaFlavors.reverse();
console.log(teaFlavors);
for (let i = 0; i < teaFlavors.length; i++) {
  if (teaFlavors[i] ==  teaFlavors[i+1]) {
    teaFlavors
    return newarr;
  }
}

console.log(newarr);

/* 
2. Declare an array named `cities` containing `"London"`, `"Tokyo"`, `"Paris"`, and `"New York"`. 
   Access the third element in the array and store it in a variable named `favoriteCity`.
*/
let cities = ["London", "Tokyo", "Paris", "New York"];
let favoriteCity = cities[2];
console.log(favoriteCity);

/* 
3. You have an array named `teaTypes` containing `"herbal tea"`, `"white tea"`, and `"masala chai"`. 
   Change the second element of the array to `"jasmine tea"`.
*/
let teaTypes = ["herbal tea", "white tea", "masala chai"];
teaTypes[1] = "jasmine tea"; // Changing the second element
console.log(teaTypes);

/* 
4. Declare an array named `citiesVisited` containing `"Mumbai"` and `"Sydney"`. 
   Add `"Berlin"` to the array using the `push` method.
*/
let citiesVisited = ["Mumbai", "Sydney"];
citiesVisited.push("Berlin"); // Adding "Berlin" to the array
console.log(citiesVisited);

/* 
5. You have an array named `teaOrders` with `"chai"`, `"iced tea"`, `"matcha"`, and `"earl grey"`. 
   Remove the last element of the array using the `pop` method and store it in a variable named `lastOrder`.
*/
let teaOrders = ["chai", "iced tea", "matcha", "earl grey"];
let lastOrdered = teaOrders.pop();
console.log(lastOrdered);

/* 
6. You have an array named `popularTeas` containing `"green tea"`, `"oolong tea"`, and `"chai"`. 
   Create a soft copy of this array named `softCopyTeas`.
*/
let popularTeas = ["green tea", "oolong tea", "chai"];
//softCopy means that if we change the original array, the soft copy will also change.
// However, if we change the soft copy, the original array will not change.
let softCopyTeas = popularTeas;
popularTeas.pop();
console.log(softCopyTeas);

/*
7. You have an array named `topCities` containing `"Berlin"`, `"Singapore"`, and `"New York"`. 
   Create a hard copy of this array named `hardCopyCities`.
*/
let topCities = ["Berlin", "Singapore", "New York"];
// Hard copy means that if we change the original array, the hard copy will not change.
// However, if we change the hard copy, the original array will also change.
let hardCopyCities1 = [topCities[0], topCities[1], topCities[2]];
// or using spread operator
let hardCopyCities2 = [...topCities];
// console.log(hardCopyCities);

/* 
8. You have two arrays: `europeanCities` containing `"Paris"` and `"Rome"`, and `asianCities` containing `"Tokyo"` and `"Bangkok"`. 
   Merge these two arrays into a new array named `worldCities`.
*/
let europeanCities = ["paris", "Rome"];
let asianCities = ["Tokyo", "Bangkok"];
let worldCities = europeanCities.concat(asianCities);
console.log(worldCities);

/* 
9. You have an array named `teaMenu` containing `"masala chai"`, `"oolong tea"`, `"green tea"`, and `"earl grey"`. 
   Find the length of the array and store it in a variable named `menuLength`.
*/
let teaMenu = ["masala chai", "oolong tea", "green tea", "earl grey"];
let menuLength = teaMenu.length;
console.log("no items in menu " + menuLength);

/* 
10. You have an array named `cityBucketList` containing `"Kyoto"`, `"London"`, `"Cape Town"`, and `"Vancouver"`. 
    Check if `"London"` is in the array and store the result in a variable named `isLondonInList`.
*/

let cityBucketList = ["kyoto", "London", "cape town", "vancouver"];
let isLondonInList = cityBucketList.includes("London");
console.log(isLondonInList);
