function timeToWalk(numOfSteps, footprintLength, speed){
    speedInMetersPerSec = speed*0.27777777777778;
    let timeInSeconds = 0;
    let distance = numOfSteps * footprintLength;
    timeInSeconds = distance / speedInMetersPerSec;
    timeInSeconds += parseInt(distance/500) * 60;

    //console.log(Math.ceil(timeInSeconds));

    let hours = parseInt(timeInSeconds / 3600).toString().padStart(2, 0);
    let minutes = parseInt(timeInSeconds/60).toString().padStart(2, 0);
    let seconds = Math.ceil(timeInSeconds % 60).toString().padStart(2, 0);
    console.log(`${hours}:${minutes}:${seconds}`);


}

timeToWalk(4000, 0.60, 5);
timeToWalk(2564, 0.70, 5.5);