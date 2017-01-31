using System;
using System.Configuration;
using System.IO;
using System.Text;
using CroweCodingExercise.API;

namespace CroweCodingExercise
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            MessageFactory.Bridge = new MessageBridge(new HelloMessage());
            if (ConfigurationManager.AppSettings["ProcessMethod"] == "Console")
            {
                Console.WriteLine(MessageFactory.RetrieveMessage());
                Console.ReadKey();
            }
            else if (ConfigurationManager.AppSettings["ProcessMethod"] == "File")
            {
                try
                {
                    using (
                        var file = File.Open(ConfigurationManager.AppSettings["FileName"], FileMode.OpenOrCreate)
                    )
                    {
                        file.Write(Encoding.Default.GetBytes(MessageFactory.RetrieveMessage()), 0,
                            MessageFactory.RetrieveMessage().Length);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        #endregion Private Methods
    }
}