const { flowerShop } = require('./flowerShop');
const { assert } = require('chai');

describe("Tests …", function() {
    describe("Test calcPriceOfFlowers", function() {
        it("Should throw an error if data is of incorrect type ", function() {
            assert.throws(flowerShop.calcPriceOfFlowers(35, 5, 12),"Invalid input!");
        });
     });
     // TODO: …
});
