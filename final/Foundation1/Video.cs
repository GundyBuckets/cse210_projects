class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string t, string a, int l) {
        _title = t;
        _author = a;
        _length = l;
        _comments = [];
    }
    public void DisplayVideoInfo() {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Length (in seconds): {_length}");
    }

    public void DisplayComments() {
        Console.WriteLine($"Number of comments: {GetNumOfComments()}");
        foreach (Comment comment in _comments) {
            Console.WriteLine(comment.GetComment());
        }
    }

    public int GetNumOfComments() {
        return _comments.Count();
    }

    public void AddComment(string a, string c) {
        Comment newComment = new Comment(a, c);
        _comments.Add(newComment);
    }
}