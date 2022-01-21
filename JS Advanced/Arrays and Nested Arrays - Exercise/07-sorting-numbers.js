function sortingNumbers(numbers){
    numbers.sort((a, b) =>a-b);
    for(let i = 1; i < numbers.length; i+=2){
        let temp = numbers.pop();
        numbers.splice(i,0,temp);
    }
    return numbers
}

console.log(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));