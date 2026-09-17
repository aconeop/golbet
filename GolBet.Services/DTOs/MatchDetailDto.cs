using GolBet.Entities.Enums;
 
namespace GolBet.Services.DTOs;
 
public class MatchDetailDto
{
    public int Id { get; set; }
 
    public DateTime Date { get; set; }
    public MatchStatus Status { get; set; }
 
    public string HomeTeamName { get; set; } = null!;
    public string HomeTeamCity { get; set; } = null!;
    public string? HomeTeamCrestUrl { get; set; }
 
    public string AwayTeamName { get; set; } = null!;
    public string AwayTeamCity { get; set; } = null!;
    public string? AwayTeamCrestUrl { get; set; }
 
    public int? HomeGoals { get; set; }
    public int? AwayGoals { get; set; }
 
    public decimal HomeOdds { get; set; }
    public decimal DrawOdds { get; set; }
    public decimal AwayOdds { get; set; }
 
    // Aggregate property calculated from the Match.Bets collection
    public int TotalBetsPlaced { get; set; }
}
