function diagonaAttack(matrix){
    let numbersMatrix = matrix.reduce((reducedArr, currentArr) =>{
        let temp = currentArr.split(" ").map(Number);
        reducedArr.push(temp);
        return reducedArr;
    },[])
    
    let firstDiagonalSum = 0;
    let secondDiagonalSum = 0;

    for(let index = 0; index < numbersMatrix.length; index++){
            firstDiagonalSum += numbersMatrix[index][index];
            secondDiagonalSum += numbersMatrix[index][(numbersMatrix.length-1)-index];
    }

    if (firstDiagonalSum == secondDiagonalSum) {

        let fDiagonal = 0;
        let sDiagonal = numbersMatrix.length-1;
        for (let rows = 0; rows < numbersMatrix.length; rows++) {
            for (let cols = 0; cols < numbersMatrix.length; cols++) {
                if (cols != fDiagonal && cols != sDiagonal) {
                    numbersMatrix[rows][cols] = firstDiagonalSum;
                }
            }
            fDiagonal++;
            sDiagonal--;
        }
    }

    for (const row of numbersMatrix) {
        console.log(row.join(' '));
    }
}

diagonaAttack(['1 1 1','1 1 1','1 1 0']);
//diagonaAttack(['5 3 12 3 1','11 4 23 2 5','101 12 3 21 10','1 4 5 2 2','5 22 33 11 1'])