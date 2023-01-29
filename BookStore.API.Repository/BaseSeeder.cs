namespace BookStore.API.Repository
{
    public abstract class BaseSeeder
    {
        private List<string[]>? lines = null;

        public List<string[]> ReadFromFile(string filePath)
        {
            using (var streamReader = new StreamReader(filePath))
            {
                lines ??= new List<string[]>();

                while (!streamReader.EndOfStream)
                {
                    var splits = streamReader.ReadLine().Split('|');
                    lines.Add(splits);
                }
            }

            return lines;
        }
    }
}
