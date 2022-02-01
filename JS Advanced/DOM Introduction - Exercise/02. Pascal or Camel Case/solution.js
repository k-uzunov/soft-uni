function solve() {
  let inputText = document.getElementById("text").value;
  let convention  = document.getElementById("naming-convention").value;
  
  let text = inputText.split(' ');

  if(convention == "Camel Case"){
    
    text[0] = text[0].toLowerCase();
    for(let i = 1; i < text.length; i++){
      text[i] = text[i].toLowerCase();
      text[i] = text[i].charAt(0).toUpperCase() + text[i].slice(1);
    }

    document.getElementById("result").textContent = text.join('')
  }else if(convention == "Pascal Case"){
    for(let i = 0; i < text.length; i++){
      text[i] = text[i].toLowerCase();
      text[i] = text[i].charAt(0).toUpperCase() + text[i].slice(1);
    }

    document.getElementById("result").textContent = text.join('')
  }else{
    document.getElementById("result").textContent = "Error!"
  }
}