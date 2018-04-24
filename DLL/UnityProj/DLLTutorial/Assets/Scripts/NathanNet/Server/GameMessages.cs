using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RakNet;
using UnityEngine;
using NathanNetServer;
using System.Threading;

class GameMessages : MonoBehaviour
{
    public enum ENUMGAMEMESSAGES
    {
        ID_SERVER_TEXT_MESSAGE = RakNet.DefaultMessageIDTypes.ID_USER_PACKET_ENUM + 1,
        ID_SERVER_SET_CLIENT_ID,
        ID_CLIENT_CLIENT_DATA
    };

    void sendClientPing(RakNet.RakPeerInterface rakPeerInterface)
    {
        while (true)
        {
            //Use unity console instead.
            RakNet.BitStream bitStream;
            bitStream = new RakNet.BitStream();
            bitStream.Write((char)ENUMGAMEMESSAGES.ID_SERVER_TEXT_MESSAGE);
            bitStream.Write("Ping!");

            rakPeerInterface.Send(bitStream, PacketPriority.HIGH_PRIORITY, PacketReliability.RELIABLE_ORDERED, (char)0,
                RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS, true);
            Thread.Sleep(1000);
        }
    }
}

