namespace CroweCodingExercise.API
{
    public interface IDBConfiguration
    {
        bool Connect(string server);
        void Update(string query);
        void Remove(string query);
        string Retrieve(string query);
    }
}