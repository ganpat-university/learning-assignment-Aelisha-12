interface IUser {
    username: string;
    password: string;
    confirmPassword?: string;       //By writing ?(que mark) it become Optional property => does not have to be implemented.
}


let user: IUser;

// user = { anything: 'anything different' };       // COMPILER ERROR

user = { username: 'manoj', password: 'secretpassword' };
user = { username: 'sharma', password: 'secretpassword', confirmPassword: 'secretpassword' };

console.log('user information:');
console.log(user.username);
console.log(user.password);
//console.log(user.confirmPassword);
//console.log('\n');

//Another Example

interface ICar {
    // Defining the signature of the method
    accelerate(speed: number): void;
}

let car: ICar = {
    accelerate: function (speed: number): void {
        console.log('accelerating now to :' + speed);
    }
};

car.accelerate(500);
    
