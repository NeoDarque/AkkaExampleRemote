using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using AkkaRemote.Shared.Messages;

namespace AkkaRemote.Local {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Starting LocalSystem...");
            using(var system = ActorSystem.Create("TheSystem")) {
                var fancyActor = system.ActorSelection("akka.tcp://RemoteSystem@127.0.0.1:10000/user/fancy");
                fancyActor.Tell(new FancyMessage { Text = "Hello there!"});
                system.AwaitTermination();
            }
        }
    }
}
