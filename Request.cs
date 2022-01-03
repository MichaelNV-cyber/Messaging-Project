﻿namespace Hector
{
    internal class Request :Message
    {
        int? classificationLVL;
        int urgency = 1;

        public Request(actionType actionType, messageType messageType, string timeSent, bool isApproved, int urgency, int? classificationLVL) : base(actionType, messageType, timeSent)
        {
            this.urgency = urgency;
            this.classificationLVL = classificationLVL; 
        }
    }
}
