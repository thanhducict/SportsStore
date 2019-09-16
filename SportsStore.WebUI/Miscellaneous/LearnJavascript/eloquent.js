console.log("LOG FOR ELOQUENT JAVASCRIPT");
/* Chapter 2*/
// === Looping a triangle ===
// var sharp = "#";

// for (i = 0; i < 7; i++) {
//     console.log(sharp);
//     sharp += "#";
// }

// === FizzBuzz ===
// for (i = 1; i <= 100; i++) {
//     if ((i % 3 == 0) && (i % 5 == 0)) {
//         console.log("FizzBuzz");
//     }
//     else if (i % 5 == 0) {
//         console.log("Buzz");
//     }
//     else if (i % 3 == 0) {
//         console.log("Fizz");
//     }
//     else {
//         console.log(i);
//     }
// }

/* Chapter 3 */
// === Minimum ===
// var Minimum = function(num1, num2) {
//     return (num1 < num2) ? num1 : num2;
// };

// console.log(Minimum(3,5));

/* Chapter 4 */
// === The sum of a range ===
// function range(start, end, step) {
//     let array = [];

//     if ((step == undefined) || (step == 0)) {
//         step = 1;
//     }

//     if (step > 0) {
//         for (i = start; i <= end; i = i + step) {
//             array.push(i);
//         }
//     } else if (step < 0) {
//         for (i = start; i >= end; i = i + step) {
//             array.push(i);
//         }
//     }

//     return array;
// }

// function sum(array) {
//     let value = 0;
//     for (let element of array) {
//         value += element;
//     }
//     return value;
// }

// console.log(sum(range(1, 10)));

// === Reversing an array ===
// let sourceArray = [1, 2, 3, 4, 5];

// function reverseArray(array) {
//     let newArray = [];
//     for (i = array.length - 1; i >= 0; i--) {
//         newArray.push(array[i]);
//     }
//     return newArray;
// }

// console.log(reverseArray(sourceArray));

// let temp;
// function reverseArrayInPlace(array) {
//     for (i = 0; i < (Math.trunc(array.length / 2)); i++) {
//         temp = array[i];
//         array[i] = array[array.length - 1 - i];
//         array[array.length - 1 - i] = temp;
//     }
//     return array;
// }

// console.log(reverseArrayInPlace(sourceArray));

// === A list ===
// let list = {
//     value: 1,
//     rest: {
//         value: 2,
//         rest: {
//             value: 3,
//             rest: null
//         }
//     }
// };

// console.log(list.rest.rest.value);

// let secondList = {
//     value: 0,
//     rest: list
// };

// let thirdList = {
//     value: -1,
//     rest: list
// };

// console.log(secondList.value);
// console.log(secondList.rest.rest.value);

// let sourceArray = [1, 2, 3, 4, 5];

// function arrayToList(array) {
//     let list = null;
//     for (let i = array.length - 1; i >= 0; i--) {
//       list = {value: array[i], rest: list};
//     }
//     return list;
//   }

// console.log(arrayToList(sourceArray));

class Rabbit {
  constructor(type) {
    this.type = type;
  }
  speak(line) {
    console.log('The ${this.type} rabbit says "${line}"');
  }
}

// let killerRabbit = new Rabbit("killer");
// let blackRabbit = new Rabbit("black");

// Rabbit.prototype.teeth = "small";
// console.log(killerRabbit.teeth);
// console.log(Rabbit.prototype.teeth);
// // → small
// killerRabbit.teeth = "long, sharp, and bloody";
// console.log(killerRabbit.teeth);
// // → long, sharp, and bloody
// console.log(blackRabbit.teeth);
// // → small
// console.log(Rabbit.prototype.teeth);
// // → small

function Person(firstName, lastName) {
  this.firstName = firstName;
  this.lastName = lastName;
  this.showName = function() {
     console.log(this.firstName + ' ' + this.lastName);
  };
}

let person = new Person("shane", "peterson");

Person.prototype.test = "hu hu";

Object.prototype.test = "ha ha";
console.log(Object.prototype.test);
Person.prototype.test = "ma ma";

console.log(person.test);