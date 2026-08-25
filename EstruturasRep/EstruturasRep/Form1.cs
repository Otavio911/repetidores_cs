namespace EstruturasRep
{
    public partial class Repetidores : Form
    {
        public Repetidores()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;
            int contador = 0;

            lsbMostra.Items.Clear();

            lsbMostra.Items.Add("10 primeiros números de Fibonacci");
            lsbMostra.Items.Add("-------------------------------");

            while (contador < 10)
            {
                lsbMostra.Items.Add(a);

                int proximo = a + b;
                a = b;
                b = proximo;

                contador++;
            }





        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            int[] numeros = { 15, 8, 32, 4, 21 };

            int maior = numeros[0];
            int menor = numeros[0];

            lsbMostra.Items.Clear();

            lsbMostra.Items.Add("Maior e menor de 5 números:");
            lsbMostra.Items.Add("----------------------------");

            foreach (int numero in numeros)
            {
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            lsbMostra.Items.Add("Números:");

            foreach (int numero in numeros)
            {
                lsbMostra.Items.Add(numero);
            }

            lsbMostra.Items.Add("----------------------------");
            lsbMostra.Items.Add("Maior: " + maior);
            lsbMostra.Items.Add("Menor: " + menor);


        }

        private void lsbMostra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int numero = 5;
            int multiplicador = 1;

            lsbMostra.Items.Clear();

            lsbMostra.Items.Add("Tabuada do 5:");
            lsbMostra.Items.Add("----------------");

            do
            {
                lsbMostra.Items.Add(numero + " x " + multiplicador + " = " + (numero * multiplicador));

                multiplicador++;

            } while (multiplicador <= 10);
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {

            int numero = 2;
            int quantidadePrimos = 0;

            lsbMostra.Items.Clear();

            lsbMostra.Items.Add("15 primeiros números primos:");
            lsbMostra.Items.Add("----------------------------");

            while (true)
            {
                bool primo = true;

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    lsbMostra.Items.Add(numero);
                    quantidadePrimos++;
                }

                if (quantidadePrimos == 15)
                {
                    break;
                }

                numero++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            lsbMostra.Items.Add("Quadrados de 1 até 100:");
            lsbMostra.Items.Add("------------------------");

            for (int numero = 1; numero <= 100; numero++)
            {
                int quadrado = numero * numero;

                lsbMostra.Items.Add(numero + "² = " + quadrado);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            lsbMostra.Items.Add ("1 a 100, ignorando múltiplos de 3:");
            lsbMostra.Items.Add("--------------------------------------------");

            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    continue;
                }

                lsbMostra.Items.Add(numero);
            }
        }
    }
}
