//Task 224
function findDividers(number) {
    let dividers = [];
    let i = 1;
    while (i * i < number) {
        if (number % i === 0) {
            dividers.push(i);
            dividers.push(number / i);

        }
        i++;
    }
    if (i * i === number) {
        dividers.push(i)
    }
    dividers.sort((a, b) => a - b);
    return dividers;
}

//Task 325
function isPrime(number) {
    for (let i = 2; i * i <= number; i++) {
        if (number % i === 0) {
            return false;
        }
    }
    return true;
}

function findPrimeDividers(number) {
    let primeDividers = findDividers(number).filter(isPrime);
    return primeDividers;
}

//Task 561
function findMagicNumbers(number) {
    let magicNumbers = [];
    for (let i = 1; i < number; i++) {
        let countOfDijits = i.toString().length;
        if ((i * i - i) % Math.pow(10, countOfDijits) === 0) {
            magicNumbers.push(i);
        }
    }
    return magicNumbers;
}

function task1() {
    let number = document.getElementById("number").value;
    let result = arrayToString(findDividers(number));
    print("Dividers of " + number + " are : " + result);
}

function task2() {
    let number = document.getElementById("number").value;
    let result = arrayToString(findPrimeDividers(number));
    print("Prime dividers of " + number + " are : " + result);
}

function task3() {
    let number = document.getElementById("number").value;
    let result = arrayToString(findMagicNumbers(number));
    print("Magic numbers between 1 and " + number + " are : " + result);
}

function arrayToString(array) {
    return array.reduce(
        (previouse, current) => previouse + ", " + current);
}

function print(data) {
    document.getElementById("result").innerHTML = data;
}