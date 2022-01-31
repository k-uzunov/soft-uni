function extractText() {
    let data = document.getElementById('items').textContent;
    data = data.split('\n').filter(x => x);
    data.forEach((element, index) => {
        data[index] = element.trim();
    });
    document.getElementById('result').textContent = data.join('\n');
}