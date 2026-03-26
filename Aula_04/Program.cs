using System;

public class Carro {
    public string fabricante;
    public string modelo;
    public string cor;
    public double aro;
    public int ano;
    public bool estado = true;

    public void ExibirDados() {
        Console.WriteLine($"Fabricante: {fabricante}\nModelo: {modelo}\nCor: {cor}\nAro: {aro}\nAno: {ano}\nEstado: {estado}");
    }
    public void Ligou() {
        Console.WriteLine("O carro está ligado");
    }
    public void Desligou() {
        Console.WriteLine("O carro está desligado");
    }
}


class Program {
    static void Main() {
        Carro c1 = new Carro();
        c1.fabricante = "Mitsubishi";
        c1.modelo = "Lancer GT";
        c1.cor = "All Black";
        c1.aro = 17.0;
        c1.ano = 2015;
        c1.estado = true;

        c1.ExibirDados();

        if (c1.estado) {
            c1.Ligou();
        }
    }
}
