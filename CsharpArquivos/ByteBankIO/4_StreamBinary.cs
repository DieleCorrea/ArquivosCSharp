﻿partial class Program
{

    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaConrrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456); // saldo da conta 
            escritor.Write(45634234); // numero da conta 
            escritor.Write(4563.09); // Saldo
            escritor.Write("Gustavo Braga");
        }

    }
    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaConrrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadUInt32();
            var numeroConta = leitor.ReadUInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo} ");
        }
    }

}