function solve(numbers) {
    let sum = numbers.reduce(function (previousValue, currentValue) {
        return previousValue + currentValue;
    }, 0);
    console.log(sum);
    let inverseSum = numbers.reduce(function (previousValue, currentValue) {
        return previousValue + (1 / currentValue);
    }, 0);
    console.log(inverseSum);

    let concat = '';
    for (let index = 0; index < numbers.length; index++) {
        concat += numbers[index];
    }
    console.log(concat)
}

solve([1, 2, 3]);