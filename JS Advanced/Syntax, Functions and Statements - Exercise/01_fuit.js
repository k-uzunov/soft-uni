function fruits(fruit, weightInGrams, pricePerKilo) {
    let weightinKilos = weightInGrams/1000;
    let money = weightinKilos * pricePerKilo;

    console.log(`I need $${money.toFixed(2)} to buy ${weightinKilos.toFixed(2)} kilograms ${fruit}.`);
}

fruits('orange', 2500, 1.80);