namespace BethanyPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; } //gets rato viyenebt metodia? set rato ar gvaq da MockPieRepository shi Allpies rom viyenebt mand ras vshrebit da mere Viewsshi Pie rat gvida
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int pieId);
    }
}
