﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using ProjectTracker.Library.Data;

namespace ProjectTracker.Library.Framework
{
    [Serializable]
    public abstract class PTBusinessBase<T> : BusinessBase<T>
        where T : BusinessBase<T>
    {
        public virtual void SetNHibernateCriteria(object businessCriteria, NHibernate.ICriteria nhibernateCriteria) { }
        public virtual object GetObjectCriteriaValue(object businessCriteria)
        {
            return null;
        }

        protected internal virtual void InitializeObject()
        {
            MarkOld();   
        }
    }
}
