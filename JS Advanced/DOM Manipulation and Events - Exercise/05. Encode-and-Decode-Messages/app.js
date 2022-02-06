function encodeAndDecodeMessages() {
    let senderElement = document.getElementById('main').firstElementChild;
    let recieverElement = document.getElementById('main').lastElementChild;

    let sendButton = senderElement.querySelector('button').addEventListener('click', encodeAndSend);
    let readButton = recieverElement.querySelector('button').addEventListener('click', decodeAndRead);

    function encodeAndSend(){
        let textToEncode = senderElement.querySelector('textarea').value;
        let encodedText = "";
        for (let index = 0; index < textToEncode.length; index++) {
            let charCode = textToEncode.charCodeAt(index);
            charCode++;
            encodedText += String.fromCharCode(charCode);
        }
        recieverElement.querySelector('textarea').value = encodedText;
        senderElement.querySelector('textarea').value = "";
    }

    function decodeAndRead(){
        let decodedText = "";
        let textToDecode = recieverElement.querySelector('textarea').value
        
        for (let index = 0; index < textToDecode.length; index++) {
            let charCode = textToDecode.charCodeAt(index);
            charCode--;
            decodedText += String.fromCharCode(charCode);
        }
        recieverElement.querySelector('textarea').value = decodedText;
    }
}