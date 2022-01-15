function wordsUppercase(text){
    let re = /[a-zA-z0-9]+/g;
    let words = text.match(re);

    let upperCaseText = words[0].toUpperCase();

    for(let i  = 1; i < words.length; i++ ){
        upperCaseText += ', ' + words[i].toUpperCase() ;
    }

    console.log(upperCaseText);
}

wordsUppercase('Hi, how are you?');
wordsUppercase('hello')