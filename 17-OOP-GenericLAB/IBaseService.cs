namespace _17_OOP_GenericLAB
{
    internal interface IBaseService<T> where T : BasePerson
    {
        void Create(T item);
        void Update(T item, int index);
        void Delete(T item);
        List<T> GetAll();
    }
}
