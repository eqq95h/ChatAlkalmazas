using ChatAlkalmazas.Models;
using System;
using System.Collections.Generic;

namespace ChatAlkalmazas.Client.Logic
{
    public class MessengerClientLogic : IMessengerClientLogic
    {
        public string Username { get; set; }

        public void Send(Message message)
        {
            throw new NotImplementedException();
        }

        public void SetupCollection(string Username, IList<Message> messages)
        {
            this.Username = Username;

        }
    }
}
