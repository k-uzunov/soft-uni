function getInfo() {
    const stopIdElement = document.getElementById('stopId');
    const stopNameElement = document.getElementById('stopName');
    const busesListElement = document.getElementById('buses')
    const url = 'http://localhost:3030/jsonstore/bus/businfo/' + stopIdElement.value;
    
    stopIdElement.value = "";
    busesListElement.innerHTML = "";
    stopNameElement.textContent = "";

    const httpRequest = new XMLHttpRequest();
    httpRequest.addEventListener('readystatechange', function (){
        if (httpRequest.readyState == 4) {
            if(httpRequest.status == 200){
                let busStop = JSON.parse(httpRequest.response);
                stopNameElement.textContent = busStop.name;
                let busesEntries = Object.entries(busStop.buses).forEach(kvp => {
                    let [busId, time] = kvp;
                    let liElement = document.createElement('li');
                    liElement.textContent = `Bus ${busId} arrives in ${time} minutes`;
                    busesListElement.appendChild(liElement);
                })
            }else{
                stopNameElement.textContent = "Error";
            }
        }
    });

    httpRequest.open("GET", url);
    httpRequest.send();
}