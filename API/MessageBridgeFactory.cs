namespace CroweCodingExercise.API
{
    public static class MessageFactory
    {
        #region Public Properties

        public static IAbstractBridge Bridge { get; set; }

        #endregion Public Properties

#if DBConfiguration
/// <inheritdoc />
///
        public static bool Connect(string server)
        {
            return Bridge.Connect(server);
        }

        /// <inheritdoc />
        ///
        public static void Remove(string query)
        {
            Bridge.Remove(query);
        }

        /// <inheritdoc />
        ///
        public static string Retrieve(string query)
        {
            return Bridge.Retrieve(query);
        }

        /// <inheritdoc />
        ///
        public static void Update(string query)
        {
            Bridge.Update(query);
        }
#endif

        #region Public Methods

        /// <inheritdoc />
        public static string RetrieveMessage()
        {
            return Bridge.RetrieveMessage();
        }

        #endregion Public Methods
    }

    public class MessageBridge : IAbstractBridge
    {
        #region Private Fields

        private readonly IMessage _message;

        #endregion Private Fields

        #region Public Constructors

        public MessageBridge(IMessage message)
        {
            _message = message;
        }

        #endregion Public Constructors

#if DBConfiguration

/// <inheritdoc />
///
        public bool Connect(string server)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        ///
        public void Update(string query)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        ///
        public void Remove(string query)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        ///
        public string Retrieve(string query)
        {
            throw new NotImplementedException();
        }

#endif

        #region Public Methods

        /// <inheritdoc />
        public string RetrieveMessage()
        {
            return _message.Text;
        }

        #endregion Public Methods
    }
}