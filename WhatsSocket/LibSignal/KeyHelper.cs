﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WhatsSocket.LibSignal
{
    public static class KeyHelper
    {

        public static byte[] RandomBytes(int size)
        {
            byte[] buffer = new byte[size];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(buffer);
            }
            return buffer;
        }

        public static int GenerateRegistrationId()
        {
            var buffer = RandomBytes(2);
            return buffer[0] & 0x3fff;
        }



        //generateSignedPreKey
        //generatePreKey

    }
}