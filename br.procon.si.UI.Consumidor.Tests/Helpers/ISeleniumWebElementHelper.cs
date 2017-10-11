namespace br.procon.si.UI.Consumidor.Tests.Helpers
{
    public interface ISeleniumWebElementHelper
    {
        string ObterTexto();

        string ObterValor();

        string ObterTextoDoDropDownList();

        SeleniumWebElementHelper PreencherCampo(string value);

        SeleniumWebElementHelper PreencherCampo(long value);

        SeleniumWebElementHelper PreencherCampoEAguardar(string value, int milisegundos = 3000);

        SeleniumWebElementHelper Clicar();

        SeleniumWebElementHelper ClicarEAguardar(int milisegundos = 3000);

        SeleniumWebElementHelper SelecionarItemDropDown(string value);

        SeleniumWebElementHelper Limpar();

        SeleniumWebElementHelper Submit();

        SeleniumWebElementHelper Aguardar(int milisegundos);

    }
}