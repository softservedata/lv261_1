function setValueToTxb(f, controlId, n, m)
{
    let result;
    if(m === undefined){
        result = f(n);
        if(result.length === 0){
            document.getElementById(controlId).value = 
            "Немає жодного простого числа Мерсенна від 0 до " + n;
        }
        else{
            document.getElementById(controlId).value = result;
        }
    }
    else{
        result = f(n, m);
        if(result === -1 || result.length === 0){
            document.getElementById(controlId).value = "Введені некоректні дані";
            document.getElementById(controlId).className ="error";
        }
        else{
            document.getElementById(controlId).removeAttribute("class");
            document.getElementById(controlId).value = result;
        }
    }
    
}

function GetSum_87(n, m) {
    if(n !== null && n !== undefined && m !== null && m !== undefined){
        if (!(isNaN(+n)) && !(isNaN(+m))) {
            if(parseInt(n) > 0 && parseInt(m) > 0){

                if (n.length < m) {
                    return -1;
                }

                let result = 0;

                for(let i = 0; i < m; i++){
                    result += parseInt(n[n.length - (1 + i)])
                }

                return parseInt(result);
            }
        }
    }
    return -1;
}

function GetAllCommonDivisors_226(n, m)
{
    let commonDividers = [];
    if(n !== null && n !== undefined && m !== null && m !== undefined){
        if (!(isNaN(+n)) && !(isNaN(+m))) {
            if(parseInt(n) > 0 && parseInt(m) > 0){
                n = parseInt(n);
                m = parseInt(m);
                let biggerNumber = m > n ? m : n;
                let smallerNumber = m > n ? n : m;
                let b = biggerNumber;
                let i = 0;
                do {
                    if (b % smallerNumber == 0) {
                        commonDividers[i] = b;
                        i++;
                    }
                    b += biggerNumber;
                }
                while (m * n > b);
            }
        }
    }
    return commonDividers;
}

function GetPrimeMersonNumbers_559(n)
{
    let mersonNumbers = [];
    if(n !== null && n !== undefined){
        if (!(isNaN(+n))) {
            if(parseInt(n) > 0){
                n = parseInt(n);
                let primeNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 ];
                let mersonNumber;
                let mi = 0;
                for(let i = 0; i < primeNumbers.length; i++)
                {
                    mersonNumber = Math.pow(2, primeNumbers[i]) - 1;
                    console.log(mersonNumber);
                    if (mersonNumber < n) {
                        if (IsSimple(mersonNumber)) {
                            mersonNumbers[mi] = mersonNumber;
                            mi++;
                        }
                    }
                }
            }
        }
    }
    return mersonNumbers;
}


function IsSimple(number)
{
    let tf = false;
    if(number !== null && number !== undefined){
        if (!(isNaN(+number))) {
            if(parseInt(number) > 0){
                if (number === 2 || number === 3 || number === 5) {
                    return true;
                }
                for (let i = 2; i < parseInt(number / 2); i++)
                {
                    if (number % i == 0) {
                        tf = false;
                        break;
                    }
                    else {
                        tf = true;
                    }
                }
            }
        }
    }
    return tf;
}
