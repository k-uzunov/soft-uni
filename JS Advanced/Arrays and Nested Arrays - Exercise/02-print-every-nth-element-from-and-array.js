function printElements(array, n){
    let resultArray = [];
    for(let i = 0; i < array.length; i+=n){
        resultArray.push(array[i]);
    }

    return resultArray;
}

console.log(printElements(['5', '20', '31', '4', '20'], 2));
console.log(printElements(['dsa','asd', 'test', 'tset'], 2));
console.log(printElements(['1', '2','3', '4', '5'], 6));