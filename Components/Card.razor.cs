using Capsules.Data.Models;
using Microsoft.AspNetCore.Components;

namespace Capsules.Components;

public partial class Card
{
    [Parameter] public Capsule Capsule { get; set; }
}