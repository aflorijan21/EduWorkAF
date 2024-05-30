using DataAccessLayer.Models;
using System.Net.Http.Json;

namespace BlazorPresentation.Services
{
    public class ProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Project>>("api/projects");
        }

        public async Task<Project> GetProjectAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Project>($"api/projects/{id}");
        }

        public async Task<Project> CreateProjectAsync(Project project)
        {
            var response = await _httpClient.PostAsJsonAsync("api/projects", project);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Project>();
        }

        public async Task UpdateProjectAsync(int id, Project project)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/projects/{id}", project);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProjectAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/projects/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
