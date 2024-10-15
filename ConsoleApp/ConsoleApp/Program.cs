using System.Collections;
using System.Text;


public class ConsoleApp
{

    static void Main(string[] args)
    {

        // task1

        // lista

        List<string> minhaLista = new List<string>();

        minhaLista.Add("Eduardo");
        minhaLista.Add("Araceli");
        minhaLista.Add("Jandira");
        minhaLista.Add("João");

        foreach (var item in minhaLista)
        {
            Console.WriteLine(item);
        }


        // array
        int[] numeros = new int[] { 1, 2, 3, 4, 5 };

        foreach (var newItem in numeros)
        {
            Console.WriteLine(newItem);
        }

        // task2

        // manipulação de string

        StringBuilder sb = new StringBuilder();

        foreach (var item in minhaLista)
        {
            sb.Append(item);
        }

        Console.WriteLine(sb.ToString());

        // task3

        // função ou classe

        var listinha = new ListaBuilder()
                            .AddList("Eduardo")
                            .AddList("Araceli")
                            .AddList("Jandira")
                            .AddList("João");

        foreach (var minhaListinha in listinha.GetList())
        {
            Console.WriteLine(minhaListinha);
        }

        // matriz multidimensional

        int[,] multidimesional = { { 1, 2, 3 }, { 5, 6, 7 } };

        foreach (var itensNumerosDimensional in multidimesional)
        {
            Console.WriteLine(itensNumerosDimensional);
        }


        // task 4


        // array
        int[] numeros2 = new int[] { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };

        var minhaOrdem = Order.QuickSort(numeros2); // árvore AVL

        foreach (var itemNumeros in minhaOrdem)
        {
            Console.WriteLine(itemNumeros);
        }


        Hashtable minhaHashetable = new Hashtable();

        minhaHashetable.Add("Eduardo", 47);
        minhaHashetable.Add("Araceli", 47);
        minhaHashetable.Add("Jandira", 81);
        minhaHashetable.Add("João", 77);

        foreach (var itens in minhaHashetable.Keys)
        {
            Console.WriteLine(itens);
        }


        foreach (var itens in minhaHashetable.Values)
        {
            Console.WriteLine(itens);
        }


        // caracteres possíveis

        // ataque dos caracteres ansi 32 até 255

        // de 0 até 255 caracteres

        // meu caracter

        string meuCarater = "";

        for (var i = 0; i < 255; i++)
        {
            string meuValor = "";

            for (var x = 32; x < 255; x++)
            {
                meuValor = "" + Convert.ToChar(x);
                Console.WriteLine(meuCarater + meuValor);

            }
            Thread.Sleep(1000);

            meuCarater += meuValor;
        }

        Console.WriteLine("Pressione alguma tecla para continuar");

        Console.Read();
    }
}

public class ListaBuilder
{
    List<string> minhaLista = new List<string>();

    public ListaBuilder AddList(string texto)
    {
        minhaLista.Add(texto);
        return this;
    }

    public List<string> GetList()
    {
        return minhaLista;
    }
}


// arvoré AVL
public class Order
{
    public static int[] QuickSort(int[] data)
    {
        var resultado = QuickSort(data, 0, data.Length - 1);
        return resultado;
    }

    public static int[] QuickSort(int[] data, int l, int r)
    {
        int i, j;
        int x;
        i = l;
        j = r;
        x = data[(l + r) / 2];
        while (true)
        {
            while (data[i] < x)
                i++;
            while (x < data[j])
                j--;
            if (i <= j)
            {
                SwapValues(data, i, j);
                i++;
                j--;
            }
            if (i > j)
                break;
        }
        if (l < j)
            QuickSort(data, l, j);
        if (i < r)
            QuickSort(data, i, r);
        return data;
    }

    public static int[] SwapValues(int[] arrayDados, int m, int n)
    {
        int temp;
        temp = arrayDados[m];
        arrayDados[m] = arrayDados[n];
        arrayDados[n] = temp;
        return arrayDados;
    }
}