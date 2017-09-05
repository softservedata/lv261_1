function print(data){
    document.write(`${data}<br>`);
}
let number = prompt('Enter your number!');
// task 243
function powerSumTwoNumberXY(number){
    let _x; let _y; let rezult = [];
    for ( _x = 1; _x < Math.sqrt(number); _x++) {
        _y = Math.sqrt(number - Math.pow(_x,2));
        let temp = Math.floor(_y);
        if(temp === _y)
            {
                rezult.push(_x + " " + _y);
            }
            else continue;  
    }
    return rezult;
}
// task 331
function powerSumThreeNumberXYZ(number) {
    let _x; let _y; let _z; let rezult = [];
    for (_x = 1; _x < Math.sqrt(number); _x++) {
        for (_y = 1; _y < Math.sqrt(number - Math.pow(_x,2)); _y++) {
            _z = Math.sqrt(number - Math.pow(_x,2) - Math.pow(_y,2));
            let temp = Math.floor(_z);
            if (_z === 0) 
                {
                    continue;
                }
            if (temp === _z)
                {
                    rezult.push(_x + " " + _y + " " + _z);
                }
            else continue;
        }
   }
   return rezult;
}
// Task 107
function maxLog(m) {
    let p; const POWER = 4;
    p = Math.log(m)/Math.log(POWER);
    let temp = Math.floor(p);
    if(p === temp)
        {
            p = p-1;
        }
    else
        {
            p = temp; 
        }
    return p;
}

print("Max number: " + maxLog(number));
print("X^2 + Y^2 = " + number + " : " + powerSumTwoNumberXY(number));
print("X^2 + Y^2 + Z^2 = " + number + " : " + powerSumThreeNumberXYZ(number));