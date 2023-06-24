using PooEjemplo;
using System.Security.Cryptography;

//Car car = new Car(new Account("Juan David Forero", "123456789"), "AD1234", 4);
//car.Imprimir();
//Car car2 = new Car(new Account("Andres Camilo Parra", "987654321"), "AD2456", 4);
//car2.Imprimir();

//Driver driver = new Driver("Camila","Prada");
//driver.mostrar();
//User user = new User("Camilo", "Acosta");
//user.mostrar();

//Uberx uberx = new Uberx("ADB123", new Account("Juan Carlos", "123432434"), "Chevrolet", "AveoFt");
//uberx.setPassenger(4);
//uberx.Imprimir();
//Console.ReadKey();


Ubervan ubervan = new Ubervan("ADB123", new Account("Juan Carlos", "123432434"), new Dictionary<string, Dictionary<string, int>>(){
    {
    "Camioneta",
    new Dictionary<string, int>(){ { "Suv",3} }
    }
}, new List<string> { "Cuero" });
ubervan.setPassenger(6);
ubervan.Imprimir();
Console.ReadKey();

