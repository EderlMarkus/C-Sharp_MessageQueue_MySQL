using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MessageQueueHandler
{
    public class Handler<T>
    {
        private string connString = @"FormatName:direct=os:";
        private string mqName = @".\private$\";
        private MessageQueue mq;
        public Handler(string mqName)
        {
            this.mqName += mqName;

            if (!MessageQueue.Exists(this.mqName))
            {
                MessageQueue.Create(this.mqName);
            }

            mq = new MessageQueue(connString + this.mqName);

            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
        }

        public void Send(T data)
        {
            mq.Send(data);
        }

        public T Read()
        {
            return (T)mq.Receive().Body;
        }
    }
}
