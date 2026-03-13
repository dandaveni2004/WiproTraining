function add(a: number, b: number): number {
	    return a + b;
	}
	let sum = add(5, 10);
	// A generic Add fucntion that can work with different types of numbers (e.g., integers, floats, strings that can be converted to numbers)
	function genericAdd<T extends number | string>(a: T, b: T): number {
	    return Number(a) + Number(b);
	}
	let genericSum = genericAdd(5, 10);
	console.log("The generic sum is: " + genericSum);
	let genericSum2 = genericAdd("10", "5");
	console.log("The generic sum is: " + genericSum2);
	
	function identity<T>(arg: T): T {
	    return arg;
	}
	let output1 = identity<string>("Hello, Generics!");
	console.log(output1);
	let output2 = identity<number>(42);
	console.log(output2);