function create(words) {
   let contentDivElement = document.getElementById("content");
   words.forEach(word => {
      let divElement = document.createElement("div");
      divElement.addEventListener('click', onClick);
      let paragraphElement = document.createElement("p");
      paragraphElement.style.display = "none";
      paragraphElement.textContent = word;
      divElement.appendChild(paragraphElement);
      contentDivElement.appendChild(divElement);
   });

   function onClick(event){
      let hiddenParagraph = event.target.firstElementChild;
      hiddenParagraph.style.display = 'block';
   }
}