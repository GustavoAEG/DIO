// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[] arrayInteiros= new int[3];

arrayInteiros[0]=72;
arrayInteiros[1]=64;
arrayInteiros[2]=50;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Array.Resize(ref arrayInteiros, arrayInteiros.Length*2);


for(int contador=0; contador < arrayInteiros.Length; contador++){

    Console.WriteLine($"Posicao n° {contador} - {arrayInteiros[contador]}");
}
int contadorForEach=0;
foreach(int valor in arrayInteiros){

    Console.WriteLine($"Posicao n° {contadorForEach} - {valor}");
contadorForEach++;
}