function biggerHalf(numbers){
    let halfIndex = parseInt(numbers.length/2);
    numbers = numbers.sort((a, b) => a - b);
    let half = numbers.slice(halfIndex);
    return half;
}

console.log(biggerHalf([4, 7, 2, 5]));
console.log('==================================');
console.log(biggerHalf([3, 19, 14, 7, 2, 19, 6]));