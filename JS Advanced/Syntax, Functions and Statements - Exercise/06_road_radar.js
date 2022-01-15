function roadRadar(speed, area){
    let speedLimit = 0;
    let status;
    switch (area) {
        case 'motorway':
            speedLimit = 130;
            break;
        case 'interstate':
            speedLimit = 90;
            break;
        case 'city':
            speedLimit = 50;
            break;
        case 'residential':
            speedLimit = 20;
            break;   
        default:
            break;
    }

    if (speed > speedLimit) {
        let speedDifference = speed - speedLimit;
        if (speedDifference <= 20) {
            status = 'speeding';
        }else if (speedDifference <= 40) {
            status = 'excessive speeding';
        }else {
            status = 'reckless driving';
        }

        console.log(`The speed is ${speedDifference} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    }else{
        console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
    }
}

roadRadar(40, 'city');
roadRadar(21, 'residential');
roadRadar(120, 'interstate');
roadRadar(200, 'motorway');