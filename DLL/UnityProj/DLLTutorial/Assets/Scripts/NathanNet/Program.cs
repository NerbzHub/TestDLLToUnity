using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RakNet;

namespace NathanNetServer
{

    class Program
    {
        static void Main(string[] args)
        {
            const ushort PORT = 5456;
            RakNet.RakPeerInterface peerInterface;

            // console out starting up the server

            //Initialize the raknet peer interface first
            peerInterface = RakNet.RakPeerInterface.GetInstance();

            //Create a socket descriptor to describe this connection.
            RakNet.SocketDescriptor socketDescriptor;
            socketDescriptor = new SocketDescriptor(PORT, "0");

            //Now call startup - max of 32 connections, on the assigned port
            peerInterface.Startup(32, socketDescriptor, 1);
            peerInterface.SetMaximumIncomingConnections(32);
        }
    }
}

