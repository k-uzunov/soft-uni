function toggle() {
    let button = document.getElementsByClassName('button');
    let text = document.getElementById('extra');
    
    if (button[0].textContent == "More") {
        button[0].textContent = "Less";
        text.style.display = "block";
    }else{
        button[0].textContent = "More";
        text.style.display = "none";
    }
}