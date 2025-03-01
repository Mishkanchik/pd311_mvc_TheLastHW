using pd311_mvc_aspnet.Models;

namespace pd311_mvc_aspnet.Repositories.Promos
{
    public interface IPromoRepository
    {
        Promo GetPromoByCode(string promoCode);
    }

}
