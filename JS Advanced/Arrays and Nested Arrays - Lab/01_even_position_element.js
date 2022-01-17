function evenPositionElement(array){
    let resultArray = [];
    for(let i = 0; i < array.length; i++){
        if(i % 2 == 0){
            resultArray.push(array[i]);
        }
    }
    console.log(resultArray.join(' '));
}

evenPositionElement(['20', '30', '40', '50', '60']);
console.log('====================================');
evenPositionElement(['5', '10']);