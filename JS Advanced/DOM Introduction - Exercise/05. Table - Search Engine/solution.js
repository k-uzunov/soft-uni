function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);
   
   let rows = Array.from(document.querySelectorAll("tbody tr"));
   

   function onClick() {
      //   TODO:
      let searchText = document.getElementById("searchField");
      for (const row of rows) {
         if (row.textContent.includes(searchText.value) && searchText.value) {
            row.classList.add("select");
         }else{
            row.classList.remove("select");
         }
      }
      searchText.value = "";

   }
}