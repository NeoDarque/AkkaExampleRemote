using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using AkkaRemote.Remote.Actors;

namespace AkkaRemote.Remote {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Starting RemoteSystem...");
            using(var system = ActorSystem.Create("RemoteSystem")) {
                system.ActorOf<FancyActor>("fancy");
                system.AwaitTermination();
            }
        }
    }
}
