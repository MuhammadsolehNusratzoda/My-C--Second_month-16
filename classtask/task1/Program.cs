

using System;
using P;

Post post = new Post()
{
    Id = 1,
    Title = "Hello my friend",
    Description  = "I am a good boy",
    Category = 3,
    CreatedAt = DateTime.Now
};

Post post1 = new Post()
{
    Id = 2,
    Title = "Hello",
    Description  = "good boy",
    Category = 3,
};


Post.CreatePost(post);
Post.CreatePost(post1);

System.Console.WriteLine();
System.Console.WriteLine("After creatin post");
System.Console.WriteLine();

foreach (var p in Post.GetPosts())
{
    Console.WriteLine($"{p.Id} {p.Title}");
}

List<Post> posts = Post.GetPosts();
Post postByName = Post.GetPostByName("Hello my friend");

System.Console.WriteLine();
System.Console.WriteLine("Lookin post by name");
System.Console.WriteLine();

if(postByName == null)
{
    System.Console.WriteLine("Post not found");
}
else
{
    System.Console.WriteLine(postByName.Title);
}

List<Post> postsByCategory = Post.GetPostsByCategoryId(2);
Post.DeletePost(1);

System.Console.WriteLine();
System.Console.WriteLine("After deleting post");
System.Console.WriteLine();

foreach (var p in Post.GetPosts())
{
    Console.WriteLine($"{p.Id} {p.Title}");
}

