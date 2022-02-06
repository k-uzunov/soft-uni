function attachEventsListeners() {
    document.getElementById('convert').addEventListener('click', () => {
        let inputUnit = document.getElementById('inputUnits').value;
        let outputUnit = document.getElementById('outputUnits').value;
        let inputDistance = Number(document.getElementById('inputDistance').value);

        let units = {
            km: 1000,
            m: 1,
            cm: 0.01,
            mm: 0.001,
            mi: 1609.34,
            yrd: 0.9144,
            ft: 0.3048,
            in: 0.0254
        }

        let inputInMeters = inputDistance * units[inputUnit];
        
        document.getElementById('outputDistance').value = inputInMeters / units[outputUnit];
        
    })
}