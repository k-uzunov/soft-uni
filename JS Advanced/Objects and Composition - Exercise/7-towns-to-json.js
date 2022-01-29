function townsToJSON(inputArr){
    let splittedArray = [];
    let resultArr = [];

    inputArr.forEach(element => {
        let row = element.split('|');
        row = row.map(x => x.trim());
        row = row.slice(1, row.length-1);
        splittedArray.push(row);
    });

    let [town, lat, long] = splittedArray[0];


    for (let i = 1; i < splittedArray.length; i++){
        let obj = {}
        obj[town] = splittedArray[i][0];
        obj[lat] = Number(Number(splittedArray[i][1]).toFixed(2)); 
        obj[long] = Number(Number(splittedArray[i][2]).toFixed(2)); 
        resultArr.push(obj);
    }

    return JSON.stringify(resultArr);

}

//console.log(townsToJSON(['| Town | Latitude | Longitude |','| Sofia | 42.696552 | 23.32601 |','| Beijing | 39.913818 | 116.363625 |']));
console.log(townsToJSON(['| Town | Latitude | Longitude |','| Veliko Turnovo | 43.0757 | 25.6172 |','| Monatevideo | 34.50 | 56.11 |']));