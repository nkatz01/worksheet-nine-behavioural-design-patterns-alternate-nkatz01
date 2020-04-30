using System;
using System.Threading.Channels;

namespace template
{
    public abstract class ConnectionTemplate
    {
         public  void Run()
        {
            SetDBDriver();
            SetCredentials();
            Connect();
            PrepareStatement();
            SetData();
            Insert();
            Close();
            Destroy();
        }

        public abstract void SetDBDriver();

        public abstract void SetCredentials();

        public virtual void Connect() => Console.WriteLine("Setting connection...");

        public virtual void PrepareStatement() => Console.WriteLine("Preparing insert statement...");

        public abstract void SetData();

        public virtual void Insert() => Console.WriteLine("Inserting data...");

        public virtual void Close() => Console.WriteLine("Closing connections...");

        public virtual void Destroy() => Console.WriteLine("Destroying connection objects...");
    }
}