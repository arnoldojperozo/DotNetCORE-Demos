using SpyStore.MVC.ViewModels.Base;
using SpyStore.MVC.Validations;

namespace SpyStore.MVC.ViewModels
{
    public class CartRecordViewModel : CartViewModelBase
    {
        [MustNotBeGreaterThan(nameof(UnitsInStock))]
        public int Quantity { get; set; }
    }
}