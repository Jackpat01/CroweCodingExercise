using System;

namespace CroweCodingExercise.API
{
    public abstract class MessageBase : IMessage
    {
        #region Public Properties

        /// <inheritdoc />
        ///
        public string Text { get; protected set; }

        #endregion Public Properties
    }
}