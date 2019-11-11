var myString: string;
myString = "Bee stinger";
// myString is cast as type tring and integer was assigned. Turn int into string.
myString = "9";

////////////////////////////

function sayHello(name: string){
    return `Hello, ${name}!`;
 }
 // This is working great:
 console.log(sayHello("Kermit"));
 // 9 needed to be a string not int.
 console.log(sayHello("9"));

 //////////////////////

 function fullName(firstName: string, lastName: string, middleName: string){
    let fullName = `${firstName} ${middleName} ${lastName}`;
    return fullName;
 }
 // This works:
 console.log(fullName("Mary", "Moore", "Tyler"));
 // fullName expected 3 parameters, not two.
 console.log(fullName("Jimbo", "Jones", "Jombo"));

 /////////////////////////

 interface Student {
    firstName: string;
    lastName: string;
    belts: number;
 }
 function graduate(ninja: Student){
    return `Congratulations, ${ninja.firstName} ${ninja.lastName}, you earned ${ninja.belts} belts!`;
 }
 const christine = {
    firstName: "Christine",
    lastName: "Yang",
    belts: 2
 }
 const jay = {
    firstName: "Jay",
    lastName: "Patel",
    belts: 4
 }
 // This seems to work fine:
 console.log(graduate(christine));
 // LOL jay's "belts" field was missing an 's' -- typo!
 console.log(graduate(jay));

 //////////////////////////

 class Ninja {
    fullName: string;
    constructor(
       public firstName: string,
       public lastName: string){
          this.fullName = `${firstName} ${lastName}`;
       }
    debug(){
       console.log("Console.log() is my friend.")
    }
 }
 // needed new keyword and requires 2 parameters.
 const shane = new Ninja("Shane", "Turing");
 // used constructor
 const turing = new Ninja("Alan", "Turing");
 
    
 
 // Now I'll make a study function, which is a lot like our graduate function from above:
 function study(programmer: Ninja){
    return `Ready to whiteboard an algorithm, ${programmer.fullName}?`
 }
 // Now this has problems:
 console.log(study(turing));

 /////////////////////////////////////


var increment = (x: number) => x + 1;
// This works great:
console.log(increment(3));
var square = (x: number) => {x * x};
// This is not showing me what I want:copy
console.log(square(4));
// This is not working:
var multiply = (x: number,y: number) => x * y;
// Nor is this working:

var math = (x: number, y: number) => {
    let sum = x + y;

    let product = (x: number, y: number) => x * y;

    let difference = Math.abs(x - y);

    return [sum, product, difference];
}

///////////////////////////////////////////

class Elephant {
    constructor(public age: number){}
    birthday = () => {
       this.age++;
    }
 }
 const babar = new Elephant(8);
 setTimeout(babar.birthday, 1000)
 setTimeout(function(){
    console.log(`Babar's age is ${babar.age}.`)
    }, 2000)
 // Why didn't babar's age change? Fix this by using an arrow function in the Elephant class.

