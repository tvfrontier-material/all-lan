    class Car {
        make: string;
        model: string;

        constructor(make: string, model: string) {
            this.make = make;
            this.model = model;
        }

        startEngine(): void {
            console.log("Engine started!");
        }
    }

    const myCar = new Car("Toyota", "Camry");
    console.log(myCar.model);
    myCar.startEngine();
