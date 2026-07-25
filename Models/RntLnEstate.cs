using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntLnEstate
{
    public int PidEstate { get; set; }

    public string PidLang { get; set; } = null!;

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Summary { get; set; }

    public string? Description { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? PagePath { get; set; }

    public string? OldPagePath { get; set; }

    public string? NbhDescription { get; set; }

    public string? NbhMetaTitle { get; set; }

    public string? NbhMetaKeywords { get; set; }

    public string? NbhMetaDescription { get; set; }

    public string? NbhPagePath { get; set; }

    public string? NbhOldPagePath { get; set; }

    public string? NotesVoucher { get; set; }

    public string? FeaturesDescription { get; set; }

    public string? VillaDiretionsDescription { get; set; }

    public string? LocationDescription { get; set; }

    public string? ParkingDescription { get; set; }

    public string? GardenDescription { get; set; }

    public string? TerraceDescription { get; set; }

    public string? DependenceDescription { get; set; }

    public string? AboutPropertyDescription { get; set; }

    public string? SrsMeetinPointDesc { get; set; }
}
