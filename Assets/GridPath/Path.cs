﻿using System.Collections.Generic;

namespace GridPath
{
    public class Path
    {
        public PathNode StartNode;
        public List<PathNode> Nodes;
        public bool Found;

        public void Reset()
        {
            StartNode = null;
            Found = false;
            if(Nodes == null)
            {
                Nodes = new List<PathNode>();
            }
            Nodes.Clear();
        }
    }
}
