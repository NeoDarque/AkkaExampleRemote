using System;
using Akka.Actor;
using AkkaRemote.Shared.Messages;

namespace AkkaRemote.Remote.Actors {
    public class FancyActor : ReceiveActor {
        public FancyActor() {
            Receive<FancyMessage>(msg => {
                Console.WriteLine("Received FancyMessage with text: {0}", msg.Text);
            });
        }
    }
}