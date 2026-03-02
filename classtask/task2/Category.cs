



namespace C;

public class Category
{
    private static List<Category> _categories = new List<Category>();
    public int Id{get; set;}
    public string Name {get; set;} = "";
    public DateTime CreatedAt {get; set;} 

    public static void CreateCategory(Category category)
    {
        _categories.Add(category);
    }

    public static List<Category> GetCategories()
    {
        return _categories;
    }

    public static Category GetCategoryById(int id)
    {
        return _categories.Find(cat => cat.Id == id);
    }

    public static Category GetCategoryByName(string name)
    {
        return _categories.Find(cat => cat.Name == name);
    }

    public static Category GetCategoryByDate(DateTime date)
    {
        return _categories.Find(cat => cat.CreatedAt == date);
    }

    public static void DeleteCategory(int id)
    {
        var catdeleted = _categories.Find(cat => cat.Id == id);
       _categories.Remove(catdeleted);
    }
}