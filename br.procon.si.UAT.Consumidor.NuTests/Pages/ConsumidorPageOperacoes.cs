using br.procon.si.UAT.Base;
using br.procon.si.UAT.Consumidor.NuTests.DTO;
using br.procon.si.UAT.Helpers;
using System;

namespace br.procon.si.UAT.Consumidor.NuTests.Pages
{
    public partial class ConsumidorPage : BasePage
    {
 
        public override string ObterPaginaUrl()
        {
            return new Uri(ConfigurationHelper.SiteUrl + paginaUrl).AbsoluteUri;
        }

        public void Salvar(ConsumidorDTO dto)
        {
            if (!String.IsNullOrWhiteSpace(dto.Nome)) Nome.Limpar().PreencherCampo(dto.Nome);
            if (dto.Sexo > 0) Sexo.Find(el => el.ObterValor() == dto.Sexo.ToString()).Clicar();
            if (!String.IsNullOrWhiteSpace(dto.NomeSocial)) NomeSocial.PreencherCampo(dto.NomeSocial);
            if (!String.IsNullOrWhiteSpace(dto.DataNascimento)) DataNascimento.PreencherCampo(dto.DataNascimento);
            if (!String.IsNullOrWhiteSpace(dto.CPF)) CPF.PreencherCampo(dto.CPF);
            if (!String.IsNullOrWhiteSpace(dto.RG)) RG.PreencherCampo(dto.RG);
            if (!String.IsNullOrWhiteSpace(dto.OrgaoEmissorUF)) OrgaoEmissorUF.SelecionarItemDropDown(dto.OrgaoEmissorUF);
            if (!String.IsNullOrWhiteSpace(dto.OrgaoEmissor)) OrgaoEmissor.PreencherCampo(dto.OrgaoEmissor);
            if (dto.TemDeficiencia)
            {
                ChkDeficiencia.PreencherCampo(1);
                if (!String.IsNullOrWhiteSpace(dto.IdTipoDeficiencia)) IdTipoDeficiencia.PreencherCampo(dto.IdTipoDeficiencia);
                if (!String.IsNullOrWhiteSpace(dto.OutroTipoDeficiencia)) OutroTipoDeficiencia.PreencherCampo(dto.OutroTipoDeficiencia);
            }
            if (!String.IsNullOrWhiteSpace(dto.CEP))
            {
                CEP.PreencherCampo(dto.CEP);
                Complemento.ClicarEAguardar(tempoEspera);
            }
            if (!String.IsNullOrWhiteSpace(dto.Logradouro)) Logradouro.PreencherCampo(dto.Logradouro);
            if (!String.IsNullOrWhiteSpace(dto.Numero)) Numero.PreencherCampo(dto.Numero);
            if (!String.IsNullOrWhiteSpace(dto.Cidade)) Cidade.PreencherCampo(dto.Cidade);
            if (!String.IsNullOrWhiteSpace(dto.Estado)) Estado.PreencherCampo(dto.Estado);
            if (!String.IsNullOrWhiteSpace(dto.Telefone)) Telefone.PreencherCampo(dto.Telefone);
            if (!String.IsNullOrWhiteSpace(dto.Celular)) Celular.PreencherCampo(dto.Celular);
            if (!String.IsNullOrWhiteSpace(dto.Preferencias_TipoNotificacao)) Preferencias_TipoNotificacao.PreencherCampo(dto.Preferencias_TipoNotificacao);
            CapturarTela();
            BtnSalvar.Clicar();
        }
    }
}