namespace SportsStore.WebUI.Service
{
    public interface IApplicationStateService
    {
        string CreateApplicationState(string applicationStateName, string applicationStateValue);
        string GetApplicationState(string applicationStateName);
    }
}