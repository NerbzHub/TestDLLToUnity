using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RakNet;
using NathanNetServer;

public class maincpp : MonoBehaviour
{
    [HideInInspector]
    public int nextClientID = 1;

    private void Start()
    {
        const ushort PORT = 5456;
        RakNet.RakPeerInterface rakPeerInterface;

        // console out starting up the server

        //Initialize the raknet peer interface first
        rakPeerInterface = RakNet.RakPeerInterface.GetInstance();

        //Create a socket descriptor to describe this connection.
        RakNet.SocketDescriptor socketDescriptor;
        socketDescriptor = new SocketDescriptor(PORT, "0");

        //Now call startup - max of 32 connections, on the assigned port
        rakPeerInterface.Startup(32, socketDescriptor, 1);
        rakPeerInterface.SetMaximumIncomingConnections(32);

        handleNetworkMessages(rakPeerInterface);
    }

    private void handleNetworkMessages(RakNet.RakPeerInterface rakPeerInterface)
    {
        RakNet.Packet packet;
        packet = null;

        while (true)
        {
            for (packet = rakPeerInterface.Receive(); packet != null; 
                rakPeerInterface.DeallocatePacket(packet), 
                packet = rakPeerInterface.Receive())
            {
                switch (packet.data[0])
                {
                    case (int)RakNet.DefaultMessageIDTypes.ID_NEW_INCOMING_CONNECTION:
                        Debug.Log("A connection is incoming.");
                        SystemAddress sa = packet.systemAddress;
                        sendNewClientID(rakPeerInterface, ref sa);
                        packet.systemAddress = sa;
                        break;
                    case (int)RakNet.DefaultMessageIDTypes.ID_DISCONNECTION_NOTIFICATION:
                        Debug.Log("A client has disconnected.");
                        break;
                    case (int)RakNet.DefaultMessageIDTypes.ID_CONNECTION_LOST:
                        Debug.Log("A client has lost the connection.");
                        break;
                    case (int)GameMessages.ENUMGAMEMESSAGES.ID_CLIENT_CLIENT_DATA:
                        {
                            RakNet.BitStream bitStream;
                            bitStream = new RakNet.BitStream(packet.data, packet.length, false);
                            rakPeerInterface.Send(bitStream, PacketPriority.HIGH_PRIORITY, PacketReliability.RELIABLE_ORDERED, 
                                (char)0, packet.systemAddress, true);
                            break;
                        }
                    default:
                        Debug.Log("Recieved a message with unknown id:");
                        Debug.Log(packet.data[0]);
                        break;
                }
            }
        }
    }

    private void sendNewClientID(RakNet.RakPeerInterface rakPeerInterface, ref RakNet.SystemAddress address)
    {
        RakNet.BitStream bitstream;
        bitstream = new RakNet.BitStream();
        bitstream.Write(nextClientID);
        nextClientID++;

        rakPeerInterface.Send(bitstream, PacketPriority.HIGH_PRIORITY, PacketReliability.RELIABLE_ORDERED, (char)0, address, false);
        
    }
}

