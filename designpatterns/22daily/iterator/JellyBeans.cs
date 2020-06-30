using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// Our collection item
    /// </summary>
    class JellyBean
    {
        private string _flavour;

        public JellyBean(String flavour)
        {
            this._flavour = flavour;
        }

        public string Flavour
        {
            get { return _flavour; }
        }
    }

    /// <summary>
    /// The aggregate interface
    /// </summary>
    interface ICandyCollection
    {
        JellyBeanIterator CreateIterator();
    }

    /// <summary>
    /// The ConcreteAggregate class
    /// </summary>
    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();
        
        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentJellyBean { get; }
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class JellyBeanIterator : IJellyBeanIterator
    {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;

        public JellyBeanIterator(JellyBeanCollection beans)
        {
            this._jellyBeans = beans;
        }

        public JellyBean First()
        {
            _current = 0;
            return _jellyBeans[_current] as JellyBean;
        }

        public JellyBean Next()
        {
            _current += _step;
            if (!IsDone)
                return _jellyBeans[_current] as JellyBean;
            else
                return null;
        }

        public JellyBean CurrentJellyBean
        {
            get { return _jellyBeans[_current] as JellyBean; }
        }

        public bool IsDone
        {
            get { return _current == _jellyBeans.Count; }
        }
    }
}