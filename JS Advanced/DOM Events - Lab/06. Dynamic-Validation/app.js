function validate() {
    let inputTextElement = document.getElementById("email");
    let emailPattern = /^[a-z]+\@[a-z]+\.[a-z]+$/;
    inputTextElement.addEventListener('change', ()=>{
        if (emailPattern.test(inputTextElement.value)) {
            inputTextElement.classList.remove("error");
        }else{
            inputTextElement.classList.add("error")
        }
    })
}