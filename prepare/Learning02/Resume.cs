public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume() {
        string result = "";
        result += $"Name: {_name}\n";
        result += "Jobs:\n";
        Console.Write(result);
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}