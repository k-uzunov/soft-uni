function search() {
   let townsList = Array.from(document.querySelectorAll("#towns li"));
   let searchText = document.getElementById("searchText").value;
   let matches = 0;
   for (const town of townsList) {
      if (town.textContent.includes(searchText) && searchText.length > 0) {
         town.style.fontWeight = "bold";
         town.style.textDecoration = "underline";
         matches++;
      }else{
         town.style.fontWeight = "normal";
         town.style.textDecoration = "none";
      }
   }
   document.getElementById("result").textContent = `${matches} matches found`;
}
