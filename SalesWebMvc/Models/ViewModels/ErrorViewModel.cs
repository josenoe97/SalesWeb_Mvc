namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; } // "?" significa que o valor pode ser "nullable" nulo 
        public string? Menssage { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); /*testa se existe*/
    }
}