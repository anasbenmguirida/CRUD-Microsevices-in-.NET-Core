using Service2.DTO;



public class UserClient
{
    private HttpClient _httpClient;

    public UserClient(HttpClient httpClient)
    {
        _httpClient = httpClient; 
    }
    public async Task<object> GetUserNames()
    {
        var response = await _httpClient.GetAsync($"http://localhost:5212/api/person/all");
        response.EnsureSuccessStatusCode();
        
        var usersNames = await response.Content.ReadFromJsonAsync<PersonDTO>();
        return usersNames;
    }
}