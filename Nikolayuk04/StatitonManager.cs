
using System;
using Nikolayuk04.Tools.DataStorage;
namespace Nikolayuk04
{
    internal static class StationManager
    {
        private static IDataStorage _dataStorage;

        internal static Person CurrentPerson { get; set; }

        internal static IDataStorage DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        internal static void CloseApp()
        {
            Environment.Exit(1);
        }
    }
}
