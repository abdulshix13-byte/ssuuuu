using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Sayi1 { get; set; }

    [BindProperty]
    public int Sayi2 { get; set; }

    [BindProperty]
    public int Sayi3 { get; set; }

    public int EnBuyuk { get; set; }

    public bool Hesaplandi { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        EnBuyuk = Sayi1;

        if (Sayi2 > EnBuyuk)
        {
            EnBuyuk = Sayi2;
        }

        if (Sayi3 > EnBuyuk)
        {
            EnBuyuk = Sayi3;
        }

        Hesaplandi = true;
    }
}