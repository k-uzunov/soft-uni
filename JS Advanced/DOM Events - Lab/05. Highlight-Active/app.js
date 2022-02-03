function focused() {
    let inputElements = Array.from(document.querySelectorAll("div input"));
    let onFocus = function(event){
        event.target.parentElement.classList.add("focused");
    };

    let onBlur = function(event){
        event.target.parentElement.classList.remove("focused")
    };

    inputElements.forEach(element => {
        element.addEventListener('focus', onFocus);
        element.addEventListener('blur', onBlur);
    });
}