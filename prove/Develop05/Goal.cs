using System.ComponentModel;

class Goal {
    private int _points;
    private string _name;
    private string _description;
    private string _type;

    public Goal(int p, string n, string d, string t) {
        _points = p;
        _name = n;
        _description = d;
        _type = t;
    }

    public virtual string GetSaveFormat() {
        return $"{_type}:{_name}:{_description}:{_points}";
    }

    public virtual int RecordEvent() {
        return _points;
    }

    public virtual string GetDisplayFormat() {
        return $"{_name}: ({_description})";
    }

    public virtual bool IsComplete() {
        return false;
    }

    public virtual int GetPoints() {
        return _points;
    }

    public string GetName() {
        return _name;
    }
}