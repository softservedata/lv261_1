
let taskText1 = 'Дано натуральное число n. Поменять порядок цифр числа n на обратный.';
let taskText2 = 'Даны натуральные числа m и n. Найти такие натуральные p и q, не имеющие общих делителей,что p/q = m/n.';
let taskText3 = `Натуральное число называется совершенным, если оно
равно сумме всех своих делителей, за исключением себя самого. Число
6 – совершенное, так как 6 = 1+2+3. Число 8 – не совершенное, так как
8 ≠ 1+2+4.Дано натуральное число n. Получить все совершенные числа,
меньшие n.`

function $(data) {
    return document.getElementById(data);
}

let taskNumber = $('tasknumber');
let taskText = $('tasktext');
let button1 = $('task1');
let button2 = $('task2');
let button3 = $('task3');
let buttonStart = $('startButton');

let currentTask = 1;

changeTask();

button1.onclick = function () {
    currentTask = 1;
    changeTask();
}
button2.onclick = function () {
    currentTask = 2;
    changeTask();
}
button3.onclick = function () {
    currentTask = 3;
    changeTask();
}

buttonStart.onclick = function () { doTask() }

function changeTask() {
    taskNumber.innerText = currentTask;
    switch (currentTask) {
        case 1: taskText.innerText = taskText1;
            break;
        case 2: taskText.innerText = taskText2;
            break;
        case 3: taskText.innerText = taskText3;
            break;
        default:
            break;

    }

}
function doTask() {
    switch (currentTask) {
        case 1: task1();
            break;
        case 2: task2();
            break;
        case 3: task3();
            break;
        default:
            break;

    }
}

function task1() {

    let number = prompt('Enter the number');
    if (isNumber(number)) {
        let result = number.split('').reverse().join('');
        alert(`result: ${result}`);
    }
}
function task2() {

    let numberM = prompt('Enter first number');
    if (!isNumber(numberM)) return;

    let numberN = prompt('Enter second number');
    if (!isNumber(numberN)) return;

    let numerator = numberM;
    let denominator = numberN;

    let remainderAfterDividing = 1;
    let greatestCommonDivisor = 1;
    do {
        remainderAfterDividing = numerator % denominator;
        if (remainderAfterDividing == 0) {
            greatestCommonDivisor = denominator;

        }
        numerator = denominator;
        denominator = remainderAfterDividing;

    }
    while (remainderAfterDividing != 0);

    let result1 = numberM / greatestCommonDivisor;
    let result2 = numberN / greatestCommonDivisor;
    alert(`result: ${result1}/${result2}`);
}
function task3() {

    let number = prompt('Enter the number');
    if (isNumber(number)) {

        let perfectNumbers = [];
        let sum;
        for (let i = 6; i < number; i++) {
            sum = 0;
            if (i % 2 == 0) {
                for (let j = 1; j < i; j++) {
                    if (i % j == 0)
                        sum += j;
                }
            }
            if (sum == i)
                perfectNumbers.push(i);
        }
        alert(`result: ${perfectNumbers}`);
    }

}
function isNumber(data) {
    if (isNaN(data)) {
        alert('You entered incorrect number. Please try again');
        return false;
    }
    else {
        return true;
    }
}
