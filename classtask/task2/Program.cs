

using System;
using C;

Category category1 = new Category()
{
    Id = 1,
    Name = "Hello my friend",
    CreatedAt = DateTime.Now
};

Category category2 = new Category()
{
    Id = 2,
    Name = "Hi my friend",
    CreatedAt = DateTime.Now
};


Category.CreateCategory(category1);
Category.CreateCategory(category2);

System.Console.WriteLine();
System.Console.WriteLine("After creatin category");
System.Console.WriteLine();

foreach (var cate in Category.GetCategories())
{
    Console.WriteLine($"{cate.Id} {cate.Name}");
}

List<Category> cates = Category.GetCategories();
Category cateByName = Category.GetCategoryByName("Hello my friend");

System.Console.WriteLine();
System.Console.WriteLine("Lookin post by category");
System.Console.WriteLine();

if(cateByName == null)
{
    System.Console.WriteLine("Category not found");
}
else
{
    System.Console.WriteLine(cateByName.Name);
}

// List<Category> category = Category.GetPostsByCategoryId(2);
Category.DeleteCategory(1);

System.Console.WriteLine();
System.Console.WriteLine("After deleting category");
System.Console.WriteLine();

foreach (var cate in Category.GetCategories())
{
    Console.WriteLine($"{cate.Id} {cate.Name}");
}
