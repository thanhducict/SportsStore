namespace SportsStore.WebUI.Service
{
    public interface ISessionService
    {
        string CreateSession(string sessionName, string sessionValue);
        string GetSession(string sessionName);
        string DeleteSession(string sessionName);
    }
}
