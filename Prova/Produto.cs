public class Produto
{
    public string id;
    public string unidade;
    public string descricao;
    public double valor;
    public double pis;
    public double icms;
    public double confins;
    public double lucro;
    public double valorTotal;

    public double CalculoPIS(double valor, double porcentagem)
    {
        return valor * (porcentagem / 100);
    }
    public double CalculoICMS(double valor, double porcentagem)
    {
        return valor * (porcentagem / 100);
    }
    public double CalculoCONFINS(double valor, double porcentagem)
    {
        return valor * (porcentagem / 100);
    }

    public double Total(double valor, double pis, double icms, double confins, double lucro)
    {
        return (valor + pis + icms + confins) + ((valor + pis + icms + confins) * (lucro / 100));
    }
}
