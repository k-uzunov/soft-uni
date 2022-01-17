function pieceOfPie(pieFlavors, flavor1, flavor2){
    let start = pieFlavors.indexOf(flavor1);
    let end = pieFlavors.indexOf(flavor2)+1;
    let selectedFalvors = pieFlavors.slice(start, end);
    return selectedFalvors;
}

console.log(pieceOfPie(['Pumpkin Pie', 'Key Lime Pie', 'Cherry Pie', 'Lemon Meringue Pie', 'Sugar Cream Pie'],
    'Key Lime Pie', 'Lemon Meringue Pie'));
console.log('======================================================================================================');
console.log(pieceOfPie(['Apple Crisp', 'Mississippi Mud Pie', 'Pot Pie', 'Steak and Cheese Pie', 'Butter Chicken Pie',
    'Smoked Fish Pie'], 'Pot Pie', 'Smoked Fish Pie'));