namespace Uaine.Archive
{
    public class Archive<T>
    {
        private List<JsonFileStore<T>> fileStores;

        public string CollectionName { get; private set; }

        public int Size => fileStores.Count;

        public Archive(string collectionName)
        {
            CollectionName = collectionName;
            fileStores = new List<JsonFileStore<T>>();
        }

        public void AddFileStore(JsonFileStore<T> fileStore)
        {
            fileStores.Add(fileStore);
        }

        public JsonFileStore<T> LoadFileByIndex(int index)
        {
            if (index < 0 || index >= fileStores.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return fileStores[index];
        }

        public JsonFileStore<T> LoadFileByDataName(string dataName)
        {
            foreach (var fileStore in fileStores)
            {
                if (fileStore.DataName == dataName)
                {
                    return fileStore;
                }
            }

            throw new ArgumentException($"File with data name '{dataName}' not found.");
        }
    }
}
