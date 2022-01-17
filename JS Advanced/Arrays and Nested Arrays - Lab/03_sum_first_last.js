function sumFirstLast(array){
    return Number(array.shift()) + Number(array.pop());
}

console.log(sumFirstLast(['20', '30', '40']));
console.log('==============================');
console.log(sumFirstLast(['5', '10']));