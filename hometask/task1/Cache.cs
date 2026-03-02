
namespace U;

public static class Cache<T> 
{

   static List<T> _caches = [];
   public static void Add(T cache)
    {
        _caches.Add(cache);
    }
    public static List<T> Get()
    {
        return _caches;
    }
    public static void Remove(T cache)
    {
        _caches.Remove(cache);
    }
}