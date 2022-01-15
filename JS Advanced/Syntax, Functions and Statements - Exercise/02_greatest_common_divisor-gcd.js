function greatestCommonDivisor(num1, num2) {
    let gcd = 0;
    for (let index = 1; index <=num1 && index<=num2 ; index++) {
        if(num1 % index == 0 && num2 % index == 0){
            if(index > gcd) gcd = index;
        }
    }

    console.log(gcd);
}

greatestCommonDivisor(2154, 458);