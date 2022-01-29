function storeCatalogue(inputArr){
    let catalogue = {};

    for (const element of inputArr) {
        let [item, price] = element.split(' : ');
        price = Number(price);

        let firstLetter = item[0];
        if(!catalogue[firstLetter]){
            catalogue[firstLetter] = {};
        }

        catalogue[firstLetter][item] = price;
    }

    let sortedKeys = Object.keys(catalogue).sort();

    for (const key of sortedKeys) {
        console.log(key);
        let sortedItems = Object.entries(catalogue[key]).sort((a, b) => a[0].localeCompare(b[0]));
        sortedItems.forEach(item => {
            console.log(`  ${item[0]}: ${item[1]}`);
        });
    }
}

/*storeCatalogue(['Appricot : 20.4','Fridge : 1500','TV : 1499','Deodorant : 10','Boiler : 300','Apple : 1.25',
'Anti-Bug Spray : 15','T-Shirt : 10']);

storeCatalogue(['Banana : 2','Rubic\'s Cube : 5','Raspberry P : 4999','Rolex : 100000','Rollon : 10',
'Rali Car : 2000000','Pesho : 0.000001','Barrel : 10']);*/