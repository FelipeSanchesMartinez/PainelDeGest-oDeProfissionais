using BlazorBootstrap;
using PainelDeGestãoDeProfissionais.Aplication.Services.Constants;
using PainelDeGestãoDeProfissionais.Aplication.Services.Interfaces;

namespace PainelDeGestãoDeProfissionais.Aplication.Services
{
    public class ToastServiceNotify : IToastServiceNotify
    {
        private readonly ToastService _toastService;

        public ToastServiceNotify(ToastService toastService)
        {
            _toastService = toastService;
        }
        public void Notify(string title, string menssage)
        {

            var messageNotify = new ToastMessage()
            {
                Type = ToastType.Success,
                Title = title,
                HelpText = $"{DateTime.Now}",
                Message = menssage,
            };
            _toastService.Notify(messageNotify);
        }

    }
}
