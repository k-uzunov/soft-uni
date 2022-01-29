function rectangle(width, height, color) {
    let str = color;
    color = str.charAt(0).toUpperCase() + str.slice(1);
    
    let rect = {
        width,
        height,
        color,
        calcArea(){
            return Number(this.height * this.width)
        }
    }    

    return rect;
}

let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
