using System;

namespace IxosTest2
{
    public class EsEventArgs : EventArgs
    {
        public EsEventSenderEnum Sender;
        public string MessageType;
        public EsMessagePriority Priority;
        public string Message;
        public EsException EsException;
        public ApplicationException Exception;
        public string Notes;

        public EsEventArgs(EsEventSenderEnum sender,
                                           string messageType,
                                           EsMessagePriority priority,
                                           string message,
                                           EsException esException,
                                           ApplicationException exception,
                                           string notes)
        {
            Sender = sender;
            MessageType = messageType;
            Priority = priority;
            Message = message;
            EsException = esException;
            Exception = exception;
            Notes = notes;
        }
        public EsEventArgs()
        {

        }
    }

    public enum EsMessagePriority
    {
        GeneralInfo = 1,
        DetailedInfo = 2,
        DebugInfo = 3,
        None
    }
    public enum EsEventSenderEnum
    {
        EsMountManager = 1,
        ComManager = 2,
        EsMount = 3,
        Unspecified = 4
    }
}
