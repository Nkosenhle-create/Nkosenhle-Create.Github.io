using Portfolio.Models;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;

namespace Portfolio.Services
{
    public class PortfolioService
    //public class PortfolioService(HttpClient http)
    {
        private readonly HttpClient http;
        public PortfolioService(HttpClient http) => this.http = http;

        private Profile? _profile;
        private List<Project>? _projects;

        public async Task<Profile> GetProfileAsync() =>
            _profile ??= await http.GetFromJsonAsync<Profile>("data/profile.json") ?? new Profile();

        public async Task<List<Project>> GetProjectsAsync() =>
            _projects ??= (await http.GetFromJsonAsync<List<Project>>("data/projects.json") ?? new())
                .OrderByDescending(p => p.Featured)
                .ThenByDescending(p => p.Year)
                .ToList();

        public async Task<Project?> GetProjectAsync(string slug) =>
            (await GetProjectsAsync())
                .FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
    }
}
