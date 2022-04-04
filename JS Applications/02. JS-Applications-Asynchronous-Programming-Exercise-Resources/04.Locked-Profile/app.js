async function lockedProfile() {
    const url = 'http://localhost:3030/jsonstore/advanced/profiles'

    const response = await fetch(url);
    const data = await response.json();
    console.log(data)
}