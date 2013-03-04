using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.BusinessObjects
{
    public abstract class BusinessBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int objectID;

        public int ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }

        protected void OnPropertyChanged<TProperty>(Expression<Func<TProperty>> propertyExpression)
        {
            MemberExpression memberExpression = propertyExpression.Body as MemberExpression;

            if (memberExpression != null)
            {
                OnPropertyChanged(memberExpression.Member.Name);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public BusinessBase(int objectID)
        {
            this.objectID = objectID;
        }

        public BusinessBase()
        {

        }
    }
}
