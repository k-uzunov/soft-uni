function solve() {
    const infoElement = document.getElementById('info').firstElementChild;
    const departButtonElement = document.getElementById('depart');
    const arriveButtonElement = document.getElementById('arrive');
    let nextStop = {
        next: 'depot'
    };

    function depart() {

        let url = 'http://localhost:3030/jsonstore/bus/schedule/' + nextStop.next;
        let promise = new Promise(function (resolve, reject){
            const httpRequest = new XMLHttpRequest();
            httpRequest.onreadystatechange = () => {
                if (httpRequest.readyState == 4) {
                    if (httpRequest.status == 200) {
                        resolve(httpRequest.response)
                    }else{
                        reject('Error')
                    }
                }
            }
            httpRequest.open('GET', url);
            httpRequest.send();
        })

        promise.then((result) => {
            nextStop = JSON.parse(result);
            console.log(nextStop)
            
            infoElement.textContent = `Next stop ${nextStop.name}`;
            departButtonElement.disabled = true;
            arriveButtonElement.disabled = false;
        })
        promise.catch((result) => {
            infoElement.textContent = result; 
        })
    }

    function arrive() {
        infoElement.textContent = `Arriving at ${nextStop.name}`;
        departButtonElement.disabled = false;
        arriveButtonElement.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();