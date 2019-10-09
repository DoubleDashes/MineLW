﻿using MineLW.API.Utils;

namespace MineLW.API.Worlds
{
    public class WorldEnvironment
    {
        public static readonly WorldEnvironment Normal = new WorldEnvironment(Minecraft.CreateKey("overworld"), 0);

        public static readonly WorldEnvironment Nether = new WorldEnvironment(Minecraft.CreateKey("nether"), 1);

        public static readonly WorldEnvironment TheEnd = new WorldEnvironment(Minecraft.CreateKey("the_end"), -1);

        public readonly Identifier Name;
        public readonly int Id;

        private WorldEnvironment(Identifier name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}