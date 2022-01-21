function sortArray(array){
    array.sort((a, b) =>{
        return a.length - b.length || a.localeCompare(b);
    });
    console.log(array.join('\n'));
}

sortArray(['alpha', 'beta', 'gamma']);
sortArray(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']);
sortArray(['test', 'Deny', 'omen', 'Default']);