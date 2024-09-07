using System;
using System.Collections.Generic;

// Clase padre
public class Vehicles
{
    // Propiedades comunes
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Fuel { get; set; }

    // Constructor
    public Vehicles(string brand, string model, int year, string color, string fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        Fuel = fuel;
    }

    // Método común a todas las clases hijas
    public virtual void PrintInfo()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return "Marca: " + Brand + "\n" + "Modelo: " + Model + "\n" + "Año: " + Year + "\n" + "Color: " + Color + "\n" + "Tipo De Combustible: " + Fuel + "\n";
    }
}

// Clase hija auto
public class Car : Vehicles
{
    // Lista estática con autos predefinidos
    public static List<Car> Cars = new List<Car>
    {
        new Car("Toyota", "Corolla", 2020, "Rojo", "Gasolina"),
        new Car("Ford", "Fiesta", 2019, "Azul", "Gasolina"),
        new Car("Chevrolet", "Cruze", 2018, "Blanco", "Diesel")
    };

    // llamar al constructor de la clase padre 
    public Car(string brand, string model, int year, string color, string fuel) : base(brand, model, year, color, fuel) {}

    // Método que muestra la información de todos los autos predefinidos
    public static void ShowAllCarsInfo()
    {
        Console.WriteLine("\n***** Información de Autos *****\n");

        foreach (var car in Cars)
        {
            Console.WriteLine("-------------------------------------");
            car.PrintInfo();
        }
    }
}

// Clase hija moto
public class Motorcycle : Vehicles
{
    // Lista estatica con las motos predefinidas
    public static List<Motorcycle> Motorcycles = new List<Motorcycle>
    {
        new Motorcycle("Honda", "CBR500R", 2020, "Negro", "Gasolina"),
        new Motorcycle("Yamaha", "MT-07", 2019, "Rojo", "Gasolina"),
        new Motorcycle("Kawasaki", "Ninja 650", 2018, "Blanco", "Gasolina")
    };

    // llamar al constructor de la clase padre
    public Motorcycle(string brand, string model, int year, string color, string fuel) : base(brand, model, year, color, fuel) {}

    // Método que muestra la información de todas las motos predefinidas
    public static void ShowAllMotorcyclesInfo()
    {
        Console.WriteLine("\n***** Información de Motos *****\n");

        foreach (var motorcycle in Motorcycles)
        {
            Console.WriteLine("-------------------------------------");
            motorcycle.PrintInfo();
        }
    }
}

// Clase hija camion
public class Truck : Vehicles
{
    // Lista estatica con los camiones predefinidos
    public static List<Truck> Trucks = new List<Truck>
    {
        new Truck("Ford", "F-150", 2020, "Azul", "Diésel"),
        new Truck("Chevrolet", "Silverado", 2019, "Rojo", "Diésel"),
        new Truck("Ram", "1500", 2018, "Blanco", "Diésel")
    };

    // Llamar al constructor de la clase padre
    public Truck(string brand, string model, int year, string color, string fuel) : base(brand, model, year, color, fuel) {}

    // Método que muestra la información de todos los camiones predefinidos
    public static void ShowAllTrucksInfo()
    {
        Console.WriteLine("\n***** Información de Camiones *****\n");

        foreach (var truck in Trucks)
        {
            Console.WriteLine("-------------------------------------");
            truck.PrintInfo();
        }
    }
}