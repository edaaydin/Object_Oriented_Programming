namespace _16_OOP_Generic
{
    internal class KeyValuePair<TKey, TValue, TResult>
    {
        public TKey Id { get; set; }
        public TValue Name { get; set; }
        public DateTime BirthDate { get; set; }
        public TResult Get(TResult data)
        {
            return data;
        }
    }
}
