namespace CroweCodingExercise.API
{
#if DBConfiguration
    public interface IAbstractBridge:IDBConfiguration
#else

    public interface IAbstractBridge
#endif
    {
        #region Public Methods

        string RetrieveMessage();

        #endregion Public Methods
    }
}