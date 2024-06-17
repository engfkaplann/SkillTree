using SkillTree.Mediator.Models;
using SkillTree.Mediator.Models.Abstracts;
using SkillTree.Mediator.Models.Concretes;
using System;

namespace SkillTree.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatRoomMediator chatRoom = new ChatRoomMediator();

            User user1 = new Participant("John");
            User user2 = new Participant("Rebecca");

            chatRoom.Register(user1);
            chatRoom.Register(user2);

            user1.Send("Rebecca", "Hi Rebecca");
            user2.Send("John", "Hello John");
            user1.Send("Rebecca", "How you doing");

            Console.ReadLine();
        }
    }
}
