using SpyStore.MVC.ViewModels.Base;
using SpyStore.MVC.Validations;

namespace SpyStore.MVC.ViewModels
{
    public class AddToCartViewModel : CartViewModelBase
    {
        [MustNotBeGreaterThan(nameof(UnitsInStock)), MustBeGreaterThanZero]
        public int Quantity { get; set; }
    }
}