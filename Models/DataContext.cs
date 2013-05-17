using EFTracingProvider;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public partial class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }

        public DataContext()
        //    : base(EFTracingProviderUtils.CreateTracedEntityConnection("name=Entities"), true)
        {
            /*
            var cx = ((IObjectContextAdapter)this).ObjectContext;
            cx.EnableTracing();

            IEnumerable<EFTracingConnection> traceConnections = cx.Connection.GetTracingConnections();
            List<EFTracingConnection> myList = new List<EFTracingConnection>(traceConnections);
            myList.ForEach(
                c =>
                {
                    c.CommandExecuting += (s, e) => LogSql(e);
                    c.CommandFailed += (s, e) => LogSql(e);
                    c.CommandFinished += (s, e) => LogSql(e);
                });
            */
        }

        protected void LogSql(CommandExecutionEventArgs e)
        {
            throw new InvalidOperationException(e.ToTraceString());
            //Console.WriteLine(e.ToTraceString());
        }

    }
}