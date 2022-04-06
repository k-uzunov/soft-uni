import { homePage } from "./home.js";
import { showView, updateNav } from "./util.js";

const section = document.querySelector('#form-login');
const loginForm = section.querySelector('form');

loginForm.addEventListener('submit', onSubmit);

export function loginPage() {
    showView(section);
}

//event hadler function
async function onSubmit(event) {
    //Default behavior of Forms is to reload the page
    event.preventDefault();

    const formData = new FormData(event.target);

    const email = formData.get('email');
    const password = formData.get('password');
    
    await login(email, password);
    updateNav();
    homePage();
}

async function login(email, password){
    //Use try-catch to catch errors besides sever errors
    try{
        //POST request for login 
        const res = await fetch('http://localhost:3030/users/login', {
            method: 'POST',
            headers: {
                'Content-Type':'application/json'
            },
            body: JSON.stringify({email, password})
        });

        //Chech if response is success and throw error if not
        if(!res.ok) {
            console.log("error");
            const error = await res.json();
            throw new Error(error.message);
        }

        //await user data
        const user = await res.json();

        //save user data in localstorage
        localStorage.setItem('user', JSON.stringify(user));

    } catch (err) {
        alert(err.message);
        //Throw error so the next function will catch it and stop executing
        throw err;
    }
}
