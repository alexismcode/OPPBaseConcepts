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
    Console.WriteLine(empleado1);

}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: [{ex.Message}]");
}

