using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

public class Question : IEnumerable<Answer>, INotifyPropertyChanged
{
    private sealed class QuestionEnumerator : IEnumerator<Answer>
    {
        public int curpos = -1;
        private MyList <Answer> answers;

        public Answer Current
        {
            get { return answers[curpos]; }
        }
        public bool MoveNext()
        {
            if (curpos < answers.Count - 1)
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

        public QuestionEnumerator(MyList<Answer> answers)
        {
            this.answers = answers;
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }         
    }

    public IEnumerator<Answer> GetEnumerator()
    {
        return new QuestionEnumerator(this.Answers);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
       return GetEnumerator();
    }

    public MyList<Answer> Answers = new MyList<Answer>();

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(String info)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }

    public Question(string text, int ID)
    {
        this._text = text;
        this.ID = ID;
       
    }
    public Question()
    {
        this._text = "";
        this.ID = 0;
    }
    public Question(int ID)
    {
        this._text = "-----------";
        this.ID = ID;
    }

    public string Text{
        get { return this._text; }
        set
        {
            _text = value;
            if (value != this._text)
            {
                NotifyPropertyChanged("Text");
            }
        }
    }
    private string _text = String.Empty;
    public int ID { get; set; }  
     
    public override string ToString()
    {
        return this._text;
    }
}