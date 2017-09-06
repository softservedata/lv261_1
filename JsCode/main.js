function algorithmFirst( n ) {
    let q = 1;
    let numbers = [];

    while ( n >= Math.pow(q, 2) ) {

        if ( n % Math.pow(q, 2) == 0 && n % Math.pow(q, 3) != 0 ) {
            numbers.push( q );
        }

        ++q;
    }

    return numbers;
}

let algorithmFirstOutput = document.getElementById( 'algorithmFirstOutput' );
algorithmFirstOutput.innerHTML = algorithmFirst( 64 );


function algorithmSecond( data ) {
    let q = 1;
    let numbers = [];

    while ( data.n > q ) {
        let s = 0;
        let temp = q;

        while ( Math.floor( temp / 10 ) != 0 ) {
            s += temp % 10;
            temp = Math.floor( temp / 10 );
        }

        s += temp;

        if ( Math.pow(s, 2) == data.m ) {
            numbers.push( q );
        }

        ++q;
    }

    return numbers;
}

let algorithmSecondOutput = document.getElementById( 'algorithmSecondOutput' );
algorithmSecondOutput.innerHTML = algorithmSecond({ m: 4, n: 64 }); 

function algorithmThird( ) {
    const n = 999;
    let q = 10;
    let numbers = [];

    while ( q <= n ) {
        let temp = q;
        let chysla = [];

        while ( Math.floor( temp / 10 ) != 0 ) {
            chysla.push( temp % 10 );
            temp = Math.floor( temp / 10 );
        }

        chysla.push( temp );
        temp = 0;

        chysla.forEach(function(chyslo) {
            temp += Math.pow( chyslo, chysla.length );
        });

        if ( temp == q ) {
            numbers.push( q );
        }

        ++q;
    }

    return numbers;
}

let algorithmThirdOutput = document.getElementById( 'algorithmThirdOutput' );
algorithmThirdOutput.innerHTML = algorithmThird(); 

