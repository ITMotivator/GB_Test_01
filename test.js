"use strict";

let arrayInitial = ['Russia', 'Denmark', 'UAE', 'Germany', 'USA', 'UK'],
    arrayResulted = [];

for (let i = 0; i < arrayInitial.length; i++) {
    if (arrayInitial[i].length <= 3) {
        arrayResulted.push(arrayInitial[i]);
    }
}

console.log(arrayResulted);
