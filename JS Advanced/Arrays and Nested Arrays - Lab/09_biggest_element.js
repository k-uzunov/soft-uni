function biggestElement(matrix){
    let flatArray = matrix.flat();
    return Math.max(...flatArray);
}

console.log(biggestElement([[20, 50, 10], [8, 33, 145]]));