using ChatAlkalmazas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatAlkalmazas.Client.Logic
{
    public interface IMessengerClientLogic
    {
        string Username { get; }
        void SetupCollection(string Username, IList<Message> messages);
        void Send(Message message);
    }
}
