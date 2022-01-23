function jsonToHtmlTable(json){
    
    let inputArr = JSON.parse(json);
    
    let outputArr = ["<table>"];
    outputArr.push(makeKeyRow(inputArr));
    inputArr.forEach((obj) => outputArr.push(makeValueRow(obj)));
    outputArr.push("</table>");
    
    console.log(outputArr.join("\n"));

    function makeKeyRow(inputArr){
        let result = `  <tr>`;
        let keys = Object.keys(inputArr[0]);
        keys.forEach(key => {
            result += `<th>${escapeHtml(key)}</th>`
        });
        result +=`</tr>`;
        return result;
    }

    function makeValueRow(inputObj){
        let result = `  <tr>`;
        let values = Object.values(inputObj);
        values.forEach(value => {
            result += `<td>${escapeHtml(value)}</td>`;
        });
        result += `</tr>`;
        return result;
    }

    function escapeHtml(inputElement){
        inputElement.toString()
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/`/g, '&grave;')
            .replace(/'/g, '&apos;');

        return inputElement;
    }
}

//jsonToHtmlTable(`[{"Name":"Stamat","Score":5.5},{"Name":"Rumen","Score":6}]`);
//jsonToHtmlTable(`[{"Name":"Pesho","Score":4," Grade":8},{"Name":"Gosho","Score":5," Grade":8},
//{"Name":"Angel","Score":5.50," Grade":10}]`);