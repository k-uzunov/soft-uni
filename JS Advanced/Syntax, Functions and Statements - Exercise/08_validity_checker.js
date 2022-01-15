function validityChecker(x1, y1, x2, y2){
    function pythagorean(a, b){
        return Math.sqrt((a**2) + (b**2));
    }

    if (parseInt(pythagorean(x1, y1)) === pythagorean(x1, y1)) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }

    if (parseInt(pythagorean(x2, y2)) === pythagorean(x2, y2)) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    if (parseInt(pythagorean(Math.abs(x1 - x2), Math.abs(y1 - y2))) === pythagorean(Math.abs(x1 - x2), Math.abs(y1 - y2))) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}

validityChecker(3, 0, 0, 4);
validityChecker(2, 1, 1, 1)