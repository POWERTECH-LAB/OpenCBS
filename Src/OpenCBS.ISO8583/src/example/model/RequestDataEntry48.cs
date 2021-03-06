﻿using Free.iso8583.config.attribute;
/**
 *  Distributed as part of Free.iso8583
 *  
 *  Free.iso8583 is ISO 8583 Message Processor library that makes message parsing/compiling esier.
 *  It will convert ISO 8583 message to a model object and vice versa. So, the other parts of
 *  application will only do the rest effort to make business process done.
 *  
 *  This library is free software; you can redistribute it and/or
 *  modify it under the terms of the GNU Lesser General Public
 *  License as published by the Free Software Foundation; either
 *  version 2.1 of the License or (at your option) any later version. 
 *  See http://gnu.org/licenses/lgpl.html
 *
 *  Developed by AT Mulyana (atmulyana@yahoo.com) 2009-2015
 *  The latest update can be found at sourceforge.net
 **/
using System;

namespace Free.iso8583.example.model
{
    public class RequestDataEntry48
    {
        [BitContentField(Length = 5, PadChar = '0', Align = FieldAlignment.Right)]
        public String ProductCode { get; set; }

        [BitContentField(Length = 50, PadChar = ' ', Align = FieldAlignment.Left, NullChar=' ', IsTrim = true)]
        public String Note { get; set; }

        [BitContentField(TlvTagName = "FD", TlvLengthBytes = 1)]
        public decimal Fee { get; set; }

        public override string ToString()
        {
            String fee = Math.Round(Fee)+"";
            if (fee.Length > 9) fee = fee.Substring(fee.Length-9, 9);
            return (ProductCode == null ? "".PadLeft(5, ' ') : ProductCode.PadLeft(5, '0'))
                + (Note == null ? "" : Note).PadRight(50, ' ')
                + "FD" + fee.Length + fee;
        }
    }
}
