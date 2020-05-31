namespace TasklibraryWait
{
    internal class CustomData
    {
        public CustomData()
        {
        }

        public int Name { get; set; }
        public long CreationTime { get; set; }
        public int ThreadNum { get; internal set; }
    }
}