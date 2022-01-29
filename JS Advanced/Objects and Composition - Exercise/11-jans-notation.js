function jansNotation(array) {
    
    let numbers = [];

    let operators = {
        '*': (a, b) => a * b,
        '/': (a, b) => parseInt(a / b),
        '+': (a, b) => a + b,
        '-': (a, b) => a - b,
    }
    
    for (const element of array) {
        if (isNaN(element)) {
            if (numbers.length>=2) {
                let b = numbers.pop();
                let a = numbers.pop();
                let result = operators[element](a, b);
                numbers.push(result);

            }else{
                
                return console.log("Error: not enough operands!");
            }
        }else{
            numbers.push(element);
        }
    }

    if (numbers.length > 1) {
        console.log("Error: too many operands!")
    }else{
        console.log(numbers[0])
    }

}

//jansNotation([3, 4, '+']);
//jansNotation([5, 3, 4, '*', '-'])
jansNotation([5, 3, 4, '*', '/', '+'])