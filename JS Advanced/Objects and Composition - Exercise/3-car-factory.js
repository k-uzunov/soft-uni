function carFactory(order){
    let car = {
        model: null,
        engine:{},
        carriage:{},
        wheels: [],
    }

    let engines = [smallEngine = {power: 90, volume: 1800}, normalEngine = {power: 120, volume: 2400}, monsterEnine = {
    power: 200, volume: 3500}];
    


    car.model = order.model;
    
    for (const engine of engines) {
        if(engine.power >= order.power){
            car.engine = engine;
            break;
        }
    };

    car.carriage.type = order.carriage;
    car.carriage.color = order.color;

    if(order.wheelsize % 2 == 0){
        car.wheels = [order.wheelsize-1, order.wheelsize-1, order.wheelsize-1, order.wheelsize-1];
    }else{
        car.wheels = [order.wheelsize, order.wheelsize, order.wheelsize, order.wheelsize];
    }

    return car;
}

/*console.log(carFactory({model: 'VW Golf II',
                        power: 90,
                        color: 'blue',
                        carriage: 'hatchback',
                        wheelsize: 14 }));*/
console.log(carFactory({model: 'Opel Vectra',
                        power: 110,
                        color: 'grey',
                        carriage: 'coupe',
                        wheelsize: 17 }));
