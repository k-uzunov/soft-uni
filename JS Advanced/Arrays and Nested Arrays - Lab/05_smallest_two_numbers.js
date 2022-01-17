function smallestTwoNumbers(numbers){
    numbers = numbers.sort((a, b) => a - b);
    let smallestNumbers = numbers.slice(0, 2);
    console.log(smallestNumbers.join(' '));
}

smallestTwoNumbers([1, 12, 35, 12, 15, 18, 3]);
console.log('===============================');
smallestTwoNumbers([3, 0, 10, 4, 7, 3]);