using Microsoft.AspNetCore.SignalR;

namespace ChatService.Hubs
{
    public class ChatHub:Hub
    {
        private readonly string _botUser;
        private readonly IDictionary<string,UserConnection> _connections;

        public ChatHub(IDictionary<string, UserConnection> connections)
        {
            _botUser = "MyChat Bot";
            _connections = connections;
        }

        public async Task SendMessage(string message)
        {
            if (_connections.TryGetValue(Context.ConnectionId, out UserConnection userConnection))
            {
                await Clients.Groups(userConnection.Room)
                    .SendAsync("ReceiveMessage", userConnection.User, message);
            }
        }


        //Join Room metotunu inşa ederek başlıyorum. Bu metot ismini ve girmek istediği odayı seçen kullanıcılar tarafından çağırılacak.
        public async Task JoinRoom(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room); //mesajımızı all clients'e değil sadece odada bulunan kullanıcılara göndermek için grup oluşturduk.
            _connections[Context.ConnectionId] = userConnection;
            //kullanıcılara mesaj gönderme:
            await Clients.Group(userConnection.Room).SendAsync("ReceiveMessage", _botUser,
                $"{userConnection.User} kullanıcısı {userConnection.Room} odasına katıldı."); // ReceiveMessage front'da karşıladğımız metot.
        }
    }
}
