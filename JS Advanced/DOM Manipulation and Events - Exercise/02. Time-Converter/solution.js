function attachEventsListeners() {
    let time = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400,
    }

    let inputTextElements = Array.from(document.querySelectorAll("[type = text]"));
    let buttonElements = Array.from(document.querySelectorAll("[type = button]"));
    buttonElements.forEach(buttonElement => {
        buttonElement.addEventListener('click', convert);
    });

    function convert(event){
        let initialValue = Number(event.target.previousElementSibling.value);
        let timeUnit = event.target.previousElementSibling.id;
        let multiplier = initialValue / time[timeUnit];

        inputTextElements.forEach(textElement => {
            let elementID = textElement.id;
            textElement.value = time[elementID]*multiplier;
        });
    }
}