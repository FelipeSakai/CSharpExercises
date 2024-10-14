string frase1 = "O rato roeu a roupa do rei de roma";
char letra = 'a';
int contador = 0;

foreach(char c in frase1)
{
    if (c == 'a' || c == 'A') contador++;
}

Console.WriteLine(contador > 0
            ? $"A letra 'a' aparece {contador} vezes no texto."
            : "A letra 'a' não está presente no texto.");