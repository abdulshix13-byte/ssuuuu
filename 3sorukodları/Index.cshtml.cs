using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Sayi { get; set; }

    public string Sonuc { get; set; }

    public bool Hesaplandi { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (Sayi % 2 == 0)
        {
            Sonuc = Sayi + " sayýsý çifttir.";
        }
        else
        {
            Sonuc = Sayi + " sayýsý tektir.";
        }

        Hesaplandi = true;
    }
}