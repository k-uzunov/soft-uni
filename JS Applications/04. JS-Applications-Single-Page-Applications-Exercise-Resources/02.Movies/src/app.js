// [V] improve HTML struct
// [V] create app module
// [ ] creat router.js containing hide and display view logic
// [V] plceholders for all views



// implement views
// - create request logic
// - DOM manipulation logic
// [V] catalog
// [V] login 
// [ ] register
// [ ] create
// [ ] details
// [ ] like
// [ ] edit
// [ ] delete

import { homePage } from "./home.js"
import { loginPage } from "./login.js";
import { registerPage } from "./register.js";
import { createPage } from "./create.js";
import { updateNav } from "./util.js";

const routes = {
    '/': homePage,
    '/login': loginPage,
    '/register': registerPage,
    '/create': createPage,
    '/logout': logout,
    
}


document.querySelector('nav').addEventListener('click', onNavigate)
document.querySelector('#add-movie-button').addEventListener('click', onNavigate)

function onNavigate (event) {
    if (event.target.tagName == "A" && event.target.href) {
        event.preventDefault();
        const url = new URL(event.target.href);

        const view = routes[url.pathname];

        if (typeof view == 'function') {
            view();
        }
    }
}

function logout() {
   localStorage.removeItem('user');
   updateNav();
}

//Start app in catalog view
updateNav();
homePage();