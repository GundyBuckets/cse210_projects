using System.ComponentModel.Design;
using System.Net.Sockets;

class Event {
    // Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

   public Event (string title, string desc, string date, string time, Address add) {
    _title = title;
    _description = desc;
    _date = date;
    _time = time;
    _address = add;
   }

   public string StandardDetails() {
    return $"Title: {_title}\n" +
           $"Description: {_description}\n" +
           $"Date: {_date}\n" +
           $"Time: {_time}" +
           $"Address: {_address.GetFormattedAddress()}";
   }

   public virtual string ShortDetails() {
    return $"Title: {_title}\n" +
           $"Date: {_date}";
   }
}