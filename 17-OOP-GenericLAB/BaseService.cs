namespace _17_OOP_GenericLAB
{
    internal class BaseService : IBaseService<BasePerson>
    {
        private List<BasePerson> _persons;
        public BaseService()
        {
            _persons = new List<BasePerson>();
        }
        public void Create(BasePerson item)
        {
            _persons.Add(item);
        }

        public void Delete(BasePerson item)
        {
            _persons.Remove(item);
        }

        public List<BasePerson> GetAll()
        {
            return _persons;
        }

        public void Update(BasePerson item, int index)
        {
            _persons[index] = item;
        }
    }
}
