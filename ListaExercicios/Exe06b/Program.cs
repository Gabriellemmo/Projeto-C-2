// 1 - Criar um vetor para receber os valores aleatórios
// 2 - Percorrer o vetor com um laço de repetição
// 3 - Preencher cada posição com um valor aleatório
// 4 - Imprimir o vetor com valores aleatórios

int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(100); 
}

Console.WriteLine("Vetor antes da ordenação:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine("\n");

// 5 - Percorrer o vetor com um laço de repetição
// 6 - Comparar a posição atual com a próxima
// 7 - Trocar os valores entre a posição atual e a próxima
// 8 - Imprimir o vetor com valores ordenados

bool troca;

do
{
    troca = false; // Inicializa a variável troca como falsa, indicando que não houve troca inicialmente

    // Percorre o vetor comparando elementos adjacentes
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        if (vetor[i] > vetor[i + 1]) // Se o elemento atual for maior que o próximo
        {
            
            int auxiliar = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = auxiliar;

            troca = true; 
        }
    }

} while (troca); 

Console.WriteLine("\nVetor após ordenação:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

