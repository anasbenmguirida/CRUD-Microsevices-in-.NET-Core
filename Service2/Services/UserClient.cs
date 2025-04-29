using Service2.DTO;



public class UserClient
{
    private HttpClient _httpClient;

    public UserClient(HttpClient httpClient)
    {
        _httpClient = httpClient; 
    }
    public async Task<string> GetUserNames()
    {
        var response = await _httpClient.GetAsync($"http://localhost:5212/api/person/all");
        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadAsStringAsync();
        
    }
}