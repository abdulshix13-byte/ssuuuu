using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Yas { get; set; }

    public string Sonuc { get; set; }

    public bool Hesaplandi { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (Yas < 18)
        {
            Sonuc = "Reþit Deðilsiniz";
        }
        else
        {
            Sonuc = "Reþitsiniz";
        }

        Hesaplandi = true;
    }
}