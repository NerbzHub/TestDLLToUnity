using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RakNet;

struct GameObject
{
    // These floats are used to store the player's positions as floats rather than a vec3
    float xPos;
    float yPos;
    float zPos;
};

enum GameMessages
{
    ID_SERVER_TEXT_MESSAGE = RakNet.DefaultMessageIDTypes.ID_USER_PACKET_ENUM + 1,
    ID_SERVER_SET_CLIENT_ID,
    ID_CLIENT_CLIENT_DATA
};

namespace RakNetWithSwig
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
