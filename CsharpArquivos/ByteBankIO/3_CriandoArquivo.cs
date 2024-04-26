using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contaExportadas.csv";
        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);
            
            fluxoDeArquivo.Write(bytes, 0, bytes.Length); 
        }

    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contaExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
             using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("566, 65456, 456.5,Pedro");
            }

        }
    }
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "Teste.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1056; i++)
                {
                    escritor.WriteLine($"Linha{i}");
                    escritor.Flush(); 
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                    Console.ReadLine();

                }
            }

        }
    }
}