function cookingByNumbers(number, op1, op2, op3, op4, op5){
    let operations = [op1, op2, op3, op4, op5];
    number = Number(number);
    for(let i = 0; i < 5; i++) {
        switch (operations[i]) {
            case 'chop':
                number /= 2;
                break;
            case 'dice':
                number = Math.sqrt(number);
                break;
            case 'spice':
                number++;
                break;
            case 'bake':
                number *= 3;
                break;
            case 'fillet':
                number-= number*0.2;
                break;
        }

        console.log(number);
    }
}

cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');