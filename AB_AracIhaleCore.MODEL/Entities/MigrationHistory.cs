﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class MigrationHistory
    {
        public string MigrationId { get; set; }
        public string ContextKey { get; set; }
        public byte[] Model { get; set; }
        public string ProductVersion { get; set; }
    }
}