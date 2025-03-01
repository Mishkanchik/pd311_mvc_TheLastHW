using pd311_mvc_aspnet.Data;
using pd311_mvc_aspnet.Models;

namespace pd311_mvc_aspnet.Repositories.Promos
{
    public class PromoRepository : IPromoRepository
    {
        private readonly AppDbContext _context;

        public PromoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Promo GetPromoByCode(string promoCode)
        {
            return _context.Promos.FirstOrDefault(p => p.NamePromo == promoCode);
        }
    }

}
