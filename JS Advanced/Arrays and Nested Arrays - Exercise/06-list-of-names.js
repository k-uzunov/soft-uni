function listOfNames(names){
    let listNumber = 1;
    names.sort((a,b) => a.localeCompare(b));
    for (const iterator of names) {
        console.log(listNumber + '.' + iterator);
        listNumber++;
    }
}

listOfNames(["John", "Bob", "Christina", "Ema"]);