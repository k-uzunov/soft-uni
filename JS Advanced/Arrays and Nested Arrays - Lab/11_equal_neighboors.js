function equalNeighboors(matrix){
    let equalPairs = 0;

    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col<matrix[row].length; col++){
            if (matrix[row][col] === matrix[row][col+1]) {
                equalPairs++;
            }
            if (row != (matrix.length)-1) {
                if (matrix[row][col] === matrix[row+1][col]) {
                    equalPairs++;
                }
            };
        }
    }

    //console.log(equalPairs);
    return equalPairs;
}

equalNeighboors([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]);

equalNeighboors([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]);

equalNeighboors([['1', '0', '0', '1'],
                 ['1', '1', '0', '0'],
                 ['1', '1', '0', '1']]);