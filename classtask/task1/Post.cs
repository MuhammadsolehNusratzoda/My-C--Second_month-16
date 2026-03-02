

namespace P;
public class Post
{
    private static List<Post> _posts = new List<Post>();
    public int Id {get; set;}
    public string Title {get; set;} = "";
    public string Description {get; set;} = "";
    public DateTime CreatedAt {get; set;} 
    public int Category {get; set;}


    public static void CreatePost(Post post)
    {
        _posts.Add(post);
    }

    public static List<Post> GetPosts()
    {
        return _posts;
    }

    public static Post GetPostById(int id)
    {
        return _posts.Find(pos => pos.Id == id);
    }

    public static Post GetPostByName(string title)
    {
        return _posts.Find(pos => pos.Title == title);
    }

    public static List<Post> GetPostByDate(DateTime date)
    {
        return _posts.FindAll( pos => pos.CreatedAt == date );
    }

    public static List<Post> GetPostsByCategoryId(int id)
    {
        return _posts.FindAll(pos => pos.Category == id);
    }

    public static void DeletePost(int id)
    {
       var posdeieted = _posts.Find(pos => pos.Id == id);
       _posts.Remove(posdeieted);
    }
}