using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueueProject
{
    class Node
    {
        public int info;
        public int priority;
        public Node link;

        public Node(int i,int pr)
        {
            info = i;
            priority = pr;
            link = null;
        }
    }
}
