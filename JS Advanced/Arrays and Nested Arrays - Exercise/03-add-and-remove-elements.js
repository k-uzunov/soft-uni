function addAndRemove(commands){
    let numbers = [];

    for(let i = 0; i < commands.length; i++){
        if (commands[i] == 'add') {
            numbers.push(i+1);            
        } else {
            numbers.pop();
        }
    }

    if (numbers.length > 0) {
        console.log(numbers.join("\n"));
    }else{
        console.log("Empty");
    }
}

addAndRemove(['add', 'add', 'add', 'add']);
console.log("-------");
addAndRemove(['add', 'add', 'remove', 'add', 'add'])
console.log("-------");
addAndRemove(['remove', 'remove', 'remove']);