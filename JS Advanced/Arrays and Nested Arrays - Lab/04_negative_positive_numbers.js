function negativePositiveNumbers(array){
    let resultArray = [];

    for(let i = 0; i < array.length; i++){
        if (array[i] < 0) {
            resultArray.unshift(array[i]);
        }else{
            resultArray.push(array[i]);
        }
    }
    console.log(resultArray.join('\n'));
}

negativePositiveNumbers([7, -2, 8, 9]);
console.log('=======================');
negativePositiveNumbers([3, -2, 0, -1]);