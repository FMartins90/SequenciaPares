


//SequenciaPares
int numero;
int numeroPar = 0;

do
{
    Console.Write("Digite um número inteiro e positivo: ");
    //numero = Convert.Toint32(Console.ReadLine());
    //utilizar apenas o código linha 11 ou código linha 13, possuem funcionalidade similar
    Int32.TryParse(Console.ReadLine(), out numero);
}
while (numero <= 0);

while (numeroPar <= numero)
{
    Console.Write($"{numeroPar} ");
    numeroPar += 2;
}
