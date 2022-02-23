class LibraryCollection {
    constructor(capacity){
        this.capacity = capacity
        this.books = [];
    }

    addBook(bookName, bookAuthor){
        if(this.books.length == this.capacity){
            throw new Error("Not enough space in the collection.");
        }else{
            this.books.push({bookName, bookAuthor, payed:false})
            return `The ${bookName}, with an author ${bookAuthor}, collect.`
        }
    }

    payBook(bookName){
        let currentBook = this.books.find(book => book.bookName == bookName);
        if (!currentBook) {
            throw new Error(`${bookName} is not in the collection.`);  
        }else if(currentBook.payed){
            throw new Error(`${bookName} has already been paid.`)
        }else{
            currentBook.payed = true;
            return `${bookName} has been successfully paid.`
        }
    }

    removeBook(bookName){
        let currentBook = this.books.find(book => book.bookName == bookName);
        
        if (!currentBook) {
            throw new Error("The book, you're looking for, is not found.");  
        }else if(!currentBook.payed){
            throw new Error(`${bookName} need to be paid before removing from the collection.`)
        }else{
            let currentBookIndex = this.books.indexOf(currentBook);
            this.books.splice(currentBookIndex, 1);
            return `${bookName} remove from the collection.`
        }
    }

    getStatistics(bookAuthor){
        if (!bookAuthor) {
            let emptySlots = this.capacity - this.books.length;
            let resultString = '';

            let sortedBooks = this.books.sort((a, b) => {
                a.bookName.localeCompare(b.bookName);
            });

            sortedBooks.forEach(book => {
                resultString += `${book.bookName} == ${book.bookAuthor} - ${book.payed ? 'Has Paid' : 'Not Paid'}.\n`;
            });
            resultString = resultString.trimEnd();
            return `The book collection has ${ emptySlots } empty spots left.\n` + resultString
        } else {
            let currentBook = this.books.find(book => book.bookAuthor == bookAuthor);
            if (!currentBook) {
                throw new Error(`${bookAuthor} is not in the collection.`);
            }else{
                return `${currentBook.bookName} == ${currentBook.bookAuthor} - ${currentBook.payed ? 'Has Paid' : 'Not Paid'}.`
            }
        }
    }
}

const library = new LibraryCollection(2)
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
console.log(library.removeBook('Don Quixote'));
console.log(library.removeBook('In Search of Lost Time'));





