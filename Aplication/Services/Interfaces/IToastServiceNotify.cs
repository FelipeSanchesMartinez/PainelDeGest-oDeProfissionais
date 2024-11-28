using PainelDeGestãoDeProfissionais.Aplication.Services.Constants;

namespace PainelDeGestãoDeProfissionais.Aplication.Services.Interfaces
{
    public interface IToastServiceNotify
    {
        void Notify(string title, string menssage);
    }
}