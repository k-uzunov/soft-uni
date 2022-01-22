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
    console.log(firstDiagonalSum);
    console.log(secondDiagonalSum);
}

diagonaAttack(['1 1 1','1 1 1','1 1 0']);