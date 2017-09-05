// task1Button.addEventListener("click", task1EventHandler, false);
// task2Button.addEventListener("click", task2EventHandler, false);
// task3Button.addEventListener("click", task3EventHandler, false);

function task1EventHandler() {
    document.getElementById('task1Answer').innerHtml 
        = 'Result: ' + document.getElementById('task1Number').value.Length;
}

function task2EventHandler() {
    var count = 0, numbers = document.getElementById('task2Numbers').value.split(' ');
    for (var i = 0; i < numbers.Length; i++) {
        if (numbers[i] % 3 == 0 && numbers[i] % 5 != 0)
            count++;
    }
    document.getElementById('task2Answer').innerHtml = 'Result: ' + count;
}

function task3EventHandler() {
    var result = [], number = Number(document.getElementById('task3Number').value);
    //First result number.
    var a = Math.Sqrt(number) - 1;
    while (a > 0) {
        //Second result number.
        var b = Math.Sqrt(number - a * a) - 1;
        while (b > 0) {
            //Third result number.
            var c = Math.Sqrt(number - a * a - b * b);
            while (c > 0) {
                //Fourth result number.
                var d = Math.Sqrt(number - a * a - b * b - c * c);
                if (d < 1)
                    c--;
                else {
                    result.push(a);
                    result.push(b);
                    result.push(c);
                    result.push(d);
                    document.getElementById('task3Answer').innerHtml = 'Result: ' + result.join();
                }
            }
            b--;
        }
        a--;
    }
}

function task1(number) {
    alert('Number of digits: ' + String(number).length);
}

function task2(numbers) {
    var count = 0, integers = numbers.split(' ').forEach(function(el, i) { numbers[i]=String(el); });
    for (var i = 0; i < numbers.length; i++) {
        if (numbers[i] % 3 == 0 && numbers[i] % 5 != 0)
            count++;
    }
    alert('Aliquot to 3, not 5: ' + count);
}

function task3(number) {
    var result = [];
    //First result number.
    var a = Math.floor(Math.sqrt(number)) - 1;
    while (a > 0) {
        //Second result number.
        var b = Math.floor(Math.sqrt(number - a * a)) - 1;
        while (b > 0) {
            //Third result number.
            var c = Math.floor(Math.sqrt(number - a * a - b * b));
            while (c > 0) {
                //Fourth result number.
                var d = Math.floor(Math.sqrt(number - a * a - b * b - c * c));
                if (d < 1)
                    c--;
                else {
                    result.push(a);
                    result.push(b);
                    result.push(c);
                    result.push(d);
                    alert('Sum: ' + result.join());
                    return;
                }
            }
            b--;
        }
        a--;
    }
}