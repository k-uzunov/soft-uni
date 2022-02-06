function addItem() {
    let newItemTextInput = document.getElementById('newItemText');
    let newItemValueInput = document.getElementById('newItemValue');

    let newOptionElement = document.createElement('option');
    newOptionElement.value = newItemValueInput.value;
    newOptionElement.textContent = newItemTextInput.value;

    document.getElementById('menu').appendChild(newOptionElement);
    newItemTextInput.value = "";
    newItemValueInput.value = "";
}