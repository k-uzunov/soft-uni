function rotateArray(array, rotations){
    let numOfRotations;
    if (parseInt(rotations / array.length) >=1) {
        numOfRotations = parseInt(rotations / array.length);
        for(let i = 0; i < numOfRotations; i++){
            let temp = array.pop();
            array.unshift(temp);
        }   
    }else{
        for(let i = 0; i < rotations; i++){
            let temp = array.pop();
            array.unshift(temp);
        }   
    }

    console.log(array.join(" "));
}

rotateArray(['1', '2', '3', '4'], 2);
rotateArray(['Banana', 'Orange', 'Coconut', 'Apple'], 15);