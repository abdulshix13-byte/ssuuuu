using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Sayi1 { get; set; }

        [BindProperty]
        public int Sayi2 { get; set; }

        public int Toplam { get; set; }
        public int Carpim { get; set; }

        public bool Hesaplandi { get; set; }

        public void OnPost()
        {
            Toplam = Sayi1 + Sayi2;
            Carpim = Sayi1 * Sayi2;
            Hesaplandi = true;
        }
    }
}