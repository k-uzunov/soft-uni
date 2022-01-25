function heroicInventory(inputArray){
    let result = [];
        for (const hero of inputArray) {
            let[name, level, items] = hero.split(' / ')
            level = Number(level);
            items = items ? items.split(', ') : [];

            result.push({name, level, items});
        }


    return JSON.stringify(result);
}

console.log(heroicInventory(['Isacc / 25 / Apple, GravityGun','Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']));
console.log(heroicInventory(['Jake / 1000 / Gauss, HolidayGrenade']));