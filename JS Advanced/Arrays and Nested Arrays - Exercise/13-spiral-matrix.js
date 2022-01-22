function spiralMatrix(rows, cols){
    let matrix = [];
    for (let index = 0; index < rows; index++) {
        matrix.push([]);
    }

    let number = 1;
    let lastCol = cols-1;
    let lastRow = rows-1;
    let firstCol = 0;
    let firstRow = 0;
    let startIndexHor = 0;
    let startIndexVert = 1;
    let end = rows*cols
    while(number <=end){
        for(let i = startIndexHor; i <=lastCol && number <= end; i++){
            matrix[firstRow][i] = number++;
        }
        firstRow++;
        startIndexVert = firstRow;
        for(let i = startIndexVert; i <= lastRow && number <= end; i++){
            matrix[i][lastCol] = number++;
        }
        lastCol--
        startIndexHor = lastCol;
        for(let i = startIndexHor; i >= firstCol && number <= end; i--){
            matrix[lastRow][i] = number++;
        }
        lastRow--;
        startIndexVert = lastRow;
        for(let i = startIndexVert; i >= firstRow && number <= end; i--){
            matrix[i][firstCol] = number++;
        };
        firstCol++;
        startIndexHor = firstCol;
    }  
    for (const iterator of matrix) {
        console.log(iterator.join(" "));
    }
}
spiralMatrix(5, 5);
spiralMatrix(3, 3);
spiralMatrix(3, 5);