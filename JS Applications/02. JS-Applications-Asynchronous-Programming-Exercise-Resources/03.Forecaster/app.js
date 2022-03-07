function attachEvents() {
    const submitButtonElement = document.getElementById('submit');
    const locationInputElement = document.getElementById('location');
    const forecastDivElement = document.getElementById('forecast');
    const errorElement = document.createElement('h1');
    let locations;

    errorElement.textContent = "Error";
    errorElement.style.textAlign = 'center';

    function errorHandler () {
        forecastDivElement.prepend(errorElement);
    }

    let symbols = {
        "Sunny":"&#x2600;", 
        "Partly sunny":"&#x26C5;", 
        "Overcast":"&#x2601;",
        "Rain":"&#x2614",
    }

    fetch("http://localhost:3030/jsonstore/forecaster/locations").then(response => {
            return response.json()
        }).then(data => {
            locations = data;
        }).catch((response) => {
            console.log("Error")
        });
    
    submitButtonElement.addEventListener('click', function(event){
        const inputValue = locationInputElement.value;
        const currentLocation = locations.find(x => x.name == inputValue);
        const currentDivElement = document.getElementById('current');
        const upcomingDivElement = document.getElementById('upcoming');
        
        //Clear old forecasts or errors if any
        if(forecastDivElement.contains(errorElement))
            forecastDivElement.removeChild(errorElement);
        if(currentDivElement.contains(document.querySelector('div .forecasts')))
            currentDivElement.removeChild(document.querySelector('div .forecasts'));
        if(upcomingDivElement.contains(document.querySelector('div .forecast-info')))
            upcomingDivElement.removeChild(document.querySelector('div .forecast-info'));

        forecastDivElement.style.display = 'block';
        //Call error handler if location is not included in the data
        if(currentLocation == undefined){
            errorHandler();
            return;
        }

        //Fetch forecast
        fetch("http://localhost:3030/jsonstore/forecaster/today/" + currentLocation.code)
            .then(response => {
                if(response.status !== 200) throw Error('Error')
                else return response.json()
            }).then(data => {
                let resultString = `<div class="forecasts">
                                        <span class="condition symbol">${symbols[data.forecast.condition]}</span>
                                        <span class="condition">
                                            <span class="forecast-data">${data.name}</span>
                                            <span class="forecast-data">${data.forecast.low}&#176;/${data.forecast.high}&#176;</span>
                                            <span class="forecast-data">${data.forecast.condition}</span>
                                        </span>                                            
                                    </div>`
                currentDivElement.innerHTML += resultString;
            }).catch(error => {errorHandler()})
        
        //Fetch upcoming
        fetch("http://localhost:3030/jsonstore/forecaster/upcoming/" + currentLocation.code)
            .then(response => {
                if(response.status !== 200) throw Error('Error')
                else return response.json()
            }).then(data => {
                let resultString = `<div class="forecast-info">`;
                data.forecast.forEach(day => {
                    resultString +=`<span class="upcoming">
                                        <span class="symbol">${symbols[day.condition]}</span>
                                        <span class="forecast-data">${day.low}&#176;/${day.high}&#176</span>
                                        <span class="forecast-data">${day.condition}</span>
                                    </span>`;
                })

                resultString += `</div>`
                upcomingDivElement.innerHTML += resultString;
            }).catch(error => {errorHandler()})
        
    })
    
}

attachEvents();