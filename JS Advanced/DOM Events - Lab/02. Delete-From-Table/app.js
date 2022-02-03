function deleteByEmail() {
    //debugger;
    let emailCellElements = Array.from(document.querySelectorAll("tr td:nth-of-type(2)"));
    let emailToDelete = document.querySelector("label input").value;
    let resultElement = document.getElementById('result');

    let elementToBeDeleted = emailCellElements.find(x => x.textContent == emailToDelete);
    
    if (elementToBeDeleted) {
        elementToBeDeleted.parentElement.remove();
        resultElement.textContent = "Deleted."
    }else{
        resultElement.textContent = "Not found.";
    }
}