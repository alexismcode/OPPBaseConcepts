// Tipos de datos
//int myInt = 5;
//double myDouble = 3.434;
//float myFloat = 4.56f;
//decimal myDecimal = 4.56m;

//string myString = "Alexis";
//bool myBool = false;
//var myVar = true;

//Console.WriteLine($"Mi valor entero es.: {myInt, 20:N2}"); // String Format
//Console.WriteLine($"Mi valor doble es..: {myDouble, 20:N2}");
//Console.WriteLine($"Mi valor float es..: {myFloat, 20:P2}");
//Console.WriteLine($"Mi valor decimal es: {myDecimal, 20:C2}");
//Console.WriteLine($"Mi nombre es.......: {myString}");
//Console.WriteLine($"Mi booleano es.....: {(myBool ? "Correcto" : "Incorrecto")}"); // if en una sola linea o ternarios





using OOPConcepts.Logica;

try
{
    Console.WriteLine($"\n======================================================\n");

    var empleado1 = new SalaryEmployes()
    {
        Id = 1010,
        FirstName = "Alexis",
        LastName = "Sanchez",
        BornDate = new Date(2002, 11, 8),
        HireDate = new Date(2021, 5, 15),
        IsActive = true,
        Salary = 600
    };
    var empleado2 = new HourEmployes()
    {
        Id = 2020,
        FirstName = "Carlos",
        LastName = "Mencias",
        BornDate = new Date(1999, 12, 7),
        HireDate = new Date(2023, 5, 15),
        IsActive = true,
        HourValue = 8,
        WorkingValue = 40
    };
    var empleado3 = new CommisionEmployes()
    {
        Id = 3030,
        FirstName = "Josue",
        LastName = "Simba",
        BornDate = new Date(1995, 4, 27),
        HireDate = new Date(2020, 2, 15),
        IsActive = true,
        CommisionPercentaje = 0.5f,
        Sales = 0
    };
    var empleado4 = new BaseCommisionEmployes()
    {
        Id = 3030,
        FirstName = "Daniel",
        LastName = "Casas",
        BornDate = new Date(1994, 9, 30),
        HireDate = new Date(2022, 10, 25),
        IsActive = true,
        CommisionPercentaje = 0.25f,
        Sales = 3050,
        Salary = 200
    };

    // Invoices
    var invoice1 = new Invoice()
    {
        Id = 00034,
        Description = "Mac Pro",
        Precio = 1500,
        Quantity = 3
    };
    var invoice2 = new Invoice()
    {
        Id = 00012,
        Description = "Xiaomy",
        Precio = 500,
        Quantity = 30
    };
    var invoice3 = new Invoice()
    {
        Id = 00034,
        Description = "Impresoras",
        Precio = 200,
        Quantity = 12
    };

    // Impresiones
    Employes[] empleados = new Employes[]
    {
        empleado1, empleado2, empleado3, empleado4
    };
    decimal totalAPagar = 0;

    foreach (Employes empleado in empleados)
    {
        Console.WriteLine(empleado);
        totalAPagar += empleado.GetValueToPay();
    }
    Console.WriteLine($"                                  ====================");
    Console.WriteLine($"Total a pagar                     {totalAPagar, 20:C2}\n");

    Console.WriteLine($"======================================================\n\n");

    Invoice[] invoices = new Invoice[]
    {
        invoice1, invoice2, invoice3
    };
    decimal totalFacturas = 0;

    foreach (Invoice invoice in invoices)
    {
        Console.WriteLine(invoice);
        totalFacturas += invoice.GetValueToPay();
    }
    Console.WriteLine($"                                  ====================");
    Console.WriteLine($"Total facturas                    {totalFacturas,20:C2}");
    Console.WriteLine($"\n======================================================\n\n");

    // Implementar los egresos de la empresa
    // Implementar los ingresos que genera el total de vendedorespor comision
    // Va a restar los ingresos - egresos
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: [{ex.Message}]");
}

