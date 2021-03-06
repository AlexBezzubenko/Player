using System;

public class MyList<T>
{
    private const int _defaultCapacity = 4;

    private T[] _items;

    private int _size;

    private static readonly T[] _emptyArray = new T[0];

    public MyList()
    {
        _items = _emptyArray;
    }

    public MyList(int capacity)
    {
        if (capacity == 0)
            _items = _emptyArray;
        else
            _items = new T[capacity];
    }

    public int Count
    {
        get
        {
            return _size;
        }
    }

    public int Capacity
    {
        get
        {
            return _items.Length;
        }
        set
        {
            if (value != _items.Length)
            {
                if (value > 0)
                {
                    T[] newItems = new T[value];
                    if (_size > 0)
                    {
                        Array.Copy(_items, 0, newItems, 0, _size);
                    }
                    _items = newItems;
                }
                else
                {
                    _items = _emptyArray;
                }
            }
        }
    }
    
    public T this[int index]
    {
        get
        {
            return _items[index];
        }

        set
        {
            _items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (_size == _items.Length) EnsureCapacity(_size + 1);
        _items[_size++] = item;
    }
    
    public void Clear()
    {
        if (_size > 0)
        {
            Array.Clear(_items, 0, _size);
            _size = 0;
        }
    }

    private void EnsureCapacity(int min)
    {
        if (_items.Length < min)
        {
            int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
            if ((uint)newCapacity > 0X7FEFFFFF) newCapacity = 0X7FEFFFFF;
            if (newCapacity < min) newCapacity = min;
            Capacity = newCapacity;
        }
    }

    public int IndexOf(T item)
    {
        return Array.IndexOf(_items, item, 0, _size);
    }
    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index >= 0)
        {
            RemoveAt(index);
            return true;
        }
        return false;
    }

    public void RemoveAt(int index)
    {
        _size--;
        if (index < _size)
        {
            Array.Copy(_items, index + 1, _items, index, _size - index);
        }
        _items[_size] = default(T);
    }
}