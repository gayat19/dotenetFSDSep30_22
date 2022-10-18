namespace MyFirstAPI.Services
{
    public interface IRepo< K,T>//Key for the key and T for the Type
    {
        T Add(T item);
        T Get(K key);
        ICollection<T> GetAll();
        T Update(T item);
        T Delete(K key);    
    }
}
