namespace br.procon.si.UI.Consumidor.Tests.Helpers
{
    public interface ISeleniumWebElementHelper
    {
        string ObterTexto();

        string ObterValor();

        string ObterTextoDoDropDownList();

        SeleniumWebElementHelper PreencherCampo(string value);

        SeleniumWebElementHelper PreencherCampo(long value);

        SeleniumWebElementHelper PreencherCampoEAguardar(string value, int segundos = 3);

        SeleniumWebElementHelper Clicar();

        SeleniumWebElementHelper ClicarEAguardar(int segundos = 3000);

        SeleniumWebElementHelper SelecionarItemDropDown(string value);

        SeleniumWebElementHelper Limpar();

        SeleniumWebElementHelper Submit();

    }
}