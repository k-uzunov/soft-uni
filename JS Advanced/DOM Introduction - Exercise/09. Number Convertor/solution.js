function solve() {
    let binaryOpt = document.createElement("option");
    binaryOpt.value = "binary";
    binaryOpt.textContent = "Binary";
    let hexOpt = document.createElement("option");
    hexOpt.value = "hexadecimal";
    hexOpt.textContent = "Hexadecimal";

    let selectElement = document.getElementById("selectMenuTo");
    selectElement.appendChild(binaryOpt);
    selectElement.appendChild(hexOpt);

    document.querySelector("button").addEventListener('click', onClick);

    function onClick(){
        let number = Number(document.getElementById("input").value);
        console.log(typeof(number));
        let result;
        let selectTo = document.getElementById('selectMenuTo').value;
        if (selectTo == "binary") {
            result = number.toString(2).toUpperCase();
        }else{
            result = number.toString(16).toUpperCase();
        }
        document.getElementById("result").value = result;
    }

}