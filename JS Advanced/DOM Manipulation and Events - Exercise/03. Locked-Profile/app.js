function lockedProfile() {
    let buttonElements = Array.from(document.getElementsByTagName('button'));
    
    buttonElements.forEach(button => {
        button.addEventListener('click', onClick);    
    });

    function onClick(event){
        let profile = event.target.parentElement;
        let hiddenInfoElement = profile.querySelector('div');
        let isUnlocked = profile.querySelector('[value = unlock]').checked;
        
        if(isUnlocked){
            if (event.target.textContent == "Show more") {
                hiddenInfoElement.style.display = "block";
                event.target.textContent = "Hide it"
            } else {
                hiddenInfoElement.style.display = "none";
                event.target.textContent = "Show more"
            }
        }
    }
}