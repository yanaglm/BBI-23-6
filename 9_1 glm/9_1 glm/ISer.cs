namespace _9_1
{
    internal interface ISer
    {
        public void Write<T>(T obj, string path);
        public T Read<T>(string path);
    }
}

