function lowestPrices(inputArray){
    let products = {};

    for (const element of inputArray) {
        let[town, product, price] = element.split(" | ");
        price = Number(price);
        
        if(!products[product]){
            products[product] = {};
        }

        products[product][town] = price;
    }

    
    for (const product in products) {
        let lowestPrices = Object.entries(products[product]).sort((a,b) => a[1] - b[1]);
        let cheapestTown = lowestPrices[0];
        console.log(`${product} -> ${cheapestTown[1]} (${cheapestTown[0]})`);
    }
}

lowestPrices(['Sample Town | Sample Product | 1000','Sample Town | Orange | 2','Sample Town | Peach | 1',
'Sofia | Orange | 3','Sofia | Peach | 2','New York | Sample Product | 1000.1','New York | Burger | 10'])

// 75/100 в Judge. Нямам представа къде е проблемът.

/*function lowestPrices(inputArray){
    let products = {};
    let lowestPrices = {};

    for (const element of inputArray) {
        let[town, product, price] = element.split(" | ");
        price = Number(price);
        
        if(!products[product]){
            products[product] = {};
        }

        products[product][town] = price;
    }

    for (const product in products) {
        let town;
        let price;
        for (const [key, value] of Object.entries(products[product])) {
            if(!price){
                price = value;
                town = key;
            }else if(value < price){
                price = value;
                town = key;
            }
        }

        if(!lowestPrices[product]){
            lowestPrices[product] = {};
        }

        lowestPrices[product][town] = Number(price);
        //console.log(`${product} -> ${price} (${town})`);
    }

    for (const product in lowestPrices) {
        for (const [town, price] of Object.entries(lowestPrices[product])) {
            console.log(`${product} -> ${price} (${town})`);
        }
    }
    
}*/




