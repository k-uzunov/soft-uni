function solve() {
  let generateButton = document.querySelector('button:first-of-type');
  let buyButton = document.querySelector('button:last-of-type');
  let tableElement = document.querySelector('tbody');

  generateButton.addEventListener('click', function generate(){
    let input = JSON.parse(document.querySelector('textarea:nth-of-type(1)').value);
    
    for(let i = 1; i <= input.length; i++){
      let tableRow = document.createElement('tr');
      tableRow.innerHTML = `<td class="img"></td> <td class="name"></td> <td class="price"></td> <td class="decFactor"></td> <td><input type="checkbox"/></td>`;
      tableElement.appendChild(tableRow);
    }
    let rows = Array.from(document.querySelectorAll('tbody tr'));

    for (let index = 1; index < rows.length; index++) {
      let obj = input[index-1];
      console.log(obj["img"])
      rows[index].querySelector('.img').innerHTML = `<img src="${obj["img"]}">`;
      rows[index].querySelector('.name').textContent = obj["name"];
      rows[index].querySelector('.price').textContent = obj["price"];
      rows[index].querySelector('.decFactor').textContent = obj["decFactor"];
    }

    /*for (const obj of input) {
      
      let objEntries = Object.entries(obj);
      for (let [key, value] of objEntries) {

        if(key == 'img'){
          tableRowElement.innerHTML += `<td><img src="${value}"></td>`;
        }else{
          tableRowElement.innerHTML += `<td>${value}</td>`;
        }
      }
      tableRowElement.innerHTML += `<td><input type="checkbox"/></td>`
      document.querySelector(".table tbody").appendChild(tableRowElement);
    }*/
  });

  buyButton.addEventListener('click', function checkout(){
    let table = Array.from(document.querySelectorAll('tbody tr'));
    let totalPrice = 0;
    let totalDecFactor = 0;
    let avgDecFactor = 0;
    let boughtItems = [];
    
    for (const row of table) {
      let isChecked = row.querySelector('[type=checkbox]');
      if(isChecked.checked == true){
        let item = row.querySelector('td:nth-child(2)').textContent;
        let price = Number(row.querySelector('td:nth-child(3)').textContent);
        let decFactor = Number(row.querySelector('td:nth-child(4)').textContent);

        totalDecFactor += decFactor;
        totalPrice += price;
        boughtItems.push(item);

      }
      
    }

    avgDecFactor = totalDecFactor / boughtItems.length;
    document.querySelector('textarea:last-of-type').value = `Bought furniture: ${boughtItems.join(', ')}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${avgDecFactor}`;

  })

}