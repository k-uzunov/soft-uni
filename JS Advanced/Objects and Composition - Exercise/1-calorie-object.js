function caloerieObject(inputArray){
    let calories = {}
    
    inputArray.forEach((element, index)=> {
        if(index % 2 == 1){
            calories[inputArray[index-1]] = Number(element);
        }
    });

    console.log(calories);
}

caloerieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
caloerieObject(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);