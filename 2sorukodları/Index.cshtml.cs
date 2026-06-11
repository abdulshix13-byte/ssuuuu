using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Kenar { get; set; }

    public int Alan { get; set; }

    public int Cevre { get; set; }

    public bool Hesaplandi { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        Alan = Kenar * Kenar;
        Cevre = Kenar * 4;
        Hesaplandi = true;
    }
}