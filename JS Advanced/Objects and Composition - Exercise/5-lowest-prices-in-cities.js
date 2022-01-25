// 75/100 in Judge.

function lowestPrices(inputArray){
    let products = {};
    let lowestPrices = {};

    for (const element of inputArray) {
        let[town, product, price] = element.split(" | ");
        
        if(!products[product]){
            products[product] = {};
        }

        products[product][town] = Number(price);
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
    }

    for (const product in lowestPrices) {
        for (const [town, price] of Object.entries(lowestPrices[product])) {
            console.log(`${product} -> ${price} (${town})`);
        }
    }
    
}

lowestPrices(['Sample Town | Sample Product | 1000','Sample Town | Orange | 2','Sample Town | Peach | 1',
'Sofia | Orange | 3','Sofia | Peach | 2','New York | Sample Product | 1000','New York | Burger | 10'])
