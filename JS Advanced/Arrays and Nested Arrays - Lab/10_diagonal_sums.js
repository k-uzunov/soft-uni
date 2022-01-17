function diagonalSums(matrix){
    let mainSum = 0;
    let secSum = 0;

    for(let index = 0; index < matrix.length; index++){
        mainSum += matrix[index][index];
        secSum += matrix[index][(matrix.length-1)-index]
    }

    console.log(mainSum + ' ' + secSum);
}

diagonalSums([[20, 40], 
              [10, 60]]);
console.log('===================');
diagonalSums([[3, 5, 17],
              [-1, 7, 14],
              [1, -8, 89]]);