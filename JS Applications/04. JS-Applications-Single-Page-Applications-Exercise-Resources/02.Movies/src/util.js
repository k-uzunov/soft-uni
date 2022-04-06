const views =  [...document.querySelectorAll(".view-section")];
function hideAll(){
    views.forEach(x => x.style.display = "none");
}

export function showView(section){
    hideAll()
    section.style.display = "block";
}

export function spinner (){
    const element = document.createElement('p');
    element.innerHTML = 'Loading &hellip;';
    return element;
}

export function updateNav(){
    //get user from localstorage and parse it from json string to js object
    const user = JSON.parse(localStorage.getItem('user'));
    const msgContainer = document.getElementById('welcome-msg')
    //if there is user i.e. someone succsessfully logged in
    if(user){
        document.querySelectorAll('.user').forEach(e => e.style.display = "inline-block");
        document.querySelectorAll('.guest').forEach(e => e.style.display = "none");
        msgContainer.textContent = `Welcome, ${user.email}`

    }else{
        document.querySelectorAll('.user').forEach(e => e.style.display = "none");
        document.querySelectorAll('.guest').forEach(e => e.style.display = "inline-block");
        msgContainer.textContent = '';
    }
}