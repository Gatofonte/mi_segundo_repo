// comparando diferentes tipos de cadena

string cadenaNula = null;
string cadenaVacia = string.Empty;
string soyCadena = "Soy un texto";

if (cadenaNula == cadenaVacia)
    Console.WriteLine("nulo y vacio es lo mismo");

Console.WriteLine("La cadena de textos tiene una extension de {0} caracteres", soyCadena.Length);

// pasando de mayusculas a munisculas

Console.WriteLine(soyCadena.ToUpper());
Console.WriteLine(soyCadena.ToLower());

// manejo de cadenas con Equals y Contains

string soyCadena2 = "Soyuntexto";
string soyCadena3 = "soy un texto";
string soyCadena4 = "Soy un texto   ";

if (soyCadena.Equals(soyCadena3))
    Console.WriteLine("No importan las mayusculas en el Equals");
else
    Console.WriteLine("importan las mayusculas en el Equals");

if (soyCadena3.Contains(soyCadena))
    Console.WriteLine("No importan las mayusculas en el Contains");
else
    Console.WriteLine("importan las mayusculas en el Contains");

if (soyCadena2.Contains(soyCadena))
    Console.WriteLine("No importan los espacios intermedios en el contains");
else
    Console.WriteLine("importan los espacios intermedios en el Contains");

if (soyCadena4.Contains(soyCadena))
    Console.WriteLine("No importan los espacios finales en el contains");
else
    Console.WriteLine("importan los espacios finales en el Contains");