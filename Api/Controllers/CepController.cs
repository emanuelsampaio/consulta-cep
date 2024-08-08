using Dominio.Classes;
using Dominio.DTO;
using Dominio.Enums;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace Api.Controllers
{
    /// <summary>
    /// Controller com os endpoints para consulta de CEP
    /// </summary>
    [ApiController]
    [Route(template: "v1")]
    public class CepController : Controller
    {
        private readonly IServicoAplicacao servicoAplicacao;


        /// <summary>
        /// Injeta o serviço na controller
        /// </summary>
        /// <param name="servicoAplicacao"></param>
        public CepController(IServicoAplicacao servicoAplicacao)
        {
            this.servicoAplicacao = servicoAplicacao;
        }


        /// <summary>
        /// Consulta de CEP API Externa: Brasil Aberto
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: Constantes.Templates.BrasilAberto + "/{cep}")]
        public async Task<IActionResult> GetBrasilAberto([FromRoute] string cep)
        {
            if (!Validacao.IsCep(cep))
            {
                return BadRequest("CEP Inválido.");
            }

            HttpResponseMessage response = await ConsultarCep(cep, ApiExterna.BRASIL_ABERTO);

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsStringAsync().Result;

                BrasilAberto? dto = JsonConvert.DeserializeObject<BrasilAberto>(read);

                return Ok(dto);
            }

            return BadRequest("Ocorreu um problema ao buscar o CEP.");
        }


        /// <summary>
        /// Consulta de CEP API Externa: Via CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: Constantes.Templates.ViaCep + "/{cep}")]
        public async Task<IActionResult> GetViaCep([FromRoute] string cep)
        {
            if (!Validacao.IsCep(cep))
            {
                return BadRequest("CEP Inválido.");
            }

            HttpResponseMessage response = await ConsultarCep(cep, ApiExterna.VIA_CEP);

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsStringAsync().Result;

                ViaCep? dto = JsonConvert.DeserializeObject<ViaCep>(read);

                return Ok(dto);
            }

            return BadRequest("Ocorreu um problema ao buscar o CEP.");
        }


        /// <summary>
        /// Consulta de CEP API Externa: Open CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: Constantes.Templates.OpenCep + "/{cep}")]
        public async Task<IActionResult> GetOpenCep([FromRoute] string cep)
        {
            if (!Validacao.IsCep(cep))
            {
                return BadRequest("CEP Inválido.");
            }

            HttpResponseMessage response = await ConsultarCep(cep, ApiExterna.OPEN_CEP);

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsStringAsync().Result;

                OpenCep? dto = JsonConvert.DeserializeObject<OpenCep>(read);

                return Ok(dto);
            }

            return BadRequest("Ocorreu um problema ao buscar o CEP.");
        }


        /// <summary>
        /// Consulta de CEP API Externa: Brasil API
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: Constantes.Templates.BrasilApi + "/{cep}")]
        public async Task<IActionResult> GetBrasilApi([FromRoute] string cep)
        {
            if (!Validacao.IsCep(cep))
            {
                return BadRequest("CEP Inválido.");
            }

            HttpResponseMessage response = await ConsultarCep(cep, ApiExterna.BRASIL_API);

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsStringAsync().Result;

                BrasilApi? dto = JsonConvert.DeserializeObject<BrasilApi>(read);

                return Ok(dto);
            }

            return BadRequest("Ocorreu um problema ao buscar o CEP.");
        }


        /// <summary>
        /// Consulta de CEP API Externa: Api CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: Constantes.Templates.ApiCep + "/{cep}")]
        public async Task<IActionResult> GetApiCep([FromRoute] string cep)
        {
            if (!Validacao.IsCep(cep))
            {
                return BadRequest("CEP Inválido.");
            }

            HttpResponseMessage response = await ConsultarCep(cep, ApiExterna.API_CEP);

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsStringAsync().Result;

                ApiCep? dto = JsonConvert.DeserializeObject<ApiCep>(read);

                return Ok(dto);
            }

            return BadRequest("Ocorreu um problema ao buscar o CEP.");
        }


        /// <summary>
        /// Consulta de CEP API Externa: República Virtual
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(template: Constantes.Templates.RepVirtual + "/{cep}")]
        public async Task<IActionResult> GeRepublicaVirtual([FromRoute] string cep)
        {
            if (!Validacao.IsCep(cep))
            {
                return BadRequest("CEP Inválido.");
            }

            HttpResponseMessage response = await ConsultarCep(cep, ApiExterna.REP_VIRTUAL);

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsStringAsync().Result;

                RepublicaVirtual? dto = JsonConvert.DeserializeObject<RepublicaVirtual>(read);

                return Ok(dto);
            }

            return BadRequest("Ocorreu um problema ao buscar o CEP.");
        }


        /// <summary>
        /// Retorna o resultado de uma consulta de uma determinada API de CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <param name="ext"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> ConsultarCep(string cep, ApiExterna ext)
        {
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient(ConfigurarProxy()))
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string urlApiCep = RetornarUrlCep(cep, ext);

                response = await client.GetAsync(urlApiCep);
            }

            return response;
        }


        /// <summary>
        /// Retorna a Url da API de CEP solicitada
        /// </summary>
        /// <param name="cep"></param>
        /// <param name="api"></param>
        /// <returns></returns>
        private string RetornarUrlCep(string cep, ApiExterna api)
        {
            string url;

            switch (api)
            {
                case ApiExterna.BRASIL_ABERTO:
                    url = servicoAplicacao.Get().URL_BRASIL_ABERTO;
                    break;

                case ApiExterna.VIA_CEP:
                    url = servicoAplicacao.Get().URL_VIA_CEP;
                    break;

                case ApiExterna.OPEN_CEP:
                    url = servicoAplicacao.Get().URL_OPEN_CEP;
                    break;

                case ApiExterna.BRASIL_API:
                    url = servicoAplicacao.Get().URL_BRASIL_API;
                    break;

                case ApiExterna.API_CEP:
                    url = servicoAplicacao.Get().URL_API_CEP;
                    break;

                default:
                    url = servicoAplicacao.Get().URL_REP_VIRTUAL;
                    break;
            }

            url = url
                .Replace(Constantes.MASK_FORMAT_CEP_1, Conversao.RemoverMascara(cep))
                .Replace(Constantes.MASK_FORMAT_CEP_2, Conversao.RemoverMascara(cep));

            return url;
        }


        /// <summary>
        /// Configurações de proxy, se houver algum barrando
        /// </summary>
        /// <returns></returns>
        private HttpClientHandler ConfigurarProxy()
        {
            IWebProxy proxy = WebRequest.GetSystemWebProxy();
            proxy.Credentials = CredentialCache.DefaultNetworkCredentials;

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            handler.Proxy = proxy;

            return handler;
        }
    }
}