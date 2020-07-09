using Relativity.Kepler.Services;

namespace RelpardyKepler.Interfaces.Relpardy
{
    /// <summary>
    /// Relpardy Module Interface.
    /// </summary>
    [ServiceModule("Relpardy Module")]
    [RoutePrefix("Relpardy", VersioningStrategy.Namespace)]
    public interface IRelpardyModule
    {
    }
}