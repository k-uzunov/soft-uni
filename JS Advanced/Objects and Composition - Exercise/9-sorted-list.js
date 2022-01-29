function createSortedList() {
    let list = {
        array:[],
        add(element){
            this.array.push(element);
            this.array.sort((a,b) => a-b);
            this.size = this.array.length;
        },
        remove(index){
            if (index >= 0 && index < this.array.length) {
                this.array.splice(index, 1);
                this.array.sort((a,b) => a-b);
                this.size = this.array.length;
            }
        },
        get(index){
            if (index >= 0 && index < this.array.length)
                return this.array[index];
        },
        size: 0
    }
    
    
    return list;
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(50);
console.log(list.get(1));
