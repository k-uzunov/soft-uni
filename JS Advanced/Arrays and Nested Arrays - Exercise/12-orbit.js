function orbit(input){
    let width = input[0];
    let height = input[1];
    let starX = input[2];
    let starY = input[3];

    let space = [];
    for(let i = 0; i < height; i++){
        space.push([]);
    }

    space[starX][starY] = 1;
    for(let x = 0; x < height; x++){
        for(let y = 0; y < width; y++){
            space[x][y] = Math.max(Math.abs(starX - x), Math.abs(starY-y))+1;
        }
    }

    for (const iterator of space) {
        console.log(iterator.join(' '));
    }
}

orbit([4, 4, 0, 0]);
orbit([5, 5, 2, 2]);
orbit([3, 3, 2, 2]);