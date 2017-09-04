function print(data){
    document.write(`${data}<br>`);
}
let number = prompt();
let rez = [];
function getMeXY(number){
    let _x; let _y;
    for ( _x = 1; _x < Math.sqrt(number); _x++) {
        _y = Math.sqrt(number - Math.pow(_x,2));
        let temp = Math.floor(_y);
        if(temp === _y)
            {
                rez.push(_x + " " + _y);
            }
            else continue;  
    }
    return rez;
}
function getMeXYZ(number) {
    let _x; let _y; let _z;
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
                    rez.push(_x + " " + _y + " " + _z);
                }
            else continue;
        }
   }
   return rez;
}
function getPowerLog(m) {
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
print(getPowerLog(number));