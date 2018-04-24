using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RakNet;

namespace NathanNetServer
{
    class GameMessages
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
                RakNet.BitStream bitStream;
                //bitStream.Write((RakNet.DefaultMessageIDTypes) ENUMGAMEMESSAGES.ID_SERVER_TEXT_MESSAGE);
                //bitStream.Write("Ping!");
            }
        }

        void handleNetworkMessages(RakNet.RakPeerInterface rakPeerInterface)
        {
            RakNet.Packet packet;
            packet = null;

            while (true)
            {
                for (packet = rakPeerInterface.Receive(); packet != null ; rakPeerInterface.DeallocatePacket(packet), packet = rakPeerInterface.Receive())
                {
                    switch (packet.data[0])
                    {
                        case (int)RakNet.DefaultMessageIDTypes.ID_NEW_INCOMING_CONNECTION:
                            
                            break;
                    }
                }
            }
        }
    }
}
