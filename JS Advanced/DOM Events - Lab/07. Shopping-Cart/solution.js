function solve() {
   // 87/100 в Джъдж
   let boughtProductsList = [];
   let totalPrice = 0;
   
   let addProductButtons = Array.from(document.querySelectorAll("button.add-product"));
   let checkoutButtonElement = document.querySelector(".checkout");

   checkoutButtonElement.addEventListener('click', checkout);

   addProductButtons.forEach(buttonElement => {
      buttonElement.addEventListener('click',addProduct)
   });

   function checkout(){
      addProductButtons.forEach(buttonElement => {
         buttonElement.removeEventListener('click',addProduct)
      });

      document.querySelector("textarea").textContent += `You bought ${boughtProductsList.join(", ")} for ${totalPrice.toFixed(2)}.`
   }

   function addProduct(event){
      let name = event.target.parentElement.previousElementSibling.firstElementChild.textContent;
      let money = event.target.parentElement.nextElementSibling.textContent;
      money = Number(money);
      document.querySelector("textarea").textContent += `Added ${name} for ${money.toFixed(2)} to the cart.\n`
      totalPrice += money;
      if (!boughtProductsList.includes(name)) {
         boughtProductsList.push(name)
      }
   }

}