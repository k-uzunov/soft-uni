function extract(content) {
    let text = document.getElementById(content).textContent;
    let pattern = /\(([A-z\s]+)\)/g;
    let matches = Array.from(text.matchAll(pattern));
    let result = []
    matches.forEach(element => {
        result.push(element[1]);
    })

    //console.log(result);
    return result.join('; ');
}