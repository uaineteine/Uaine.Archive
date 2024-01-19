using Uaine.IO;

namespace Uaine.Archive
{
    public class JsonFileStore<T> : FileData
    {
        public int Type { get; private set; }
        public DataArray<T> Dataarray { get; private set; }

        public JsonFileStore(string filename) : base(filename)
        {
            LoadAllLines();
            Dataarray = new DataArray<T>(Lines);
        }

        public JsonFileStore(string filname, T[] items) : base(filname)
        {
            Dataarray = new DataArray<T>(items);
            Lines = Dataarray.SerialiseToJSON();
            SaveAllLines();
        }
    }
}
