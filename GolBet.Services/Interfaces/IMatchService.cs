using GolBet.Entities.Enums;
using GolBet.Services.DTOs;
 
namespace GolBet.Services.Interfaces;
 
public interface IMatchService
{
    /// <summary>Match board: all active matches ordered by date.</summary>
    Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null);

    /// <summary>Details for a specific match.</summary>
    Task<MatchDetailDto?> GetDetailAsync(int id);
}
