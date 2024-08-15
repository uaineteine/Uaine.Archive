using Uaine.IO;

namespace Uaine.Archive
{
    public class DataArray<T>
    {
        public T[] Items { get; set; }
        public int Size { get => Items.Length; }

        public DataArray(string[] json)
        {
            Items = ArraySerialiser.DeserializeFromJson<T>(json);
        }
        public DataArray(T[] items)
        {
            Items = items;
        }
        public string[] SerialiseToJSON()
        {
            return ArraySerialiser.SerializeToJson<T>(Items);
        }
    }
}
