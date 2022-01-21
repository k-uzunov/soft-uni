function magicMatrices(matrix){
    let isMagic = true;
    let sum = matrix[0].reduce((acc, currentValue) => acc + currentValue);
    for(let row = 0; row < matrix.length; row++){
        let rowSum = matrix[row].reduce((acc, currentValue) => acc + currentValue);
        let colSum = 0;
        for (let col = 0; col < matrix.length; col++) {
            colSum += matrix[col][row];
        }
        if (colSum != sum || rowSum != sum) {
            isMagic = false;
            break;
        }
    }
    console.log(isMagic);
}

magicMatrices([[4, 5, 6],
              [6, 5, 4],
              [5, 5, 5]]);

magicMatrices([[11, 32, 45],
               [21, 0, 1],
               [21, 1, 1]]);

magicMatrices([[1, 0, 0],
               [0, 0, 1],
               [0, 1, 0]]);