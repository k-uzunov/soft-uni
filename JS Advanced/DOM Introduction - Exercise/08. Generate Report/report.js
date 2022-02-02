function generateReport() {
    let tableHead = Array.from(document.querySelectorAll("th input"));
    let tableRows =  Array.from(document.querySelectorAll("tbody tr"));
    let table = [];
    let output = [];

    for (const row of tableRows) {
        let currentRow = Array.from(row.children).map(tr => tr.textContent)
        table.push(currentRow);
    }

    for(let row = 0; row < table.length; row++){
        let resultObj = {}
        for(let col = 0; col < table[row].length; col++){
            
            if (tableHead[col].checked) {
                resultObj[tableHead[col].name] = table[row][col];
            }
        }
        output.push(resultObj);
    }

    document.getElementById("output").textContent = JSON.stringify(output);

}