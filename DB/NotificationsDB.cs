using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Db4objects.Db4o;
using FreeCell_Project.Model;

namespace FreeCell_Project.DB
{
    class NotificationsDB
    {
        private IObjectContainer db;

        public NotificationsDB()
        {
            this.db = Db4oEmbedded.OpenFile("notifications.yap");
        }

        public List<Notification> all()
        {
            IObjectSet result = db.QueryByExample(typeof(Notification));

            List<Notification> notifications = new List<Notification>();

            while (result.HasNext())
            {
                notifications.Add((Notification)result.Next());
            }

            return notifications;
        }

        public Notification find(Notification notf)
        {
            IObjectSet result = this.db.QueryByExample(new Notification(notf.Name));

            Notification found = null;
            if (result.HasNext()) found = (Notification)result.Next();

            return found;
        }

        public void save(Notification notif)
        {
            Notification newNotif = new Notification(null);

            IObjectSet result = db.QueryByExample(new Notification(notif.Name));
            if (result.HasNext()) newNotif = (Notification)result.Next();

            newNotif.Name = notif.Name;
            newNotif.Active = notif.Active;
            newNotif.Interval = notif.Interval;

            db.Store(newNotif);
        }

        public void delete(Notification notf)
        {
            IObjectSet result = db.QueryByExample(new Notification(notf.Name));

            if (result.HasNext())
            {
                Notification found = (Notification)result.Next();

                db.Delete(found);
            }
        }

        public void closeDBConnection()
        {
            db.Close();
        }

        public void reload() {
            db.Close();

            this.db = Db4oEmbedded.OpenFile("notifications.yap");
        }
    }
}
