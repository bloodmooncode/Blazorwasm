namespace Blazorwasm.Models
{
    public class Microgrid
    {
        public event Action Changed;

        public string Type { get; set; }

        public string Value { get; set; }

        public string time {get; set;}

        public void Refresh() => Changed?.Invoke();
    }  
}
