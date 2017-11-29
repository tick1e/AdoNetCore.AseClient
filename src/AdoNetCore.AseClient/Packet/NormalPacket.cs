﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AdoNetCore.AseClient.Enum;
using AdoNetCore.AseClient.Interface;

namespace AdoNetCore.AseClient.Packet
{
    internal class NormalPacket : IPacket
    {
        private readonly IEnumerable<IToken> _tokens;

        public BufferType Type => BufferType.TDS_BUF_NORMAL;

        public NormalPacket(IEnumerable<IToken> tokens)
        {
            _tokens = tokens;
        }

        public void Write(Stream stream, Encoding enc)
        {
            Console.WriteLine($"Write {Type}");
            foreach (var token in _tokens)
            {
                token.Write(stream, enc);
            }
        }
    }
}