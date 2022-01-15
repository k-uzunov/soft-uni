function solve(firstString, secondString, thirdString){
	let firstStringLength = firstString.length;
	let secondStringLength = secondString.length;
	let thirdStringLength = thirdString.length;

	let sum = firstStringLength + secondStringLength + thirdStringLength;
	let avgLength = Math.round(sum/3);

	console.log(sum);
	console.log(avgLength); 
};

solve('pasta', '5', '22.3');