using Uaine.IO;

namespace Uaine.Archive
{
    public class JsonFileStore<T> : FileData
    {
        public int Type { get; private set; }
        public string DataName { get; private set; }
        public DataArray<T> Dataarray { get; private set; }

        public JsonFileStore(string filename, string dataname) : base(filename)
        {
            DataName = dataname;
            LoadAllLines();
            Dataarray = new DataArray<T>(Lines);
        }

        public JsonFileStore(string filname, string dataname, T[] items) : base(filname)
        {
            DataName = dataname;
            Dataarray = new DataArray<T>(items);
            Lines = Dataarray.SerialiseToJSON();
            SaveAllLines();
        }
    }
}
