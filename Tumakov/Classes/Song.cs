using System;

class Song
{
    private string name;
    private string author;
    private Song prev;

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public void SetPrev(Song prev)
    {
        this.prev = prev;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Песня: {name}, Исполнитель: {author}");
    }

    public string Title()
    {
        return $"{name} - {author}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Song otherSong)
        {
            return this.name == otherSong.name && this.author == otherSong.author;
        }
        return false;
    }

    public override int GetHashCode()
    {
        int hashName = name?.GetHashCode() ?? 0;
        int hashAuthor = author?.GetHashCode() ?? 0;
        return hashName ^ hashAuthor;
    }
}