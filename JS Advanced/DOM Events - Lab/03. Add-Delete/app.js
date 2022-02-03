function addItem() {
    let text  = document.getElementById("newItemText").value;
    let newLiElement = document.createElement("li");
    newLiElement.textContent = text;

    let deleteElement = document.createElement('a');
    deleteElement.href = "#";
    deleteElement.textContent = "[Delete]";
    deleteElement.addEventListener("click", onClick);

    newLiElement.appendChild(deleteElement);
    document.getElementById("items").appendChild(newLiElement);
    document.getElementById("newItemText").value = "";

    function onClick(e){
        e.currentTarget.parentElement.remove();
    };
}
