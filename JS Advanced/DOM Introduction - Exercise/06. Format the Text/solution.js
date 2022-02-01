function solve() {
  let inputText = document.getElementById("input").value;
  let sentences = inputText.split(".").filter(x => x);
  let paragraphs = "";
  //let sentenceCount = 0;

  for(let i = 0; i < sentences.length; i+=3){
    let text = sentences.slice(i, i+3).join(".");
    paragraphs += `<p>${text}.</p>\n`;
  }
  document.getElementById("output").innerHTML = paragraphs;
}