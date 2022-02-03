function addItem() {
    let text  = document.getElementById("newItemText").value;
    let newLiElement = document.createElement("li");
    newLiElement.textContent = text;
    document.getElementById("items").appendChild(newLiElement);
}