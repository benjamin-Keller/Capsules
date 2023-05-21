using Capsules.Data.Models;

namespace Capsules.Pages;

public partial class Ratings
{
    private List<Capsule> Capsules { get; set; } = new List<Capsule>();

    protected override async Task OnInitializedAsync()
    {
        Capsules.AddRange(new List<Capsule>()
        {
            new Capsule()
            {
                Name = "Ispirazione Firenze Arpeggio",
                Image = "/image/capsules/ispirazione-firenze-arpeggio.png",
                Intensity = 9,
                Notes = "Intense",
                Profiles = "Intense & Creamy",
            },
            new Capsule()
            {
                Name = "Ispirazione Ristretto Italiano",
                Image = "/image/capsules/ispirazione-ristretto-italiano.png",
                Intensity = 10,
                Notes = "Intense",
                Profiles = "Powerful & Contrasting",
            },
            new Capsule()
            {
                Name = "Ispirazione Roma",
                Image = "/image/capsules/ispirazione-roma.png",
                Intensity = 8,
                Notes = "Intense",
                Profiles = "Bold & Woody",
            },
        });
    }
}