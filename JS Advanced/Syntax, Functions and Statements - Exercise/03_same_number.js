function sameNumbers(number) {
    let isSame = true;
    let firstDigit = number % 10;
    let sum = 0;

    while (number >= 1) {
        sum += number%10;
        if (firstDigit !== number%10) {
            isSame = false;
        }
        number = parseInt(number/10);
   }

   console.log(isSame);
   console.log(sum);
}

sameNumbers(2222222);