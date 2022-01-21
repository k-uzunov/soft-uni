function increasingSubset(array){
    let subset = [];
    subset = array.reduce((accumulator, currentValue, currentIndex)=>{
        if (currentIndex == 0){
            accumulator.push(currentValue)
        }else if (accumulator[accumulator.length-1] <= currentValue) {
            accumulator.push(currentValue)
        }
        return accumulator;
    }, []);
    return subset
}

console.log(increasingSubset([1, 3, 8, 4, 10, 12, 3, 2, 24]));
console.log(increasingSubset([1, 2, 3,4]));
console.log(increasingSubset([20, 3, 2, 15,6, 1]));
console.log(increasingSubset(['20', '3', '2', '15', '6', '1']));
console.log(increasingSubset([1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]));
