using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Relativity.Kepler.Services;
using RelpardyKepler.Interfaces.Relpardy.v1.Models;

namespace RelpardyKepler.Interfaces.Relpardy.v1
{
    /// <summary>
    /// MyService Service Interface.
    /// </summary>
    [WebService("Services Service")]
    [ServiceAudience(Audience.Public)]
    [RoutePrefix("Services")]
    public interface IServices : IDisposable
    {
        /// <summary>
        /// Get workspace name.
        /// </summary>
        /// <param name="workspaceID">Workspace ArtifactID.</param>
        /// <returns><see cref="ServicesModel"/> with the name of the workspace.</returns>
        /// <remarks>
        /// Example REST request:
        ///   [GET] /Relativity.REST/api/Relpardy/v1/Services/workspace/1015024
        /// Example REST response:
        ///   {"Name":"Relativity Starter Template"}
        /// </remarks>
        [HttpGet]
        [Route("workspace/{workspaceID:int}")]
        Task<ServicesModel> GetWorkspaceNameAsync(int workspaceID);

        /// <summary>
        /// Query for a workspace by name
        /// </summary>
        /// <param name="queryString">Partial name of a workspace to query for.</param>
        /// <param name="limit">Limit the number of results via a query string parameter. (Default 10)</param>
        /// <returns>Collection of <see cref="ServicesModel"/> containing workspace names that match the query string.</returns>
        /// <remarks>
        /// Example REST request:
        ///   [POST] /Relativity.REST/api/Relpardy/v1/Services/workspace?limit=2
        ///   { "queryString":"a" }
        /// Example REST response:
        ///   [{"Name":"New Case Template"},{"Name":"Relativity Starter Template"}]
        /// </remarks>
        [HttpPost]
        [Route("workspace?{limit}")]
        Task<List<ServicesModel>> QueryWorkspaceByNameAsync(string queryString, int limit = 10);
    }
}
