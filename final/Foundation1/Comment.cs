using System.ComponentModel.DataAnnotations;

class Comment {
    private string _author;
    private string _content;
    public Comment(string a, string c){
        _author = a;
        _content = c;
    }
    public string GetComment() {
        return $"{_author}: {_content}";
    }


}