using System;
namespace mexico.Models
{
    public interface ILoadingService
    {
        void Show(string message = "Cargando...");

        void Hide();
    }
}
