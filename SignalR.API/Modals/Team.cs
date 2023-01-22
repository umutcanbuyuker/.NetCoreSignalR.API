namespace SignalR.API.Modals
{
    public class Team
    {
        public Team()
        {
            Users= new List<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users {  get; set; } //lazyloading için navigation props
    }
}
