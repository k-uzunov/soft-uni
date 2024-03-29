function factory(library, orders){
    let products = [];

    for (const order of orders) {
        let currentProduct = order.template;
        for (const part of order.parts) {
            currentProduct[part] = library[part];
        }
        products.push(currentProduct);
    }

    return products;
}

const orders = [
    {
      template: { name: 'ACME Printer'},
      parts: ['print']      
    },
    {
      template: { name: 'Initech Scanner'},
      parts: ['scan']      
    },
    {
      template: { name: 'ComTron Copier'},
      parts: ['scan', 'print']      
    },
    {
      template: { name: 'BoomBox Stereo'},
      parts: ['play']      
    }
];

const library = {
    print: function () {
      console.log(`${this.name} is printing a page`);
    },
    scan: function () {
      console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
      console.log(`${this.name} is playing '${track}' by ${artist}`);
    },
};
  const products = factory(library, orders);
  console.log(products);
  