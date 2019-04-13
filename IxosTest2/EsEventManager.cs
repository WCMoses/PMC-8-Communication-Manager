using System;

namespace IxosTest2
{
     public static class EsEventManager
    {
        public static event EventHandler<EsEventArgs> EsEventRaised;
        public static void RaiseEsEvent(EsEventArgs e)
        {
            EventHandler<EsEventArgs> handler = EsEventRaised;
            handler?.Invoke(null, e);
        }

        #region Publish Overloads
        public static void PublishEsEvent(EsEventSenderEnum sender, string messageType, EsMessagePriority priority,
                                           string message, EsException esException, Exception exception,
                                           string Notes)
        {
            EsEventArgs e = new EsEventArgs(sender,
                                            messageType,
                                            priority,
                                            message,
                                            esException,
                                            exception,
                                            Notes);

            RaiseEsEvent(e);
        }
        
        public static void PublishEsEvent(EsEventSenderEnum sender, EsMessagePriority priority, string message)
        {
            EsEventArgs e = new EsEventArgs(sender,
                                            null,
                                            priority,
                                            message,
                                            null,
                                            null,
                                            null);
            RaiseEsEvent(e);
        }
        #endregion

    }

}
