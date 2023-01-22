namespace SignalR.API.Modals
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; } //navigation props
    }
}
