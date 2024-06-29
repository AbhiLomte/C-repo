using System;


class Books
{
    
    public string BookName { get; set; }
    public string AuthorName { get; set; }

   
    public Books(string bookName, string authorName)
    {
        BookName = bookName;
        AuthorName = authorName;
    }

    
    public void Display()
    {
        Console.WriteLine($"Book Name: {BookName}");
        Console.WriteLine($"Author Name: {AuthorName}");
        Console.WriteLine();
    }
}

class BookShelf
{
    
    private Books[] books = new Books[5];

    
    public Books this[int index]
    {
        get
        {
            if (index < 0 || index >= books.Length)
            {
                throw new IndexOutOfRangeException("Index out of range for BookShelf.");
            }
            return books[index];
        }
        set
        {
            if (index < 0 || index >= books.Length)
            {
                throw new IndexOutOfRangeException("Index out of range for BookShelf.");
            }
            books[index] = value;
        }
    }
}

class que1
{
    static void Main()
    {
       
        BookShelf shelf = new BookShelf();

        
        shelf[0] = new Books("Ramayan", "Valmiki");
        shelf[1] = new Books("Mahabharat", "Vyas");
        shelf[2] = new Books("Wings of fire", "APJ Abdul Kalam");
        shelf[3] = new Books("The Discovery of India", "Jawaharlal Nehru");
        

        
        Console.WriteLine("Details of books in the BookShelf:");
        for (int i = 0; i < 5; i++)
        {
            shelf[i].Display();
            
        }
        Console.Read();
    }
}
