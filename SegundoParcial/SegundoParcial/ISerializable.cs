﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    interface ISerializable
    {
        string RutaArchivo { get; set; }

        bool SerializarXML();
    }
}
