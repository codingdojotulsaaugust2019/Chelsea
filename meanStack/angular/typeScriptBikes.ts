class Bike {
    max_speed: number;
    price: number;
    miles: number;
 
    constructor(speed: number, prc: number, mls: number) {
       this.max_speed = speed;
       this.price = prc;
       this.miles = mls;
    }
 
    Display() {
       console.log(`Max speed is ${this.max_speed}, its current miles are ${this.miles}, and its pric was ${this.price}.`);
    }
 
    Ride() {
       console.log("Riding......");
       this.miles += 10;
    }
 
    Reverse() {
       console.log("Reversing......");
       this.miles -= 5;
    }
 
 }
 const babar = new Bike(30, 500, 1);
 babar.Ride();
 babar.Display();
 babar.Reverse();
 babar.Display();