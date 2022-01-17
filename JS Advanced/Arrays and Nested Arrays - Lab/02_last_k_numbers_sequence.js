function lastKNumbersSequence(n, k){
    let array = [1];

    for(let i = 1; i < n; i++){
        let sliceStart = function(a,b){
            if(a-b < 0) return 0; 
            else return a-b}
        let newArray = array.slice(sliceStart(i,k), i);
        array[i] = newArray.reduce((acc, currVal) => acc + currVal);
        //console.log(newArray);
        
    }
    return array;
}

console.log(lastKNumbersSequence(6, 3));
console.log('====================================');
console.log(lastKNumbersSequence(8, 2));