function processOddPositions(numbers){
    let oddPositionElements = [];
    for(let i = 1; i < numbers.length; i += 2){
        oddPositionElements.unshift(numbers[i]*2);
    }
    return console.log(oddPositionElements.join(' '));
}

processOddPositions([10, 15, 20, 25]);
console.log('======================');
processOddPositions([3, 0, 10, 4, 7, 3]);