using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

    public class QuestionCollection:List<Question> ,IEnumerable<Question>, INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private sealed class TestEnumerator : IEnumerator<Question>
        {
            

            public int curpos = -1;
            private List<Question> questions;

            public TestEnumerator(List<Question> questions)
            {
                this.questions = questions;
                
            }

            public Question Current
            {
                get { return questions[curpos]; }
            }

            public bool MoveNext()
            {
                if (curpos < questions.Count - 1)
                {
                    curpos++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                curpos = -1;
            }

            public void Dispose()
            {
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }
        }

        public IEnumerator<Question> GetEnumerator()
        {
            return new TestEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

            //return (IEnumerator)this;
        }

        public void Add(Question q)
        {
            base.Add(q);
            
            if (CollectionChanged != null)
            {
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, q));
            }
        }

        public void Remove(Question q)
        {
            base.RemoveAt(this.IndexOf(q));
            if (CollectionChanged != null)
            {
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, q));
            }
        }
        public int FindIndex(Question q)
        {
            return this.IndexOf(q);           
        }

    
       // #region INotifyCollectionChanged Members
        
       // #endregion
    }

